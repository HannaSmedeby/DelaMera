namespace ERP1_WindowsForm
{
    partial class ERP1_Form
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
            this.showAllGridView = new System.Windows.Forms.DataGridView();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.phoneNbrLbl = new System.Windows.Forms.Label();
            this.employeeTableLbl = new System.Windows.Forms.Label();
            this.phoneNbrTextBox = new System.Windows.Forms.TextBox();
            this.createEmpLabel = new System.Windows.Forms.Label();
            this.removeAndFindLbl = new System.Windows.Forms.Label();
            this.removeFindIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showAllLbl = new System.Windows.Forms.Label();
            this.createResponseLbl = new System.Windows.Forms.Label();
            this.findRemoveResponseLbl = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showAllGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllGridView
            // 
            this.showAllGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showAllGridView.Location = new System.Drawing.Point(319, 195);
            this.showAllGridView.Name = "showAllGridView";
            this.showAllGridView.Size = new System.Drawing.Size(571, 315);
            this.showAllGridView.TabIndex = 0;
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(319, 166);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(75, 23);
            this.showAllBtn.TabIndex = 1;
            this.showAllBtn.Text = "Show all";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(122, 312);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(122, 341);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(459, 53);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(97, 98);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(97, 240);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.Location = new System.Drawing.Point(97, 204);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTitleTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(97, 169);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 134);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(77, 101);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(19, 13);
            this.idLbl.TabIndex = 11;
            this.idLbl.Text = "Id:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(58, 137);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 12;
            this.nameLbl.Text = "Name:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(48, 243);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(48, 13);
            this.addressLbl.TabIndex = 13;
            this.addressLbl.Text = "Address:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(50, 207);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(46, 13);
            this.titleLbl.TabIndex = 14;
            this.titleLbl.Text = "Job title:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(37, 171);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(59, 13);
            this.lastNameLbl.TabIndex = 15;
            this.lastNameLbl.Text = "Last name:";
            // 
            // phoneNbrLbl
            // 
            this.phoneNbrLbl.AutoSize = true;
            this.phoneNbrLbl.Location = new System.Drawing.Point(17, 278);
            this.phoneNbrLbl.Name = "phoneNbrLbl";
            this.phoneNbrLbl.Size = new System.Drawing.Size(79, 13);
            this.phoneNbrLbl.TabIndex = 16;
            this.phoneNbrLbl.Text = "Phone number:";
            // 
            // employeeTableLbl
            // 
            this.employeeTableLbl.AutoSize = true;
            this.employeeTableLbl.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeTableLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.employeeTableLbl.Location = new System.Drawing.Point(12, 9);
            this.employeeTableLbl.Name = "employeeTableLbl";
            this.employeeTableLbl.Size = new System.Drawing.Size(265, 47);
            this.employeeTableLbl.TabIndex = 17;
            this.employeeTableLbl.Text = "Employee Table";
            // 
            // phoneNbrTextBox
            // 
            this.phoneNbrTextBox.Location = new System.Drawing.Point(97, 275);
            this.phoneNbrTextBox.Name = "phoneNbrTextBox";
            this.phoneNbrTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNbrTextBox.TabIndex = 18;
            // 
            // createEmpLabel
            // 
            this.createEmpLabel.AutoSize = true;
            this.createEmpLabel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEmpLabel.Location = new System.Drawing.Point(12, 75);
            this.createEmpLabel.Name = "createEmpLabel";
            this.createEmpLabel.Size = new System.Drawing.Size(175, 17);
            this.createEmpLabel.TabIndex = 19;
            this.createEmpLabel.Text = "Create and update Employee:";
            // 
            // removeAndFindLbl
            // 
            this.removeAndFindLbl.AutoSize = true;
            this.removeAndFindLbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAndFindLbl.Location = new System.Drawing.Point(316, 33);
            this.removeAndFindLbl.Name = "removeAndFindLbl";
            this.removeAndFindLbl.Size = new System.Drawing.Size(114, 17);
            this.removeAndFindLbl.TabIndex = 20;
            this.removeAndFindLbl.Text = "Remove Employee";
            // 
            // removeFindIdTextBox
            // 
            this.removeFindIdTextBox.Location = new System.Drawing.Point(353, 53);
            this.removeFindIdTextBox.Name = "removeFindIdTextBox";
            this.removeFindIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.removeFindIdTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id:";
            // 
            // showAllLbl
            // 
            this.showAllLbl.AutoSize = true;
            this.showAllLbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllLbl.Location = new System.Drawing.Point(316, 137);
            this.showAllLbl.Name = "showAllLbl";
            this.showAllLbl.Size = new System.Drawing.Size(149, 17);
            this.showAllLbl.TabIndex = 23;
            this.showAllLbl.Text = "Show the Employee table";
            // 
            // createResponseLbl
            // 
            this.createResponseLbl.AutoSize = true;
            this.createResponseLbl.Location = new System.Drawing.Point(17, 398);
            this.createResponseLbl.Name = "createResponseLbl";
            this.createResponseLbl.Size = new System.Drawing.Size(0, 13);
            this.createResponseLbl.TabIndex = 24;
            // 
            // findRemoveResponseLbl
            // 
            this.findRemoveResponseLbl.AutoSize = true;
            this.findRemoveResponseLbl.Location = new System.Drawing.Point(316, 80);
            this.findRemoveResponseLbl.Name = "findRemoveResponseLbl";
            this.findRemoveResponseLbl.Size = new System.Drawing.Size(0, 13);
            this.findRemoveResponseLbl.TabIndex = 25;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(122, 370);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 26;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ERP2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.findRemoveResponseLbl);
            this.Controls.Add(this.createResponseLbl);
            this.Controls.Add(this.showAllLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeFindIdTextBox);
            this.Controls.Add(this.removeAndFindLbl);
            this.Controls.Add(this.createEmpLabel);
            this.Controls.Add(this.phoneNbrTextBox);
            this.Controls.Add(this.employeeTableLbl);
            this.Controls.Add(this.phoneNbrLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.showAllGridView);
            this.Name = "ERP2_Form";
            this.Text = "ERP2_Form";
            ((System.ComponentModel.ISupportInitialize)(this.showAllGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showAllGridView;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label phoneNbrLbl;
        private System.Windows.Forms.Label employeeTableLbl;
        private System.Windows.Forms.TextBox phoneNbrTextBox;
        private System.Windows.Forms.Label createEmpLabel;
        private System.Windows.Forms.Label removeAndFindLbl;
        private System.Windows.Forms.TextBox removeFindIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showAllLbl;
        private System.Windows.Forms.Label createResponseLbl;
        private System.Windows.Forms.Label findRemoveResponseLbl;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button button1;
    }
}

