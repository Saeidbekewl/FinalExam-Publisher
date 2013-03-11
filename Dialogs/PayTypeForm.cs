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
    public partial class PayTypeForm : Form
    {
        ShopEntitie ShopCointainer;
        public PayTypeForm()
        {
            
            InitializeComponent();
            ShopCointainer = new ShopEntitie();

            if (ShopCointainer == null)
                return;

          


            if (ShopCointainer == null)
                return;
        }

        private PayType _PayType;
        public void RefreshPayTypeValue()
        {
            if (_PayType == null)
                _PayType = new PayType();
            _PayType.Title = PayTypeTextBox.Text;
            
        }

        public PayType PayTypeValue
        {
            get
            {
                this.RefreshPayTypeValue();
                return _PayType;
            }
            set
            {
                _PayType = value;
                if (value == null)
                    return;

                PayTypeTextBox.Text = value.Title;
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = ShopCointainer.PayTypes;

            payTypeBindingSource.DataSource = query.ToList();
              
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ShopCointainer.SaveChanges();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.GroupBox.Visible = true;
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ShopCointainer.PayTypes.Add(this.PayTypeValue);
        }

        private void PayTypeForm_Load(object sender, EventArgs e)
        {
            this.button1.PerformClick();
        }
    }
}
