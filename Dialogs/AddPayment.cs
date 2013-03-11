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
    public partial class AddPayment : Form
    {
        private ShopEntitie ShopContainer;
        public AddPayment(ShopEntitie shopContainer)
        {
            InitializeComponent();
            ShopContainer = new ShopEntitie();

            Customer[] title = shopContainer.Customers.ToArray();
            this.customer.DataSource = title;
            this.customer.ValueMember = this.customer.ValueMember = "ID";
            this.customer.DisplayMember = this.customer.DisplayMember = "FullName";
            if (ShopContainer == null)
                return;
            this.ShopContainer = shopContainer;
            this.customer.DataSource = shopContainer.Customers
                .OrderBy(b => b.FullName)
                .ToArray();
            this.customer.ValueMember = "ID";
            this.customer.DisplayMember = "FullName";
            if (ShopContainer == null)
                return;


            PayType[] pttitle = shopContainer.PayTypes.ToArray();
            this.Paytype.DataSource = pttitle;
            this.Paytype.ValueMember = this.Paytype.ValueMember = "ID";
            this.Paytype.DisplayMember = this.Paytype.DisplayMember = "Title";
            if (ShopContainer == null)
                return;
            this.ShopContainer = shopContainer;
            this.Paytype.DataSource = shopContainer.PayTypes
                .OrderBy(c => c.Title)
                .ToArray();
            this.Paytype.ValueMember = "ID";
            this.Paytype.DisplayMember = "Title";
            if (ShopContainer == null)
                return;

        }
        private Payment _Payment;
        public void RefreshPaymentValues()
        {
            if (_Payment == null)
                return;
            _Payment.Customer = (Customer)this.customer.SelectedItem;
            _Payment.PayType = (PayType)this.Paytype.SelectedItem;
            //_Payment.Date = this.dateDateTimePicker;
            _Payment.Value = int.Parse(this.Value.Text);

        }


        public Payment paymentvalue
        {
            get
            {
                this.RefreshPaymentValues();
                return _Payment;
            }
            set
            {
                _Payment = value;
                if (value == null)
                    return;

                this.customer.SelectedItem = value.Customer;
                this.Paytype.SelectedItem = value.PayType;
                //this.dateDateTimePicker.Text = value.Date;
                //int.Parse(this.Value.Text) = value.Value;
            }
        }


        private void AddPayment_Load(object sender, EventArgs e)
        {

        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}


