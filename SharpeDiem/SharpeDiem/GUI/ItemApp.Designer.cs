namespace SharpeDiem
{
    partial class ItemApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemApp));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.itemBtn = new System.Windows.Forms.Button();
            this.loanBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logoBtn = new System.Windows.Forms.Button();
            this.itemTabControl = new System.Windows.Forms.TabControl();
            this.mangageItemsTabPage = new System.Windows.Forms.TabPage();
            this.addErrorLbl = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.findItemBtn = new System.Windows.Forms.Button();
            this.findErrorLbl = new System.Windows.Forms.Label();
            this.itemNbrLbl = new System.Windows.Forms.Label();
            this.itemNbrTextBox = new System.Windows.Forms.TextBox();
            this.updateItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.cathegoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.showAllTabPage = new System.Windows.Forms.TabPage();
            this.showAllGridView = new System.Windows.Forms.DataGridView();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.showAllErrorLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.itemTabControl.SuspendLayout();
            this.mangageItemsTabPage.SuspendLayout();
            this.showAllTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.itemBtn);
            this.leftPanel.Controls.Add(this.loanBtn);
            this.leftPanel.Controls.Add(this.mainPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(170, 460);
            this.leftPanel.TabIndex = 0;
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
            this.loanBtn.Click += new System.EventHandler(this.loanBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.logoBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(170, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // logoBtn
            // 
            this.logoBtn.FlatAppearance.BorderSize = 0;
            this.logoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(-11, 12);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(162, 78);
            this.logoBtn.TabIndex = 1;
            this.logoBtn.UseVisualStyleBackColor = true;
            // 
            // itemTabControl
            // 
            this.itemTabControl.Controls.Add(this.mangageItemsTabPage);
            this.itemTabControl.Controls.Add(this.showAllTabPage);
            this.itemTabControl.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTabControl.Location = new System.Drawing.Point(167, 3);
            this.itemTabControl.Multiline = true;
            this.itemTabControl.Name = "itemTabControl";
            this.itemTabControl.SelectedIndex = 0;
            this.itemTabControl.Size = new System.Drawing.Size(737, 460);
            this.itemTabControl.TabIndex = 2;
            // 
            // mangageItemsTabPage
            // 
            this.mangageItemsTabPage.Controls.Add(this.addErrorLbl);
            this.mangageItemsTabPage.Controls.Add(this.headerLabel);
            this.mangageItemsTabPage.Controls.Add(this.removeItemBtn);
            this.mangageItemsTabPage.Controls.Add(this.findItemBtn);
            this.mangageItemsTabPage.Controls.Add(this.findErrorLbl);
            this.mangageItemsTabPage.Controls.Add(this.itemNbrLbl);
            this.mangageItemsTabPage.Controls.Add(this.itemNbrTextBox);
            this.mangageItemsTabPage.Controls.Add(this.updateItemBtn);
            this.mangageItemsTabPage.Controls.Add(this.addItemBtn);
            this.mangageItemsTabPage.Controls.Add(this.descriptionTextBox);
            this.mangageItemsTabPage.Controls.Add(this.colorLabel);
            this.mangageItemsTabPage.Controls.Add(this.conditionLabel);
            this.mangageItemsTabPage.Controls.Add(this.descriptionLabel);
            this.mangageItemsTabPage.Controls.Add(this.sizeLabel);
            this.mangageItemsTabPage.Controls.Add(this.conditionComboBox);
            this.mangageItemsTabPage.Controls.Add(this.colorComboBox);
            this.mangageItemsTabPage.Controls.Add(this.sizeComboBox);
            this.mangageItemsTabPage.Controls.Add(this.cathegoryLabel);
            this.mangageItemsTabPage.Controls.Add(this.categoryComboBox);
            this.mangageItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.mangageItemsTabPage.Name = "mangageItemsTabPage";
            this.mangageItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mangageItemsTabPage.Size = new System.Drawing.Size(729, 434);
            this.mangageItemsTabPage.TabIndex = 0;
            this.mangageItemsTabPage.Text = "Manage Items";
            this.mangageItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // addErrorLbl
            // 
            this.addErrorLbl.AutoSize = true;
            this.addErrorLbl.Location = new System.Drawing.Point(98, 336);
            this.addErrorLbl.Name = "addErrorLbl";
            this.addErrorLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.addErrorLbl.TabIndex = 19;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(203, 147);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(160, 20);
            this.headerLabel.TabIndex = 18;
            this.headerLabel.Text = "Add or Update item";
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Location = new System.Drawing.Point(114, 71);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(75, 23);
            this.removeItemBtn.TabIndex = 17;
            this.removeItemBtn.Text = "Remove";
            this.removeItemBtn.UseVisualStyleBackColor = true;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // findItemBtn
            // 
            this.findItemBtn.Location = new System.Drawing.Point(30, 71);
            this.findItemBtn.Name = "findItemBtn";
            this.findItemBtn.Size = new System.Drawing.Size(75, 23);
            this.findItemBtn.TabIndex = 16;
            this.findItemBtn.Text = "Find";
            this.findItemBtn.UseVisualStyleBackColor = true;
            this.findItemBtn.Click += new System.EventHandler(this.findItemBtn_Click);
            // 
            // findErrorLbl
            // 
            this.findErrorLbl.AutoSize = true;
            this.findErrorLbl.Location = new System.Drawing.Point(195, 52);
            this.findErrorLbl.Name = "findErrorLbl";
            this.findErrorLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.findErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.findErrorLbl.TabIndex = 15;
            // 
            // itemNbrLbl
            // 
            this.itemNbrLbl.AutoSize = true;
            this.itemNbrLbl.Location = new System.Drawing.Point(27, 27);
            this.itemNbrLbl.Name = "itemNbrLbl";
            this.itemNbrLbl.Size = new System.Drawing.Size(75, 13);
            this.itemNbrLbl.TabIndex = 14;
            this.itemNbrLbl.Text = "Item number:";
            // 
            // itemNbrTextBox
            // 
            this.itemNbrTextBox.Location = new System.Drawing.Point(30, 43);
            this.itemNbrTextBox.Name = "itemNbrTextBox";
            this.itemNbrTextBox.Size = new System.Drawing.Size(159, 22);
            this.itemNbrTextBox.TabIndex = 13;
            // 
            // updateItemBtn
            // 
            this.updateItemBtn.Location = new System.Drawing.Point(329, 331);
            this.updateItemBtn.Name = "updateItemBtn";
            this.updateItemBtn.Size = new System.Drawing.Size(75, 23);
            this.updateItemBtn.TabIndex = 12;
            this.updateItemBtn.Text = "Update";
            this.updateItemBtn.UseVisualStyleBackColor = true;
            this.updateItemBtn.Click += new System.EventHandler(this.updateItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(410, 331);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 11;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(326, 254);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(159, 71);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(95, 286);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(35, 13);
            this.colorLabel.TabIndex = 9;
            this.colorLabel.Text = "Color";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(323, 191);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(59, 13);
            this.conditionLabel.TabIndex = 8;
            this.conditionLabel.Text = "Condition";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(323, 240);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(95, 238);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "Size";
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Items.AddRange(new object[] {
            "new, never worn ",
            "worn, very good condition",
            "worn, good condition ",
            "worn, ok condition"});
            this.conditionComboBox.Location = new System.Drawing.Point(326, 207);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(159, 21);
            this.conditionComboBox.TabIndex = 4;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Black ",
            "White",
            "Grey",
            "Blue",
            "Green ",
            "Red ",
            "Pink",
            "Yellow ",
            "Orange"});
            this.colorComboBox.Location = new System.Drawing.Point(98, 302);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(159, 21);
            this.colorComboBox.TabIndex = 3;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.sizeComboBox.Location = new System.Drawing.Point(98, 254);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(159, 21);
            this.sizeComboBox.TabIndex = 2;
            // 
            // cathegoryLabel
            // 
            this.cathegoryLabel.AutoSize = true;
            this.cathegoryLabel.Location = new System.Drawing.Point(95, 189);
            this.cathegoryLabel.Name = "cathegoryLabel";
            this.cathegoryLabel.Size = new System.Drawing.Size(53, 13);
            this.cathegoryLabel.TabIndex = 1;
            this.cathegoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AllowDrop = true;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Dress",
            "Suit",
            "Tucksito",
            "Smoking"});
            this.categoryComboBox.Location = new System.Drawing.Point(98, 205);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(159, 21);
            this.categoryComboBox.TabIndex = 0;
            // 
            // showAllTabPage
            // 
            this.showAllTabPage.Controls.Add(this.showAllErrorLbl);
            this.showAllTabPage.Controls.Add(this.showAllGridView);
            this.showAllTabPage.Controls.Add(this.showAllBtn);
            this.showAllTabPage.Location = new System.Drawing.Point(4, 22);
            this.showAllTabPage.Name = "showAllTabPage";
            this.showAllTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.showAllTabPage.Size = new System.Drawing.Size(729, 434);
            this.showAllTabPage.TabIndex = 1;
            this.showAllTabPage.Text = "Show all";
            this.showAllTabPage.UseVisualStyleBackColor = true;
            // 
            // showAllGridView
            // 
            this.showAllGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.showAllGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showAllGridView.Location = new System.Drawing.Point(6, 35);
            this.showAllGridView.Name = "showAllGridView";
            this.showAllGridView.Size = new System.Drawing.Size(721, 393);
            this.showAllGridView.TabIndex = 5;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(28, 6);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(75, 23);
            this.showAllBtn.TabIndex = 4;
            this.showAllBtn.Text = "Show all";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // showAllErrorLbl
            // 
            this.showAllErrorLbl.AutoSize = true;
            this.showAllErrorLbl.Location = new System.Drawing.Point(110, 15);
            this.showAllErrorLbl.Name = "showAllErrorLbl";
            this.showAllErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.showAllErrorLbl.TabIndex = 6;
            // 
            // ItemApp
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 460);
            this.Controls.Add(this.itemTabControl);
            this.Controls.Add(this.leftPanel);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemApp";
            this.Text = "WindowsApp";
            this.leftPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.itemTabControl.ResumeLayout(false);
            this.mangageItemsTabPage.ResumeLayout(false);
            this.mangageItemsTabPage.PerformLayout();
            this.showAllTabPage.ResumeLayout(false);
            this.showAllTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button loanBtn;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.TabControl itemTabControl;
        private System.Windows.Forms.TabPage mangageItemsTabPage;
        private System.Windows.Forms.TabPage showAllTabPage;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label cathegoryLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Label itemNbrLbl;
        private System.Windows.Forms.TextBox itemNbrTextBox;
        private System.Windows.Forms.Button updateItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label findErrorLbl;
        private System.Windows.Forms.Button findItemBtn;
        private System.Windows.Forms.Label addErrorLbl;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.DataGridView showAllGridView;
        private System.Windows.Forms.Button logoBtn;
        private System.Windows.Forms.Label showAllErrorLbl;
    }
}