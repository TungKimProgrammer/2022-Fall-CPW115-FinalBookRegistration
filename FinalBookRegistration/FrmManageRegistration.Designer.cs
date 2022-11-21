namespace FinalBookRegistration
{
    partial class FrmManageRegistration
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
            this.lblRegistrationManagingTool = new System.Windows.Forms.Label();
            this.lstRegistrations = new System.Windows.Forms.ListBox();
            this.btnRemoveRegistration = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lstBooksAndRegDate = new System.Windows.Forms.ListBox();
            this.btnRemoveRegisteredBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistrationManagingTool
            // 
            this.lblRegistrationManagingTool.AutoSize = true;
            this.lblRegistrationManagingTool.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRegistrationManagingTool.Location = new System.Drawing.Point(122, 19);
            this.lblRegistrationManagingTool.Name = "lblRegistrationManagingTool";
            this.lblRegistrationManagingTool.Size = new System.Drawing.Size(316, 32);
            this.lblRegistrationManagingTool.TabIndex = 0;
            this.lblRegistrationManagingTool.Text = "Registration Managing Tool";
            // 
            // lstRegistrations
            // 
            this.lstRegistrations.FormattingEnabled = true;
            this.lstRegistrations.ItemHeight = 15;
            this.lstRegistrations.Location = new System.Drawing.Point(22, 248);
            this.lstRegistrations.Name = "lstRegistrations";
            this.lstRegistrations.Size = new System.Drawing.Size(584, 319);
            this.lstRegistrations.TabIndex = 1;
            this.lstRegistrations.SelectedIndexChanged += new System.EventHandler(this.lstRegistrations_SelectedIndexChanged);
            // 
            // btnRemoveRegistration
            // 
            this.btnRemoveRegistration.Location = new System.Drawing.Point(627, 544);
            this.btnRemoveRegistration.Name = "btnRemoveRegistration";
            this.btnRemoveRegistration.Size = new System.Drawing.Size(141, 23);
            this.btnRemoveRegistration.TabIndex = 2;
            this.btnRemoveRegistration.Text = "Remove Registration";
            this.btnRemoveRegistration.UseVisualStyleBackColor = true;
            this.btnRemoveRegistration.Click += new System.EventHandler(this.btnRemoveRegistration_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 15;
            this.lstCustomers.Location = new System.Drawing.Point(22, 102);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(225, 124);
            this.lstCustomers.TabIndex = 3;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // lstBooksAndRegDate
            // 
            this.lstBooksAndRegDate.FormattingEnabled = true;
            this.lstBooksAndRegDate.ItemHeight = 15;
            this.lstBooksAndRegDate.Location = new System.Drawing.Point(262, 102);
            this.lstBooksAndRegDate.Name = "lstBooksAndRegDate";
            this.lstBooksAndRegDate.Size = new System.Drawing.Size(344, 124);
            this.lstBooksAndRegDate.TabIndex = 4;
            this.lstBooksAndRegDate.SelectedIndexChanged += new System.EventHandler(this.lstBooksAndRegDate_SelectedIndexChanged);
            // 
            // btnRemoveRegisteredBook
            // 
            this.btnRemoveRegisteredBook.Location = new System.Drawing.Point(445, 73);
            this.btnRemoveRegisteredBook.Name = "btnRemoveRegisteredBook";
            this.btnRemoveRegisteredBook.Size = new System.Drawing.Size(161, 23);
            this.btnRemoveRegisteredBook.TabIndex = 5;
            this.btnRemoveRegisteredBook.Text = "Re&move Registered Book";
            this.btnRemoveRegisteredBook.UseVisualStyleBackColor = true;
            this.btnRemoveRegisteredBook.Click += new System.EventHandler(this.btnRemoveRegisteredBook_Click);
            // 
            // FrmManageRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.btnRemoveRegisteredBook);
            this.Controls.Add(this.lstBooksAndRegDate);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnRemoveRegistration);
            this.Controls.Add(this.lstRegistrations);
            this.Controls.Add(this.lblRegistrationManagingTool);
            this.Name = "FrmManageRegistration";
            this.Text = "Registration Manager";
            this.Load += new System.EventHandler(this.ManageRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegistrationManagingTool;
        private ListBox lstRegistrations;
        private Button btnRemoveRegistration;
        private ListBox lstCustomers;
        private ListBox lstBooksAndRegDate;
        private Button btnRemoveRegisteredBook;
    }
}