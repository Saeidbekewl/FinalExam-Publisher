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
    public partial class AddCompanyProduct : Form
    {
        private ShopEntitie ShopContainer;
        
        public AddCompanyProduct(ShopEntitie shopContainer)
        {
            InitializeComponent();

            
            Company[] title = shopContainer.Companies.ToArray();
            this.Company.DataSource = title;
            this.Company.ValueMember = this.Company.ValueMember = "ID";
            this.Company.DisplayMember = this.Company.DisplayMember = "Title";


            if (ShopContainer == null)
                return;

            this.ShopContainer = shopContainer;
            this.Company.DataSource = shopContainer.Companies
                .OrderBy(a => a.Title)
                .ToArray();
            this.Company.ValueMember = "ID";
            this.Company.DisplayMember = "Title";

            if (ShopContainer == null)
                return;

        }

        private Price _Price;
        public void RefreshPriceValues()
        {
            if (_Price == null)
                _Price = new Price();

            _Price.Buy = (int)BuyNumericUpDown.Value;
            

        }


        private Company _Company;
        public void RefreshCompanyValues()
        {
            if (_Company == null)
                _Company = new Company();

            _Company.Title = this.Company.Text;
            

        }

        private Product _Product;
        public void RefreshProductValues()
        {
            if (_Product == null)
                _Product = new Product();
            _Product.Title = this.ProductTextBox.Text;
            _Product.Company = (Company)this.Company.SelectedItem;
            _Product.Code = this.Code.Text;
        }


        public Price pricevalue
        {
            
            get
            {
                this.RefreshPriceValues();
                return _Price;
            }
            set
            {
                _Price = value;
                if (value == null)
                    return;

            BuyNumericUpDown.Value = value.Buy;            
            }
        }

        public Company companyvalue
        {
            get
            {
                this.RefreshCompanyValues();
                return _Company;
            }
            set
            {
                _Company = value;
                if (value == null)
                    return;

                this.Company.Text = value.Title;
               
            }
        }

        public Product productvalue
        {
            get
            {
                this.RefreshProductValues();
                return _Product;
            }
            set
            {
                _Product = value;
                if (value == null)
                    return;

                this.ProductTextBox.Text = value.Title;
                this.Company.SelectedItem = value.Company;
                this.Code.Text = value.Code;
            }
        }


        


        public AddCompanyProduct()
        {
            // TODO: Complete member initialization
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
