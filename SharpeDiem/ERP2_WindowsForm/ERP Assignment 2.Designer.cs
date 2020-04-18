namespace ERP2_WindowsForm
{
    partial class ERP2_Form
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.empTabPage = new System.Windows.Forms.TabPage();
            this.empPanel = new System.Windows.Forms.Panel();
            this.empMetaTableLbl = new System.Windows.Forms.Label();
            this.empTableLbl = new System.Windows.Forms.Label();
            this.empMetaLbl = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.getEmpMetaBtn = new System.Windows.Forms.Button();
            this.getEmpMetaSelections = new System.Windows.Forms.ComboBox();
            this.empTablesSelection = new System.Windows.Forms.ComboBox();
            this.getDataBtn = new System.Windows.Forms.Button();
            this.getDataSelections = new System.Windows.Forms.ComboBox();
            this.empMetaView = new System.Windows.Forms.DataGridView();
            this.empContentView = new System.Windows.Forms.DataGridView();
            this.metaTabPage = new System.Windows.Forms.TabPage();
            this.metaPanel = new System.Windows.Forms.Panel();
            this.metaDataBtn = new System.Windows.Forms.Button();
            this.metaDataTableLbl = new System.Windows.Forms.Label();
            this.metaDataLbl = new System.Windows.Forms.Label();
            this.metaDataSelections = new System.Windows.Forms.ComboBox();
            this.metaDataTable = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.empTabPage.SuspendLayout();
            this.empPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empMetaView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empContentView)).BeginInit();
            this.metaTabPage.SuspendLayout();
            this.metaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metaDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.empTabPage);
            this.tabControl.Controls.Add(this.metaTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1048, 547);
            this.tabControl.TabIndex = 1;
            // 
            // empTabPage
            // 
            this.empTabPage.Controls.Add(this.empPanel);
            this.empTabPage.Location = new System.Drawing.Point(4, 22);
            this.empTabPage.Name = "empTabPage";
            this.empTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.empTabPage.Size = new System.Drawing.Size(1040, 521);
            this.empTabPage.TabIndex = 0;
            this.empTabPage.Text = "Employee Data";
            this.empTabPage.UseVisualStyleBackColor = true;
            // 
            // empPanel
            // 
            this.empPanel.Controls.Add(this.empMetaTableLbl);
            this.empPanel.Controls.Add(this.empTableLbl);
            this.empPanel.Controls.Add(this.empMetaLbl);
            this.empPanel.Controls.Add(this.dataLbl);
            this.empPanel.Controls.Add(this.getEmpMetaBtn);
            this.empPanel.Controls.Add(this.getEmpMetaSelections);
            this.empPanel.Controls.Add(this.empTablesSelection);
            this.empPanel.Controls.Add(this.getDataBtn);
            this.empPanel.Controls.Add(this.getDataSelections);
            this.empPanel.Controls.Add(this.empMetaView);
            this.empPanel.Controls.Add(this.empContentView);
            this.empPanel.Location = new System.Drawing.Point(0, 0);
            this.empPanel.Name = "empPanel";
            this.empPanel.Size = new System.Drawing.Size(1044, 518);
            this.empPanel.TabIndex = 0;
            // 
            // empMetaTableLbl
            // 
            this.empMetaTableLbl.AutoSize = true;
            this.empMetaTableLbl.Location = new System.Drawing.Point(7, 350);
            this.empMetaTableLbl.Name = "empMetaTableLbl";
            this.empMetaTableLbl.Size = new System.Drawing.Size(126, 13);
            this.empMetaTableLbl.TabIndex = 10;
            this.empMetaTableLbl.Text = "Employee metadata table";
            // 
            // empTableLbl
            // 
            this.empTableLbl.AutoSize = true;
            this.empTableLbl.Location = new System.Drawing.Point(4, 7);
            this.empTableLbl.Name = "empTableLbl";
            this.empTableLbl.Size = new System.Drawing.Size(79, 13);
            this.empTableLbl.TabIndex = 9;
            this.empTableLbl.Text = "Employee table";
            // 
            // empMetaLbl
            // 
            this.empMetaLbl.AutoSize = true;
            this.empMetaLbl.Location = new System.Drawing.Point(767, 365);
            this.empMetaLbl.Name = "empMetaLbl";
            this.empMetaLbl.Size = new System.Drawing.Size(181, 26);
            this.empMetaLbl.TabIndex = 8;
            this.empMetaLbl.Text = "Select table and metadata to display \n a table content\'s and it\'s metadata";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(767, 31);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(108, 13);
            this.dataLbl.TabIndex = 7;
            this.dataLbl.Text = "Select data to display";
            // 
            // getEmpMetaBtn
            // 
            this.getEmpMetaBtn.Location = new System.Drawing.Point(935, 451);
            this.getEmpMetaBtn.Name = "getEmpMetaBtn";
            this.getEmpMetaBtn.Size = new System.Drawing.Size(75, 23);
            this.getEmpMetaBtn.TabIndex = 6;
            this.getEmpMetaBtn.Text = "Get table and metadata";
            this.getEmpMetaBtn.UseVisualStyleBackColor = true;
            this.getEmpMetaBtn.Click += new System.EventHandler(this.getEmpMetaBtn_Click);
            // 
            // getEmpMetaSelections
            // 
            this.getEmpMetaSelections.FormattingEnabled = true;
            this.getEmpMetaSelections.Items.AddRange(new object[] {
            "All keys",
            "All indexes",
            "All constraints"});
            this.getEmpMetaSelections.Location = new System.Drawing.Point(770, 424);
            this.getEmpMetaSelections.Name = "getEmpMetaSelections";
            this.getEmpMetaSelections.Size = new System.Drawing.Size(240, 21);
            this.getEmpMetaSelections.TabIndex = 5;
            // 
            // empTablesSelection
            // 
            this.empTablesSelection.FormattingEnabled = true;
            this.empTablesSelection.Location = new System.Drawing.Point(770, 397);
            this.empTablesSelection.Name = "empTablesSelection";
            this.empTablesSelection.Size = new System.Drawing.Size(240, 21);
            this.empTablesSelection.TabIndex = 4;
            // 
            // getDataBtn
            // 
            this.getDataBtn.Location = new System.Drawing.Point(935, 74);
            this.getDataBtn.Name = "getDataBtn";
            this.getDataBtn.Size = new System.Drawing.Size(75, 23);
            this.getDataBtn.TabIndex = 3;
            this.getDataBtn.Text = "Display data";
            this.getDataBtn.UseVisualStyleBackColor = true;
            this.getDataBtn.Click += new System.EventHandler(this.getDataBtn_Click);
            // 
            // getDataSelections
            // 
            this.getDataSelections.FormattingEnabled = true;
            this.getDataSelections.Items.AddRange(new object[] {
            "Employees and their relatives",
            "Sick employees 2004",
            "Most sick employee"});
            this.getDataSelections.Location = new System.Drawing.Point(770, 47);
            this.getDataSelections.Name = "getDataSelections";
            this.getDataSelections.Size = new System.Drawing.Size(240, 21);
            this.getDataSelections.TabIndex = 2;
            // 
            // empMetaView
            // 
            this.empMetaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empMetaView.Location = new System.Drawing.Point(3, 365);
            this.empMetaView.Name = "empMetaView";
            this.empMetaView.Size = new System.Drawing.Size(727, 150);
            this.empMetaView.TabIndex = 1;
            // 
            // empContentView
            // 
            this.empContentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empContentView.Location = new System.Drawing.Point(3, 22);
            this.empContentView.Name = "empContentView";
            this.empContentView.Size = new System.Drawing.Size(727, 321);
            this.empContentView.TabIndex = 0;
            // 
            // metaTabPage
            // 
            this.metaTabPage.Controls.Add(this.metaPanel);
            this.metaTabPage.Location = new System.Drawing.Point(4, 22);
            this.metaTabPage.Name = "metaTabPage";
            this.metaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.metaTabPage.Size = new System.Drawing.Size(1040, 521);
            this.metaTabPage.TabIndex = 1;
            this.metaTabPage.Text = "Metadata";
            this.metaTabPage.UseVisualStyleBackColor = true;
            // 
            // metaPanel
            // 
            this.metaPanel.Controls.Add(this.metaDataBtn);
            this.metaPanel.Controls.Add(this.metaDataTableLbl);
            this.metaPanel.Controls.Add(this.metaDataLbl);
            this.metaPanel.Controls.Add(this.metaDataSelections);
            this.metaPanel.Controls.Add(this.metaDataTable);
            this.metaPanel.Location = new System.Drawing.Point(0, 0);
            this.metaPanel.Name = "metaPanel";
            this.metaPanel.Size = new System.Drawing.Size(1037, 561);
            this.metaPanel.TabIndex = 0;
            // 
            // metaDataBtn
            // 
            this.metaDataBtn.Location = new System.Drawing.Point(927, 76);
            this.metaDataBtn.Name = "metaDataBtn";
            this.metaDataBtn.Size = new System.Drawing.Size(103, 23);
            this.metaDataBtn.TabIndex = 4;
            this.metaDataBtn.Text = "Display metadata";
            this.metaDataBtn.UseVisualStyleBackColor = true;
            this.metaDataBtn.Click += new System.EventHandler(this.metaDataBtn_Click);
            // 
            // metaDataTableLbl
            // 
            this.metaDataTableLbl.AutoSize = true;
            this.metaDataTableLbl.Location = new System.Drawing.Point(9, 4);
            this.metaDataTableLbl.Name = "metaDataTableLbl";
            this.metaDataTableLbl.Size = new System.Drawing.Size(78, 13);
            this.metaDataTableLbl.TabIndex = 3;
            this.metaDataTableLbl.Text = "Metadata table";
            // 
            // metaDataLbl
            // 
            this.metaDataLbl.AutoSize = true;
            this.metaDataLbl.Location = new System.Drawing.Point(875, 20);
            this.metaDataLbl.Name = "metaDataLbl";
            this.metaDataLbl.Size = new System.Drawing.Size(124, 26);
            this.metaDataLbl.TabIndex = 2;
            this.metaDataLbl.Text = "Choose which metadata \n to display";
            // 
            // metaDataSelections
            // 
            this.metaDataSelections.FormattingEnabled = true;
            this.metaDataSelections.Items.AddRange(new object[] {
            "All keys",
            "All indexes",
            "All constraints",
            "All table names 1",
            "All table names 2",
            "All employee columns 1",
            "All employee columns 2"});
            this.metaDataSelections.Location = new System.Drawing.Point(877, 49);
            this.metaDataSelections.Name = "metaDataSelections";
            this.metaDataSelections.Size = new System.Drawing.Size(153, 21);
            this.metaDataSelections.TabIndex = 1;
            // 
            // metaDataTable
            // 
            this.metaDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metaDataTable.Location = new System.Drawing.Point(9, 20);
            this.metaDataTable.Name = "metaDataTable";
            this.metaDataTable.Size = new System.Drawing.Size(862, 489);
            this.metaDataTable.TabIndex = 0;
            // 
            // ERP2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 545);
            this.Controls.Add(this.tabControl);
            this.Name = "ERP2_Form";
            this.Text = "ERP Assignment 2";
            this.tabControl.ResumeLayout(false);
            this.empTabPage.ResumeLayout(false);
            this.empPanel.ResumeLayout(false);
            this.empPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empMetaView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empContentView)).EndInit();
            this.metaTabPage.ResumeLayout(false);
            this.metaPanel.ResumeLayout(false);
            this.metaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metaDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage empTabPage;
        private System.Windows.Forms.Panel empPanel;
        private System.Windows.Forms.Label empMetaLbl;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Button getEmpMetaBtn;
        private System.Windows.Forms.ComboBox getEmpMetaSelections;
        private System.Windows.Forms.ComboBox empTablesSelection;
        private System.Windows.Forms.Button getDataBtn;
        private System.Windows.Forms.ComboBox getDataSelections;
        private System.Windows.Forms.DataGridView empMetaView;
        private System.Windows.Forms.DataGridView empContentView;
        private System.Windows.Forms.TabPage metaTabPage;
        private System.Windows.Forms.Panel metaPanel;
        private System.Windows.Forms.Label empMetaTableLbl;
        private System.Windows.Forms.Label empTableLbl;
        private System.Windows.Forms.Button metaDataBtn;
        private System.Windows.Forms.Label metaDataTableLbl;
        private System.Windows.Forms.Label metaDataLbl;
        private System.Windows.Forms.ComboBox metaDataSelections;
        private System.Windows.Forms.DataGridView metaDataTable;
    }
}

