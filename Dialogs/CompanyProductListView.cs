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
    public partial class CompanyDialog : Form
    {
        private ShopEntitie ShopContainer;
        private BindingSource bs = new BindingSource();


        public CompanyDialog()
        {
            InitializeComponent();
            ShopContainer = new ShopEntitie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ListView.Items.Clear();

            var query = this.ShopContainer
                .Products
                .Include("Company")
                .OrderBy(b => b.Company.Title);

            ListViewGroup Group = null;
            Price price = new Price();
            foreach (Product product in query)
            {
                if (Group == null || Group.Header != product.Company.Title)
                    Group = new ListViewGroup()
                    {
                        Header = product.Company.Title
                    };
                this.ListView.Groups.Add(Group);

                 ListViewItem item = new ListViewItem()
                    {
                        Group = Group,
                        Text = product.Title,
                        ImageIndex=2,
                        Tag= product

                    };

                 item.SubItems.Add(string.Format("Code: {0},Price: {1}",
                     product.Code,price.Buy));

                 this.ListView.Items.Add(item);
            }

            }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCompanyProductForm dialog = new AddCompanyProductForm(this.ShopContainer);

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;


            this.ShopContainer.Products.Add(dialog.productvalue);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.ListView.SelectedItems.Count == 0)
                return;
            Product product = (Product)this.ListView.SelectedItems[0].Tag;

            if (MessageBox.Show(string.Format("Do you want to remove ?"), "Delete"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                return;

            this.ShopContainer.Entry(product).State = EntityState.Deleted;
            this.ListView.Items.RemoveAt(this.ListView.SelectedItems[0].Index);
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.ListView.SelectedItems.Count == 0)
                return;

            Product P = (Product)this.ListView.SelectedItems[0].Tag;
            AddCompanyProduct dialog = new AddCompanyProduct(this.ShopContainer)
            {
                productvalue = P
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            dialog.RefreshProductValues();
            this.ShopContainer.Entry(P).State = EntityState.Modified;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddCompanyProductForm dialog = new AddCompanyProductForm(this.ShopContainer);

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;


            this.ShopContainer.Products.Add(dialog.productvalue);
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
             if (this.ListView.SelectedItems.Count == 0)
                return;

            Product P = (Product)this.ListView.SelectedItems[0].Tag;
            AddCompanyProduct dialog = new AddCompanyProduct(this.ShopContainer)
            {
                productvalue = P
            };

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            dialog.RefreshProductValues();
            this.ShopContainer.Entry(P).State = EntityState.Modified;
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.ListView.SelectedItems.Count == 0)
                return;
            Product product = (Product)this.ListView.SelectedItems[0].Tag;

            if (MessageBox.Show(string.Format("Do you want to remove ?"), "Delete"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                return;

            this.ShopContainer.Entry(product).State = EntityState.Deleted;
            this.ListView.Items.RemoveAt(this.ListView.SelectedItems[0].Index);
        }

        private void SyncToolStripButton_Click(object sender, EventArgs e)
        {
            this.ListView.Items.Clear();

            var query = this.ShopContainer
                .Products
                .Include("Company")
                .OrderBy(b => b.Company.Title);

            ListViewGroup Group = null;

            foreach (Product product in query)
            {
                if (Group == null || Group.Header != product.Company.Title)
                    Group = new ListViewGroup()
                    {
                        Header = product.Company.Title
                    };
                this.ListView.Groups.Add(Group);

                ListViewItem item = new ListViewItem()
                {
                    Group = Group,
                    Text = product.Title,
                    ImageIndex = 2,
                    Tag = product

                };

                item.SubItems.Add(string.Format("Code: {0}",
                    product.Code));

                this.ListView.Items.Add(item);
        }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
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

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyDialog_Load(object sender, EventArgs e)
        {
            this.RefreshButton.PerformClick();
        }
        }

           
    }

