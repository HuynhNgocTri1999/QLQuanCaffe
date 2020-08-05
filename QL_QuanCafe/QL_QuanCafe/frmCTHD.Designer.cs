namespace QL_QuanCafe
{
    partial class frmCTHD
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
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(307, 59);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaCTHD.TabIndex = 0;
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 364);
            this.Controls.Add(this.txtMaCTHD);
            this.Name = "frmCTHD";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaCTHD;
    }
}