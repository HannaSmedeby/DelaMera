namespace SharpeDiem
{
    partial class LoanApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanApp));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.itemBtn = new System.Windows.Forms.Button();
            this.loanBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.createBtn = new System.Windows.Forms.Button();
            this.returnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.borrowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.borrowDateLbl = new System.Windows.Forms.Label();
            this.dataGridViewAvailableItems = new System.Windows.Forms.DataGridView();
            this.chooseItemLbl = new System.Windows.Forms.Label();
            this.showAllAvailableItemsBtn = new System.Windows.Forms.Button();
            this.createErrorMessageLbl = new System.Windows.Forms.Label();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.errorMessageLbl = new System.Windows.Forms.Label();
            this.searchReturnDateLbl = new System.Windows.Forms.Label();
            this.searchBorrowDateLbl = new System.Windows.Forms.Label();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findLoanNbrLbl = new System.Windows.Forms.Label();
            this.findExplanationLbl = new System.Windows.Forms.Label();
            this.itemNbrLbl = new System.Windows.Forms.Label();
            this.findItemNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchBorrowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.dataGridViewLoans = new System.Windows.Forms.DataGridView();
            this.updateLoanNbrTextBox = new System.Windows.Forms.TextBox();
            this.loanNbrLbl = new System.Windows.Forms.Label();
            this.removeLoanNbrTextBox = new System.Windows.Forms.TextBox();
            this.removeLoanNbrLbl = new System.Windows.Forms.Label();
            this.buttonPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.addTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableItems)).BeginInit();
            this.searchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.itemBtn);
            this.buttonPanel.Controls.Add(this.loanBtn);
            this.buttonPanel.Controls.Add(this.logoPanel);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(170, 460);
            this.buttonPanel.TabIndex = 0;
            // 
            // itemBtn
            // 
            this.itemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(102)))));
            this.itemBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBtn.ForeColor = System.Drawing.Color.DimGray;
            this.itemBtn.Location = new System.Drawing.Point(31, 134);
            this.itemBtn.Name = "itemBtn";
            this.itemBtn.Size = new System.Drawing.Size(97, 58);
            this.itemBtn.TabIndex = 3;
            this.itemBtn.Text = "Item";
            this.itemBtn.UseVisualStyleBackColor = false;
            this.itemBtn.Click += new System.EventHandler(this.itemBtn_Click);
            // 
            // loanBtn
            // 
            this.loanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(102)))));
            this.loanBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanBtn.ForeColor = System.Drawing.Color.DimGray;
            this.loanBtn.Location = new System.Drawing.Point(31, 213);
            this.loanBtn.Name = "loanBtn";
            this.loanBtn.Size = new System.Drawing.Size(97, 57);
            this.loanBtn.TabIndex = 2;
            this.loanBtn.Text = "Loan";
            this.loanBtn.UseVisualStyleBackColor = false;
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logoBtn);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(170, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // logoBtn
            // 
            this.logoBtn.FlatAppearance.BorderSize = 0;
            this.logoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(-9, 12);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(167, 73);
            this.logoBtn.TabIndex = 0;
            this.logoBtn.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.addTabPage);
            this.TabControl.Controls.Add(this.searchTabPage);
            this.TabControl.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(176, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(730, 458);
            this.TabControl.TabIndex = 2;
            // 
            // addTabPage
            // 
            this.addTabPage.Controls.Add(this.createBtn);
            this.addTabPage.Controls.Add(this.returnDateTimePicker);
            this.addTabPage.Controls.Add(this.borrowDateTimePicker);
            this.addTabPage.Controls.Add(this.returnDateLbl);
            this.addTabPage.Controls.Add(this.borrowDateLbl);
            this.addTabPage.Controls.Add(this.dataGridViewAvailableItems);
            this.addTabPage.Controls.Add(this.chooseItemLbl);
            this.addTabPage.Controls.Add(this.showAllAvailableItemsBtn);
            this.addTabPage.Controls.Add(this.createErrorMessageLbl);
            this.addTabPage.Location = new System.Drawing.Point(4, 22);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(722, 432);
            this.addTabPage.TabIndex = 0;
            this.addTabPage.Text = "Add";
            this.addTabPage.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(588, 366);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(88, 22);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create Loan";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.create_Click);
            // 
            // returnDateTimePicker
            // 
            this.returnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returnDateTimePicker.Location = new System.Drawing.Point(225, 30);
            this.returnDateTimePicker.Name = "returnDateTimePicker";
            this.returnDateTimePicker.Size = new System.Drawing.Size(156, 22);
            this.returnDateTimePicker.TabIndex = 4;
            // 
            // borrowDateTimePicker
            // 
            this.borrowDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.borrowDateTimePicker.Location = new System.Drawing.Point(32, 30);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(156, 22);
            this.borrowDateTimePicker.TabIndex = 3;
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Location = new System.Drawing.Point(222, 14);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(69, 13);
            this.returnDateLbl.TabIndex = 2;
            this.returnDateLbl.Text = "Return Date";
            // 
            // borrowDateLbl
            // 
            this.borrowDateLbl.AutoSize = true;
            this.borrowDateLbl.Location = new System.Drawing.Point(29, 14);
            this.borrowDateLbl.Name = "borrowDateLbl";
            this.borrowDateLbl.Size = new System.Drawing.Size(72, 13);
            this.borrowDateLbl.TabIndex = 1;
            this.borrowDateLbl.Text = "Borrow Date";
            // 
            // dataGridViewAvailableItems
            // 
            this.dataGridViewAvailableItems.AllowUserToAddRows = false;
            this.dataGridViewAvailableItems.AllowUserToDeleteRows = false;
            this.dataGridViewAvailableItems.AllowUserToResizeColumns = false;
            this.dataGridViewAvailableItems.AllowUserToResizeRows = false;
            this.dataGridViewAvailableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableItems.Location = new System.Drawing.Point(32, 87);
            this.dataGridViewAvailableItems.MultiSelect = false;
            this.dataGridViewAvailableItems.Name = "dataGridViewAvailableItems";
            this.dataGridViewAvailableItems.ReadOnly = true;
            this.dataGridViewAvailableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvailableItems.Size = new System.Drawing.Size(682, 269);
            this.dataGridViewAvailableItems.TabIndex = 5;
            this.dataGridViewAvailableItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cellClicked);
            // 
            // chooseItemLbl
            // 
            this.chooseItemLbl.AutoSize = true;
            this.chooseItemLbl.Location = new System.Drawing.Point(29, 71);
            this.chooseItemLbl.Name = "chooseItemLbl";
            this.chooseItemLbl.Size = new System.Drawing.Size(103, 13);
            this.chooseItemLbl.TabIndex = 7;
            this.chooseItemLbl.Text = "--Choose an item--";
            // 
            // showAllAvailableItemsBtn
            // 
            this.showAllAvailableItemsBtn.Location = new System.Drawing.Point(406, 30);
            this.showAllAvailableItemsBtn.Name = "showAllAvailableItemsBtn";
            this.showAllAvailableItemsBtn.Size = new System.Drawing.Size(139, 21);
            this.showAllAvailableItemsBtn.TabIndex = 3;
            this.showAllAvailableItemsBtn.Text = "Show all available items";
            this.showAllAvailableItemsBtn.UseVisualStyleBackColor = true;
            this.showAllAvailableItemsBtn.Click += new System.EventHandler(this.showAllAvailableItems_Click);
            // 
            // createErrorMessageLbl
            // 
            this.createErrorMessageLbl.AutoSize = true;
            this.createErrorMessageLbl.ForeColor = System.Drawing.Color.Green;
            this.createErrorMessageLbl.Location = new System.Drawing.Point(20, 371);
            this.createErrorMessageLbl.Name = "createErrorMessageLbl";
            this.createErrorMessageLbl.Size = new System.Drawing.Size(0, 13);
            this.createErrorMessageLbl.TabIndex = 8;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.errorMessageLbl);
            this.searchTabPage.Controls.Add(this.searchReturnDateLbl);
            this.searchTabPage.Controls.Add(this.searchBorrowDateLbl);
            this.searchTabPage.Controls.Add(this.showAllBtn);
            this.searchTabPage.Controls.Add(this.findBtn);
            this.searchTabPage.Controls.Add(this.findTextBox);
            this.searchTabPage.Controls.Add(this.findLoanNbrLbl);
            this.searchTabPage.Controls.Add(this.findExplanationLbl);
            this.searchTabPage.Controls.Add(this.itemNbrLbl);
            this.searchTabPage.Controls.Add(this.findItemNumberTextBox);
            this.searchTabPage.Controls.Add(this.searchBorrowDateTimePicker);
            this.searchTabPage.Controls.Add(this.searchReturnDateTimePicker);
            this.searchTabPage.Controls.Add(this.updateBtn);
            this.searchTabPage.Controls.Add(this.removeBtn);
            this.searchTabPage.Controls.Add(this.dataGridViewLoans);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(722, 432);
            this.searchTabPage.TabIndex = 1;
            this.searchTabPage.Text = "Search";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // errorMessageLbl
            // 
            this.errorMessageLbl.AutoSize = true;
            this.errorMessageLbl.Location = new System.Drawing.Point(6, 390);
            this.errorMessageLbl.Name = "errorMessageLbl";
            this.errorMessageLbl.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLbl.TabIndex = 8;
            // 
            // searchReturnDateLbl
            // 
            this.searchReturnDateLbl.AutoSize = true;
            this.searchReturnDateLbl.Location = new System.Drawing.Point(417, 35);
            this.searchReturnDateLbl.Name = "searchReturnDateLbl";
            this.searchReturnDateLbl.Size = new System.Drawing.Size(68, 13);
            this.searchReturnDateLbl.TabIndex = 7;
            this.searchReturnDateLbl.Text = "Return date";
            // 
            // searchBorrowDateLbl
            // 
            this.searchBorrowDateLbl.AutoSize = true;
            this.searchBorrowDateLbl.Location = new System.Drawing.Point(245, 35);
            this.searchBorrowDateLbl.Name = "searchBorrowDateLbl";
            this.searchBorrowDateLbl.Size = new System.Drawing.Size(71, 13);
            this.searchBorrowDateLbl.TabIndex = 6;
            this.searchBorrowDateLbl.Text = "Borrow date";
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(634, 84);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(82, 21);
            this.showAllBtn.TabIndex = 3;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllLoans_Click);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(634, 59);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(82, 21);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Search";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(9, 56);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(84, 22);
            this.findTextBox.TabIndex = 1;
            // 
            // findLoanNbrLbl
            // 
            this.findLoanNbrLbl.AutoSize = true;
            this.findLoanNbrLbl.Location = new System.Drawing.Point(6, 35);
            this.findLoanNbrLbl.Name = "findLoanNbrLbl";
            this.findLoanNbrLbl.Size = new System.Drawing.Size(75, 13);
            this.findLoanNbrLbl.TabIndex = 0;
            this.findLoanNbrLbl.Text = "Loan number";
            // 
            // findExplanationLbl
            // 
            this.findExplanationLbl.AutoSize = true;
            this.findExplanationLbl.Location = new System.Drawing.Point(91, 14);
            this.findExplanationLbl.Name = "findExplanationLbl";
            this.findExplanationLbl.Size = new System.Drawing.Size(372, 13);
            this.findExplanationLbl.TabIndex = 0;
            this.findExplanationLbl.Text = "--Search by loan number, item number or dates to show related loans--";
            // 
            // itemNbrLbl
            // 
            this.itemNbrLbl.AutoSize = true;
            this.itemNbrLbl.Location = new System.Drawing.Point(114, 35);
            this.itemNbrLbl.Name = "itemNbrLbl";
            this.itemNbrLbl.Size = new System.Drawing.Size(72, 13);
            this.itemNbrLbl.TabIndex = 0;
            this.itemNbrLbl.Text = "Item number";
            // 
            // findItemNumberTextBox
            // 
            this.findItemNumberTextBox.Location = new System.Drawing.Point(114, 56);
            this.findItemNumberTextBox.Name = "findItemNumberTextBox";
            this.findItemNumberTextBox.Size = new System.Drawing.Size(84, 22);
            this.findItemNumberTextBox.TabIndex = 1;
            // 
            // searchBorrowDateTimePicker
            // 
            this.searchBorrowDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchBorrowDateTimePicker.Location = new System.Drawing.Point(248, 56);
            this.searchBorrowDateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.searchBorrowDateTimePicker.Name = "searchBorrowDateTimePicker";
            this.searchBorrowDateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.searchBorrowDateTimePicker.TabIndex = 4;
            this.searchBorrowDateTimePicker.ValueChanged += new System.EventHandler(this.searchBorrowDateTimePicker_ValueChanged);
            // 
            // searchReturnDateTimePicker
            // 
            this.searchReturnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchReturnDateTimePicker.Location = new System.Drawing.Point(420, 56);
            this.searchReturnDateTimePicker.Name = "searchReturnDateTimePicker";
            this.searchReturnDateTimePicker.Size = new System.Drawing.Size(140, 22);
            this.searchReturnDateTimePicker.TabIndex = 5;
            this.searchReturnDateTimePicker.ValueChanged += new System.EventHandler(this.searchReturnDateTimePicker_ValueChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(634, 137);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 21);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(634, 164);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(85, 23);
            this.removeBtn.TabIndex = 0;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // dataGridViewLoans
            // 
            this.dataGridViewLoans.AllowUserToAddRows = false;
            this.dataGridViewLoans.AllowUserToDeleteRows = false;
            this.dataGridViewLoans.AllowUserToResizeColumns = false;
            this.dataGridViewLoans.AllowUserToResizeRows = false;
            this.dataGridViewLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoans.Location = new System.Drawing.Point(9, 84);
            this.dataGridViewLoans.Name = "dataGridViewLoans";
            this.dataGridViewLoans.ReadOnly = true;
            this.dataGridViewLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoans.Size = new System.Drawing.Size(622, 285);
            this.dataGridViewLoans.TabIndex = 5;
            this.dataGridViewLoans.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cellClicked);
            // 
            // updateLoanNbrTextBox
            // 
            this.updateLoanNbrTextBox.Location = new System.Drawing.Point(12, 44);
            this.updateLoanNbrTextBox.Name = "updateLoanNbrTextBox";
            this.updateLoanNbrTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateLoanNbrTextBox.TabIndex = 1;
            // 
            // loanNbrLbl
            // 
            this.loanNbrLbl.AutoSize = true;
            this.loanNbrLbl.Location = new System.Drawing.Point(9, 28);
            this.loanNbrLbl.Name = "loanNbrLbl";
            this.loanNbrLbl.Size = new System.Drawing.Size(76, 13);
            this.loanNbrLbl.TabIndex = 0;
            this.loanNbrLbl.Text = "Loan Number";
            // 
            // removeLoanNbrTextBox
            // 
            this.removeLoanNbrTextBox.Location = new System.Drawing.Point(0, 0);
            this.removeLoanNbrTextBox.Name = "removeLoanNbrTextBox";
            this.removeLoanNbrTextBox.Size = new System.Drawing.Size(100, 20);
            this.removeLoanNbrTextBox.TabIndex = 0;
            // 
            // removeLoanNbrLbl
            // 
            this.removeLoanNbrLbl.Location = new System.Drawing.Point(0, 0);
            this.removeLoanNbrLbl.Name = "removeLoanNbrLbl";
            this.removeLoanNbrLbl.Size = new System.Drawing.Size(100, 23);
            this.removeLoanNbrLbl.TabIndex = 0;
            // 
            // LoanApp
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 460);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.buttonPanel);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoanApp";
            this.Text = "WindowsApp";
            this.buttonPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.addTabPage.ResumeLayout(false);
            this.addTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableItems)).EndInit();
            this.searchTabPage.ResumeLayout(false);
            this.searchTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.Button loanBtn;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.Button logoBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button showAllAvailableItemsBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label chooseItemLbl;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.Label borrowDateLbl;
        private System.Windows.Forms.Label itemNbrLbl;
        private System.Windows.Forms.Label findExplanationLbl;
        private System.Windows.Forms.Label findLoanNbrLbl;
        private System.Windows.Forms.Label loanNbrLbl;
        private System.Windows.Forms.Label removeLoanNbrLbl;
        private System.Windows.Forms.Label searchBorrowDateLbl;
        private System.Windows.Forms.Label searchReturnDateLbl;
        private System.Windows.Forms.Label errorMessageLbl;
        private System.Windows.Forms.Label createErrorMessageLbl;
        private System.Windows.Forms.TextBox updateLoanNbrTextBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.TextBox findItemNumberTextBox;
        private System.Windows.Forms.TextBox removeLoanNbrTextBox;
        private System.Windows.Forms.DateTimePicker returnDateTimePicker;
        private System.Windows.Forms.DateTimePicker borrowDateTimePicker;
        private System.Windows.Forms.DateTimePicker searchReturnDateTimePicker;
        private System.Windows.Forms.DateTimePicker searchBorrowDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewAvailableItems;
        private System.Windows.Forms.DataGridView dataGridViewLoans;

    }
}