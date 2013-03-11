using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalExamApp.Dialogs
{
    public partial class ComanyForm : Form
    {
        //private int CSID;
        //private int RowId;
        private ShopEntitie ShopContainer;
        private BindingSource bs = new BindingSource();
        private BindingList<Price> dataSource = new BindingList<Price>();


        public ComanyForm()
        {
            InitializeComponent();
            ShopContainer = new ShopEntitie();

        }

        private void RefrehButton_Click(object sender, EventArgs e)
        {
            //productViewBindingSource.DataSource = ShopContainer.ProductViews.ToArray();
            CompanyBindingSource.DataSource = ShopContainer.Companies.ToArray();
            ////PriceBindingSource.DataSource = ShopContainer.Prices.ToArray();
            productBindingSource.DataSource = ShopContainer.Products.ToArray();
            

            //var query = (
            //            from b in ShopContainer.Prices

            //            select new { Commapny = b.Product.Company.Title, Code = b.Product.Code, Product = b.Product.Title, BuyPrice = b.Buy, SellPrice = b.Sell }
            //            ).ToArray();

            //this.DataGridView.DataSource = query;

            //var pquery = (
            //            from c in ShopContainer.Products

            //            select new { Commapny = c.Company.Title, Code = c.Code, Product = c.Title }
            //            ).ToString();

            //this.DataGridView.DataSource = pquery;



        }

        private void ComanyForm_Load(object sender, EventArgs e)
        {
            this.RefrehButton.PerformClick();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            AddCompanyProduct dialog = new AddCompanyProduct(this.ShopContainer);

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;


            this.ShopContainer.Products.Add(dialog.productvalue);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (this.DataGridView.SelectedRows.Count == 0)
                return;
            Product product = (Product)this.DataGridView.SelectedRows[0].Tag;

            if (MessageBox.Show(string.Format("Do you want to remove ?"), "Delete"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                return;

            this.ShopContainer.Entry(product).State = EntityState.Deleted;
            bs.RemoveAt(this.DataGridView.SelectedRows[0].Index);
           
            //int selectedCount = DataGridView.SelectedRows.Count;
            //while (selectedCount > 0)
            //{
            //    if (!DataGridView.SelectedRows[0].IsNewRow)
            //        DataGridView.Rows.RemoveAt(DataGridView.SelectedRows[0].Index);
            //    selectedCount--;
            //}



        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.DataGridView.SelectedRows.Count == 0)
                return;

            Product P = (Product)this.DataGridView.SelectedRows[0].Tag;
            AddCompanyProduct dialog = new AddCompanyProduct(this.ShopContainer)
            {
                productvalue = P
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            dialog.RefreshProductValues();
            this.ShopContainer.Entry(P).State = EntityState.Modified;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var product = ShopContainer.Products.Where(c => c.ID == 1).First();
            //product.Code = "15965";

            //ShopContainer.SaveChanges();

            //    var newproduct = new Product
            //    {
            //        CompanyID = 3,
            //        Code="15965",
            //        Title="Hichi"
            //    };
            //  //  ShopContainer.Products.Add(newproduct);
            //    ShopContainer.SaveChanges();
            }



        }
    }

       
   