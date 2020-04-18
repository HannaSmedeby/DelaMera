namespace SharpeDiem
{
    partial class WindowsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsApp));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.itemBtn = new System.Windows.Forms.Button();
            this.loanBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logoBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.leftPanel.Size = new System.Drawing.Size(164, 460);
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
            this.itemBtn.Click += new System.EventHandler(this.itemBtn_Click);
            // 
            // loanBtn
            // 
            this.loanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(212)))), ((int)(((byte)(102)))));
            this.loanBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanBtn.ForeColor = System.Drawing.Color.DimGray;
            this.loanBtn.Location = new System.Drawing.Point(31, 210);
            this.loanBtn.Name = "loanBtn";
            this.loanBtn.Size = new System.Drawing.Size(97, 58);
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
            this.mainPanel.Size = new System.Drawing.Size(164, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // logoBtn
            // 
            this.logoBtn.FlatAppearance.BorderSize = 0;
            this.logoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(-9, 12);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(170, 73);
            this.logoBtn.TabIndex = 0;
            this.logoBtn.UseVisualStyleBackColor = true;
            // 
            // WindowsApp
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 460);
            this.Controls.Add(this.leftPanel);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WindowsApp";
            this.Text = "WindowsApp";
            this.leftPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button loanBtn;
        private System.Windows.Forms.Button itemBtn;
        private System.Windows.Forms.Button logoBtn;
    }
}