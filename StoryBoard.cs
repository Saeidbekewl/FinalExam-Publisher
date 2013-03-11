using FinalExamApp.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamApp
{
    public partial class StoryBoardForm : Form
    {
        
        public StoryBoardForm()
        {
            InitializeComponent();
            
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            ShowForm<CompanyDialog>();
           
        }


        private void ShowForm<t>() where t : Form, new()
        {
            this.Hide();
            t form = new t();
            form.FormClosed += (s, e) => this.Show();
            form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
          ShowForm<CustomerForm>();
           
        }

        private void InvoiceItem_Button(object sender, EventArgs e)
        {
            ShowForm<PaymentDialog>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm<PayTypeForm>();

        }

        private void StoryBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void CompanyGridViewButton_Click(object sender, EventArgs e)
        {
            ShowForm<ComanyForm>();
        }
    }
}
