namespace EventHandlerWebA2
{
    partial class WebService2_Form
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
            this.buttonGetItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGetLoan = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetItem
            // 
            this.buttonGetItem.Location = new System.Drawing.Point(33, 62);
            this.buttonGetItem.Name = "buttonGetItem";
            this.buttonGetItem.Size = new System.Drawing.Size(119, 23);
            this.buttonGetItem.TabIndex = 0;
            this.buttonGetItem.Text = "Get Item";
            this.buttonGetItem.UseVisualStyleBackColor = true;
            this.buttonGetItem.Click += new System.EventHandler(this.buttonGetItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 121);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonGetLoan
            // 
            this.buttonGetLoan.Location = new System.Drawing.Point(190, 62);
            this.buttonGetLoan.Name = "buttonGetLoan";
            this.buttonGetLoan.Size = new System.Drawing.Size(119, 23);
            this.buttonGetLoan.TabIndex = 2;
            this.buttonGetLoan.Text = "Get Loan";
            this.buttonGetLoan.UseVisualStyleBackColor = true;
            this.buttonGetLoan.Click += new System.EventHandler(this.buttonGetLoan_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(30, 30);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(168, 13);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "Please choose a table to populate";
            // 
            // WebService2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 320);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonGetLoan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGetItem);
            this.Name = "WebService2_Form";
            this.Text = "Web Service Assignment 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGetLoan;
        private System.Windows.Forms.Label labelText;
    }
}

