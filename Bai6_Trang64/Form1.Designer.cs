namespace Bai6_Trang64
{
    partial class Form1
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
			this.lstDanhSach = new System.Windows.Forms.ListBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstDanhSach
			// 
			this.lstDanhSach.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lstDanhSach.FormattingEnabled = true;
			this.lstDanhSach.ItemHeight = 16;
			this.lstDanhSach.Location = new System.Drawing.Point(51, 12);
			this.lstDanhSach.Name = "lstDanhSach";
			this.lstDanhSach.Size = new System.Drawing.Size(696, 356);
			this.lstDanhSach.TabIndex = 0;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(51, 400);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(696, 28);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lstDanhSach);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListBox_Bai6Trang64";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnOK;
    }
}

