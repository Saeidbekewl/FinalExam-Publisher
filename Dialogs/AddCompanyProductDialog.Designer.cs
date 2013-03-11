namespace FinalExamApp.Dialogs
{
    partial class AddCompanyProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OkButton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.BuyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuyPriceLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.MaskedTextBox();
            this.Company = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(204, 349);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(87, 25);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "&Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelbutton.Location = new System.Drawing.Point(297, 351);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 0;
            this.Cancelbutton.Text = "&Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.Controls.Add(this.BuyNumericUpDown);
            this.GroupBox.Controls.Add(this.BuyPriceLabel);
            this.GroupBox.Controls.Add(this.CodeLabel);
            this.GroupBox.Controls.Add(this.Code);
            this.GroupBox.Controls.Add(this.Company);
            this.GroupBox.Controls.Add(this.TitleLabel);
            this.GroupBox.Controls.Add(this.ProductTextBox);
            this.GroupBox.Controls.Add(this.ProductLabel);
            this.GroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(364, 333);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Product ";
            // 
            // BuyNumericUpDown
            // 
            this.BuyNumericUpDown.Location = new System.Drawing.Point(89, 151);
            this.BuyNumericUpDown.Name = "BuyNumericUpDown";
            this.BuyNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.BuyNumericUpDown.TabIndex = 13;
            this.BuyNumericUpDown.Visible = false;
            // 
            // BuyPriceLabel
            // 
            this.BuyPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyPriceLabel.AutoSize = true;
            this.BuyPriceLabel.Location = new System.Drawing.Point(17, 159);
            this.BuyPriceLabel.Name = "BuyPriceLabel";
            this.BuyPriceLabel.Size = new System.Drawing.Size(61, 14);
            this.BuyPriceLabel.TabIndex = 12;
            this.BuyPriceLabel.Text = "Buy Price:";
            this.BuyPriceLabel.Visible = false;
            // 
            // CodeLabel
            // 
            this.CodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(17, 120);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(38, 14);
            this.CodeLabel.TabIndex = 2;
            this.CodeLabel.Text = "Code:";
            // 
            // Code
            // 
            this.Code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Code.Location = new System.Drawing.Point(89, 117);
            this.Code.Mask = "00000";
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(253, 22);
            this.Code.TabIndex = 3;
            this.Code.ValidatingType = typeof(int);
            // 
            // Company
            // 
            this.Company.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Company.FormattingEnabled = true;
            this.Company.Location = new System.Drawing.Point(89, 65);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(250, 22);
            this.Company.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(17, 73);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(61, 14);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Co&mpany:";
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductTextBox.Location = new System.Drawing.Point(89, 25);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(253, 22);
            this.ProductTextBox.TabIndex = 10;
            // 
            // ProductLabel
            // 
            this.ProductLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(17, 33);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(53, 14);
            this.ProductLabel.TabIndex = 9;
            this.ProductLabel.Text = "&Product:";
            // 
            // AddCompanyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 386);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OkButton);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddCompanyProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.ComboBox Company;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.MaskedTextBox Code;
        private System.Windows.Forms.NumericUpDown BuyNumericUpDown;
        private System.Windows.Forms.Label BuyPriceLabel;
    }
}