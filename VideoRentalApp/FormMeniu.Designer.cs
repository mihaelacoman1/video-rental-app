namespace VideoRentalApp
{
    partial class FormMeniu
    {
        private System.ComponentModel.IContainer components = null;

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
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClienti = new System.Windows.Forms.Button();
            this.buttonFilme = new System.Windows.Forms.Button();
            this.buttonInchirieri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClienti
            // 
            this.buttonClienti.Location = new System.Drawing.Point(1, -2);
            this.buttonClienti.Name = "buttonClienti";
            this.buttonClienti.Size = new System.Drawing.Size(633, 471);
            this.buttonClienti.TabIndex = 0;
            this.buttonClienti.Text = "Clienti";
            this.buttonClienti.UseVisualStyleBackColor = true;
            this.buttonClienti.Click += new System.EventHandler(this.buttonClienti_Click);
            // 
            // buttonFilme
            // 
            this.buttonFilme.Location = new System.Drawing.Point(631, 362);
            this.buttonFilme.Name = "buttonFilme";
            this.buttonFilme.Size = new System.Drawing.Size(624, 363);
            this.buttonFilme.TabIndex = 1;
            this.buttonFilme.Text = "Filme";
            this.buttonFilme.UseVisualStyleBackColor = true;
            this.buttonFilme.Click += new System.EventHandler(this.buttonFilme_Click);
            // 
            // buttonInchirieri
            // 
            this.buttonInchirieri.Location = new System.Drawing.Point(1042, -2);
            this.buttonInchirieri.Name = "buttonInchirieri";
            this.buttonInchirieri.Size = new System.Drawing.Size(677, 369);
            this.buttonInchirieri.TabIndex = 2;
            this.buttonInchirieri.Text = "Inchirieri";
            this.buttonInchirieri.UseVisualStyleBackColor = true;
            this.buttonInchirieri.Click += new System.EventHandler(this.buttonInchirieri_Click);
            // 
            // FormMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 721);
            this.Controls.Add(this.buttonInchirieri);
            this.Controls.Add(this.buttonFilme);
            this.Controls.Add(this.buttonClienti);
            this.Name = "FormMeniu";
            this.Text = "FormMeniu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClienti;
        private System.Windows.Forms.Button buttonFilme;
        private System.Windows.Forms.Button buttonInchirieri;

    }
}
