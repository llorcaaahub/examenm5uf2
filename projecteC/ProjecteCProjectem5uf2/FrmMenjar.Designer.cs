namespace ProjecteCProjectem5uf2
{
    partial class FrmMenjar
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
            this.lbMenjar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMenjar
            // 
            this.lbMenjar.AutoSize = true;
            this.lbMenjar.Location = new System.Drawing.Point(272, 78);
            this.lbMenjar.Name = "lbMenjar";
            this.lbMenjar.Size = new System.Drawing.Size(143, 16);
            this.lbMenjar.TabIndex = 0;
            this.lbMenjar.Text = "M\'agraden les ostres ;)";
            // 
            // FrmMenjar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMenjar);
            this.Name = "FrmMenjar";
            this.Text = "FrmMenjar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMenjar;
    }
}