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
        public partial class CustomerForm : Form
    {
            private ShopEntitie ShopContainer;
       
        public CustomerForm()
        {
            InitializeComponent();
            ShopContainer = new ShopEntitie();
        }

        
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this.RefrehButton.PerformClick();
        }

        private void RefrehButton_Click(object sender, EventArgs e)
        {
            var query = ShopContainer.Customers;

            customerBindingSource.DataSource = query.ToList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShopContainer.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            AddCustomer dialog = new AddCustomer(this.ShopContainer);
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;


            this.ShopContainer.Customers.Add(dialog.CustomerValue);
        }
    }
}
