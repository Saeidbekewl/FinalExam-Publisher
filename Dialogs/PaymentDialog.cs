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
    public partial class PaymentDialog : Form
    {
        private ShopEntitie ShopContainer;
        
        public PaymentDialog()
        {
            InitializeComponent();
            ShopContainer = new ShopEntitie();
        }

        private void RefrehButton_Click(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = ShopContainer.Customers.ToArray();
            payTypeBindingSource.DataSource = ShopContainer.PayTypes.ToArray();

            var query = ShopContainer.Payments;
            paymentBindingSource.DataSource = query.ToList();
           
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

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ShopContainer.SaveChanges();
        }

        private void RefrehButton_Click_1(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = ShopContainer.Customers.ToArray();
            payTypeBindingSource.DataSource = ShopContainer.PayTypes.ToArray();

            var query = ShopContainer.Payments;
            paymentBindingSource.DataSource = query.ToList();
        }

        private void PaymentDialog_Load(object sender, EventArgs e)
        {
            this.RefrehButton.PerformClick();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPayment paymentdialog = new AddPayment(this.ShopContainer);
            if (paymentdialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            this.ShopContainer.Payments.Add(paymentdialog.paymentvalue);
        }
    }
}
