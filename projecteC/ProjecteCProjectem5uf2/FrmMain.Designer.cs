namespace ProjecteCProjectem5uf2
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenjar = new System.Windows.Forms.Button();
            this.btnViatge = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenjar
            // 
            this.btnMenjar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMenjar.Location = new System.Drawing.Point(74, 67);
            this.btnMenjar.Name = "btnMenjar";
            this.btnMenjar.Size = new System.Drawing.Size(75, 23);
            this.btnMenjar.TabIndex = 0;
            this.btnMenjar.Text = "Menjar";
            this.btnMenjar.UseVisualStyleBackColor = false;
            this.btnMenjar.Click += new System.EventHandler(this.btnMenjar_Click);
            // 
            // btnViatge
            // 
            this.btnViatge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViatge.Location = new System.Drawing.Point(222, 66);
            this.btnViatge.Name = "btnViatge";
            this.btnViatge.Size = new System.Drawing.Size(75, 23);
            this.btnViatge.TabIndex = 1;
            this.btnViatge.Text = "Viatge";
            this.btnViatge.UseVisualStyleBackColor = false;
            this.btnViatge.Click += new System.EventHandler(this.btnViatge_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.Color.Blue;
            this.btnAnimal.Location = new System.Drawing.Point(431, 66);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAnimal.TabIndex = 3;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.btnViatge);
            this.Controls.Add(this.btnMenjar);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenjar;
        private System.Windows.Forms.Button btnViatge;
        private System.Windows.Forms.Button btnAnimal;
    }
}

