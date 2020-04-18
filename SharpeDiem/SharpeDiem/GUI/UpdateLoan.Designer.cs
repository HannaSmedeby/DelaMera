namespace SharpeDiem.GUI
{
    partial class UpdateLoan
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
            this.updateBorrowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.CompleteUpdateBtn = new System.Windows.Forms.Button();
            this.loanNbrLbl = new System.Windows.Forms.Label();
            this.borrowDateLbl = new System.Windows.Forms.Label();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.updateErrorMessageLbl = new System.Windows.Forms.Label();
            this.updateShowAvailableItems = new System.Windows.Forms.Button();
            this.chooseItemLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // updateBorrowDateTimePicker
            // 
            this.updateBorrowDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBorrowDateTimePicker.CustomFormat = "";
            this.updateBorrowDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBorrowDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateBorrowDateTimePicker.Location = new System.Drawing.Point(251, 32);
            this.updateBorrowDateTimePicker.Name = "updateBorrowDateTimePicker";
            this.updateBorrowDateTimePicker.Size = new System.Drawing.Size(119, 22);
            this.updateBorrowDateTimePicker.TabIndex = 0;
            // 
            // updateReturnDateTimePicker
            // 
            this.updateReturnDateTimePicker.CustomFormat = "";
            this.updateReturnDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateReturnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateReturnDateTimePicker.Location = new System.Drawing.Point(403, 33);
            this.updateReturnDateTimePicker.Name = "updateReturnDateTimePicker";
            this.updateReturnDateTimePicker.Size = new System.Drawing.Size(119, 22);
            this.updateReturnDateTimePicker.TabIndex = 1;
            // 
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.AllowUserToAddRows = false;
            this.dataGridViewUpdate.AllowUserToDeleteRows = false;
            this.dataGridViewUpdate.AllowUserToResizeColumns = false;
            this.dataGridViewUpdate.AllowUserToResizeRows = false;
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Location = new System.Drawing.Point(24, 113);
            this.dataGridViewUpdate.MultiSelect = false;
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.ReadOnly = true;
            this.dataGridViewUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpdate.Size = new System.Drawing.Size(514, 167);
            this.dataGridViewUpdate.TabIndex = 2;
            this.dataGridViewUpdate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cellClicked);
            // 
            // CompleteUpdateBtn
            // 
            this.CompleteUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteUpdateBtn.ForeColor = System.Drawing.Color.Green;
            this.CompleteUpdateBtn.Location = new System.Drawing.Point(447, 286);
            this.CompleteUpdateBtn.Name = "CompleteUpdateBtn";
            this.CompleteUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.CompleteUpdateBtn.TabIndex = 3;
            this.CompleteUpdateBtn.Text = "Update";
            this.CompleteUpdateBtn.UseVisualStyleBackColor = true;
            this.CompleteUpdateBtn.Click += new System.EventHandler(this.CompleteUpdateBtn_Click);
            // 
            // loanNbrLbl
            // 
            this.loanNbrLbl.AutoSize = true;
            this.loanNbrLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanNbrLbl.Location = new System.Drawing.Point(31, 39);
            this.loanNbrLbl.Name = "loanNbrLbl";
            this.loanNbrLbl.Size = new System.Drawing.Size(0, 13);
            this.loanNbrLbl.TabIndex = 4;
            // 
            // borrowDateLbl
            // 
            this.borrowDateLbl.AutoSize = true;
            this.borrowDateLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateLbl.ForeColor = System.Drawing.Color.Green;
            this.borrowDateLbl.Location = new System.Drawing.Point(248, 13);
            this.borrowDateLbl.Name = "borrowDateLbl";
            this.borrowDateLbl.Size = new System.Drawing.Size(71, 13);
            this.borrowDateLbl.TabIndex = 5;
            this.borrowDateLbl.Text = "Borrow date";
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLbl.ForeColor = System.Drawing.Color.Green;
            this.returnDateLbl.Location = new System.Drawing.Point(400, 13);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(68, 13);
            this.returnDateLbl.TabIndex = 6;
            this.returnDateLbl.Text = "Return date";
            // 
            // updateErrorMessageLbl
            // 
            this.updateErrorMessageLbl.AutoSize = true;
            this.updateErrorMessageLbl.ForeColor = System.Drawing.Color.Red;
            this.updateErrorMessageLbl.Location = new System.Drawing.Point(21, 291);
            this.updateErrorMessageLbl.Name = "updateErrorMessageLbl";
            this.updateErrorMessageLbl.Size = new System.Drawing.Size(0, 13);
            this.updateErrorMessageLbl.TabIndex = 7;
            // 
            // updateShowAvailableItems
            // 
            this.updateShowAvailableItems.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateShowAvailableItems.ForeColor = System.Drawing.Color.Green;
            this.updateShowAvailableItems.Location = new System.Drawing.Point(403, 59);
            this.updateShowAvailableItems.Name = "updateShowAvailableItems";
            this.updateShowAvailableItems.Size = new System.Drawing.Size(119, 23);
            this.updateShowAvailableItems.TabIndex = 8;
            this.updateShowAvailableItems.Text = "Show available items";
            this.updateShowAvailableItems.UseVisualStyleBackColor = true;
            this.updateShowAvailableItems.Click += new System.EventHandler(this.ShowAllAvailableItems_Click);
            // 
            // chooseItemLbl
            // 
            this.chooseItemLbl.AutoSize = true;
            this.chooseItemLbl.Location = new System.Drawing.Point(24, 94);
            this.chooseItemLbl.Name = "chooseItemLbl";
            this.chooseItemLbl.Size = new System.Drawing.Size(35, 13);
            this.chooseItemLbl.TabIndex = 9;
            this.chooseItemLbl.Text = "-- Choose an item --";
            // 
            // UpdateLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 335);
            this.Controls.Add(this.chooseItemLbl);
            this.Controls.Add(this.updateShowAvailableItems);
            this.Controls.Add(this.updateErrorMessageLbl);
            this.Controls.Add(this.returnDateLbl);
            this.Controls.Add(this.borrowDateLbl);
            this.Controls.Add(this.loanNbrLbl);
            this.Controls.Add(this.CompleteUpdateBtn);
            this.Controls.Add(this.dataGridViewUpdate);
            this.Controls.Add(this.updateReturnDateTimePicker);
            this.Controls.Add(this.updateBorrowDateTimePicker);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "UpdateLoan";
            this.Text = "UpdateLoan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker updateBorrowDateTimePicker;
        private System.Windows.Forms.DateTimePicker updateReturnDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridViewUpdate;
        private System.Windows.Forms.Button CompleteUpdateBtn;
        private System.Windows.Forms.Label loanNbrLbl;
        private System.Windows.Forms.Label borrowDateLbl;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.Label updateErrorMessageLbl;
        private System.Windows.Forms.Button updateShowAvailableItems;
        private System.Windows.Forms.Label chooseItemLbl;
    }
}