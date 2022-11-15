namespace FinalBookRegistration
{
    partial class FrmBookRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxCustomerName = new System.Windows.Forms.ComboBox();
            this.cbxBookTitle = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblBookRegistration = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCustomerName
            // 
            this.cbxCustomerName.FormattingEnabled = true;
            this.cbxCustomerName.Location = new System.Drawing.Point(38, 105);
            this.cbxCustomerName.Name = "cbxCustomerName";
            this.cbxCustomerName.Size = new System.Drawing.Size(200, 23);
            this.cbxCustomerName.TabIndex = 1;
            // 
            // cbxBookTitle
            // 
            this.cbxBookTitle.FormattingEnabled = true;
            this.cbxBookTitle.Location = new System.Drawing.Point(38, 171);
            this.cbxBookTitle.Name = "cbxBookTitle";
            this.cbxBookTitle.Size = new System.Drawing.Size(200, 23);
            this.cbxBookTitle.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(56, 309);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(165, 48);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "&Register Book";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblBookRegistration
            // 
            this.lblBookRegistration.AutoSize = true;
            this.lblBookRegistration.Location = new System.Drawing.Point(119, 38);
            this.lblBookRegistration.Name = "lblBookRegistration";
            this.lblBookRegistration.Size = new System.Drawing.Size(100, 15);
            this.lblBookRegistration.TabIndex = 0;
            this.lblBookRegistration.Text = "Book Registration";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(280, 105);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(153, 86);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add &Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(280, 222);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(153, 86);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add &Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmBookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblBookRegistration);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxBookTitle);
            this.Controls.Add(this.cbxCustomerName);
            this.Name = "FrmBookRegistration";
            this.Text = "Book Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxCustomerName;
        private ComboBox cbxBookTitle;
        private DateTimePicker dateTimePicker1;
        private Button btnRegister;
        private Label lblBookRegistration;
        private Button btnAddCustomer;
        private Button btnAddBook;
        private Button btnCancel;
    }
}