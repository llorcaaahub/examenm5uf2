namespace ProjecteCProjectem5uf2
{
    partial class FrmViatge
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
            this.lbViatge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbViatge
            // 
            this.lbViatge.AutoSize = true;
            this.lbViatge.Location = new System.Drawing.Point(170, 225);
            this.lbViatge.Name = "lbViatge";
            this.lbViatge.Size = new System.Drawing.Size(297, 16);
            this.lbViatge.TabIndex = 0;
            this.lbViatge.Text = "M\'agradaria viatjar a Australia per veure aranyes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjecteCProjectem5uf2.Properties.Resources.Foto_Australia;
            this.pictureBox1.Location = new System.Drawing.Point(164, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 163);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmViatge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbViatge);
            this.Name = "FrmViatge";
            this.Text = "FrmViatge";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbViatge;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}