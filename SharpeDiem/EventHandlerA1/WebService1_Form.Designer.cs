namespace EventHandlerA1
{
    partial class WebService1_Form
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
            this.getDocumentBtn = new System.Windows.Forms.Button();
            this.textBoxDocument = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelDocument = new System.Windows.Forms.Label();
            this.labelOutputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getDocumentBtn
            // 
            this.getDocumentBtn.Location = new System.Drawing.Point(301, 42);
            this.getDocumentBtn.Name = "getDocumentBtn";
            this.getDocumentBtn.Size = new System.Drawing.Size(125, 23);
            this.getDocumentBtn.TabIndex = 0;
            this.getDocumentBtn.Text = "Get Document";
            this.getDocumentBtn.UseVisualStyleBackColor = true;
            this.getDocumentBtn.Click += new System.EventHandler(this.getDocumentBtn_Click);
            // 
            // textBoxDocument
            // 
            this.textBoxDocument.Location = new System.Drawing.Point(29, 42);
            this.textBoxDocument.Name = "textBoxDocument";
            this.textBoxDocument.Size = new System.Drawing.Size(242, 20);
            this.textBoxDocument.TabIndex = 1;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(26, 83);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(42, 13);
            this.labelOutput.TabIndex = 2;
            this.labelOutput.Text = "Output:";
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Location = new System.Drawing.Point(26, 26);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(151, 13);
            this.labelDocument.TabIndex = 3;
            this.labelDocument.Text = "Please fill out document name:";
            // 
            // labelOutputText
            // 
            this.labelOutputText.AutoSize = true;
            this.labelOutputText.Location = new System.Drawing.Point(26, 108);
            this.labelOutputText.Name = "labelOutputText";
            this.labelOutputText.Size = new System.Drawing.Size(0, 13);
            this.labelOutputText.TabIndex = 4;
            // 
            // WebService1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 164);
            this.Controls.Add(this.labelOutputText);
            this.Controls.Add(this.labelDocument);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxDocument);
            this.Controls.Add(this.getDocumentBtn);
            this.Name = "WebService1_Form";
            this.Text = "Web Service Assignment 1";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDocumentBtn;
        private System.Windows.Forms.TextBox textBoxDocument;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.Label labelOutputText;
    }
}

