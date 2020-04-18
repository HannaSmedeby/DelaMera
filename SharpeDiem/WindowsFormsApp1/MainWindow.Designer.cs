using System.Data;

namespace Uppgift2
{
    partial class MainWindow
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
            this.tablesBox = new System.Windows.Forms.ComboBox();
            this.ColumnNamesBtn = new System.Windows.Forms.Button();
            this.NbrOfRowsBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.table = new System.Data.DataTable();
            this.panel1 = new System.Windows.Forms.Panel();
            this.responseLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablesBox
            // 
            this.tablesBox.FormattingEnabled = true;
            this.tablesBox.Location = new System.Drawing.Point(56, 48);
            this.tablesBox.Name = "tablesBox";
            this.tablesBox.Size = new System.Drawing.Size(122, 21);
            this.tablesBox.TabIndex = 4;
            // 
            // ColumnNamesBtn
            // 
            this.ColumnNamesBtn.Location = new System.Drawing.Point(207, 48);
            this.ColumnNamesBtn.Name = "ColumnNamesBtn";
            this.ColumnNamesBtn.Size = new System.Drawing.Size(143, 23);
            this.ColumnNamesBtn.TabIndex = 5;
            this.ColumnNamesBtn.Text = "Display Column Names";
            this.ColumnNamesBtn.UseVisualStyleBackColor = true;
            this.ColumnNamesBtn.Click += new System.EventHandler(this.ColumnNamesBtn_Click);
            // 
            // NbrOfRowsBtn
            // 
            this.NbrOfRowsBtn.Location = new System.Drawing.Point(369, 48);
            this.NbrOfRowsBtn.Name = "NbrOfRowsBtn";
            this.NbrOfRowsBtn.Size = new System.Drawing.Size(170, 23);
            this.NbrOfRowsBtn.TabIndex = 6;
            this.NbrOfRowsBtn.Text = "Display Number Of Rows";
            this.NbrOfRowsBtn.UseVisualStyleBackColor = true;
            this.NbrOfRowsBtn.Click += new System.EventHandler(this.NbrOfRowsBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(56, 102);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(629, 298);
            this.dataGridView.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.responseLbl);
            this.panel1.Location = new System.Drawing.Point(545, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 84);
            this.panel1.TabIndex = 9;
            // 
            // responseLbl
            // 
            this.responseLbl.AutoSize = true;
            this.responseLbl.Location = new System.Drawing.Point(22, 36);
            this.responseLbl.Name = "responseLbl";
            this.responseLbl.Size = new System.Drawing.Size(0, 13);
            this.responseLbl.TabIndex = 0;
            this.responseLbl.ForeColor = System.Drawing.Color.Red;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.NbrOfRowsBtn);
            this.Controls.Add(this.ColumnNamesBtn);
            this.Controls.Add(this.tablesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox tablesBox;
        private System.Windows.Forms.Button ColumnNamesBtn;
        private System.Windows.Forms.Button NbrOfRowsBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private DataTable table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label responseLbl;
    }
}