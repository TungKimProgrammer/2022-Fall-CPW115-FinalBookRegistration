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
            this.dtpRegistration = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblBookRegistration = new System.Windows.Forms.Label();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.btnManageBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnManageRegistration = new System.Windows.Forms.Button();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxCustomerName
            // 
            this.cbxCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerName.FormattingEnabled = true;
            this.cbxCustomerName.Location = new System.Drawing.Point(38, 105);
            this.cbxCustomerName.Name = "cbxCustomerName";
            this.cbxCustomerName.Size = new System.Drawing.Size(200, 23);
            this.cbxCustomerName.TabIndex = 1;
            this.cbxCustomerName.Tag = "";
            this.cbxCustomerName.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerName_SelectedIndexChanged);
            // 
            // cbxBookTitle
            // 
            this.cbxBookTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBookTitle.FormattingEnabled = true;
            this.cbxBookTitle.Location = new System.Drawing.Point(38, 171);
            this.cbxBookTitle.Name = "cbxBookTitle";
            this.cbxBookTitle.Size = new System.Drawing.Size(200, 23);
            this.cbxBookTitle.TabIndex = 2;
            // 
            // dtpRegistration
            // 
            this.dtpRegistration.Location = new System.Drawing.Point(38, 237);
            this.dtpRegistration.Name = "dtpRegistration";
            this.dtpRegistration.Size = new System.Drawing.Size(200, 23);
            this.dtpRegistration.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(56, 309);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(165, 48);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "&Register Book";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(280, 105);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(153, 61);
            this.btnManageCustomer.TabIndex = 4;
            this.btnManageCustomer.Text = "Manage &Customer";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // btnManageBook
            // 
            this.btnManageBook.Location = new System.Drawing.Point(280, 178);
            this.btnManageBook.Name = "btnManageBook";
            this.btnManageBook.Size = new System.Drawing.Size(153, 61);
            this.btnManageBook.TabIndex = 5;
            this.btnManageBook.Text = "Manage &Book";
            this.btnManageBook.UseVisualStyleBackColor = true;
            this.btnManageBook.Click += new System.EventHandler(this.btnManageBook_Click);
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
            // btnManageRegistration
            // 
            this.btnManageRegistration.Location = new System.Drawing.Point(280, 251);
            this.btnManageRegistration.Name = "btnManageRegistration";
            this.btnManageRegistration.Size = new System.Drawing.Size(153, 61);
            this.btnManageRegistration.TabIndex = 7;
            this.btnManageRegistration.Text = "Manage Registr&ation";
            this.btnManageRegistration.UseVisualStyleBackColor = true;
            this.btnManageRegistration.Click += new System.EventHandler(this.btnManageRegistration_Click);
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsg.Location = new System.Drawing.Point(38, 274);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(38, 15);
            this.lblErrMsg.TabIndex = 8;
            this.lblErrMsg.Text = "label1";
            // 
            // FrmBookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 400);
            this.Controls.Add(this.lblErrMsg);
            this.Controls.Add(this.btnManageRegistration);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnManageBook);
            this.Controls.Add(this.btnManageCustomer);
            this.Controls.Add(this.lblBookRegistration);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpRegistration);
            this.Controls.Add(this.cbxBookTitle);
            this.Controls.Add(this.cbxCustomerName);
            this.Name = "FrmBookRegistration";
            this.Text = "Book Registration";
            this.Load += new System.EventHandler(this.FrmBookRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxCustomerName;
        private ComboBox cbxBookTitle;
        private DateTimePicker dtpRegistration;
        private Button btnRegister;
        private Label lblBookRegistration;
        private Button btnManageCustomer;
        private Button btnManageBook;
        private Button btnCancel;
        private Button btnManageRegistration;
        private Label lblErrMsg;
    }
}