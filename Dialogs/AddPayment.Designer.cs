namespace FinalExamApp.Dialogs
{
    partial class AddPayment
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label titleLabel;
            this.customer = new System.Windows.Forms.ComboBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Value = new System.Windows.Forms.TextBox();
            this.Paytype = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            customerIDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(22, 18);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(77, 14);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "Customer ID:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(22, 77);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(35, 14);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(22, 108);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(41, 14);
            valueLabel.TabIndex = 8;
            valueLabel.Text = "Value:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(22, 46);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(34, 14);
            titleLabel.TabIndex = 20;
            titleLabel.Text = "Title:";
            // 
            // customer
            // 
            this.customer.FormattingEnabled = true;
            this.customer.Location = new System.Drawing.Point(105, 15);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(200, 22);
            this.customer.TabIndex = 1;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(105, 73);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 3;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(105, 105);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(200, 22);
            this.Value.TabIndex = 9;
            // 
            // Paytype
            // 
            this.Paytype.FormattingEnabled = true;
            this.Paytype.Location = new System.Drawing.Point(105, 43);
            this.Paytype.Name = "Paytype";
            this.Paytype.Size = new System.Drawing.Size(200, 22);
            this.Paytype.TabIndex = 21;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 167);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 22;
            this.OkButton.Text = "button1";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(258, 167);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "button1";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 202);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.Paytype);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customer);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.Value);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPayment";
            this.Load += new System.EventHandler(this.AddPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customer;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.ComboBox Paytype;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}