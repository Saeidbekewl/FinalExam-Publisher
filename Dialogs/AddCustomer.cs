using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamApp.Dialogs
{
    public partial class AddCustomer : Form
    {
        private ShopEntitie ShopContainer;
        public AddCustomer(ShopEntitie shopContainer)
        {
            InitializeComponent();
           

            if (ShopContainer == null)
                return;

            this.ShopContainer = shopContainer;
            

            if (ShopContainer == null)
                return;

        }
        private Customer _Customer;
        public void RefreshCustomerValue()
        {
            if (_Customer == null)
                _Customer = new Customer();
            _Customer.FirstName = FirstNametextBox.Text;
            _Customer.LastName = LastNameTextBox.Text;
        }

        public Customer CustomerValue
        {
            get
            {
                this.RefreshCustomerValue();
                return _Customer;
            }
            set
            {
                _Customer = value;
                if (value == null)
                    return;

                FirstNametextBox.Text = value.FirstName;
                LastNameTextBox.Text = value.LastName;

            }

        }

        

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
