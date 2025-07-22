namespace VideoRentalApp
{
    partial class FormClient
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
            
        private void InitializeComponent()
        {
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonEditeaza = new System.Windows.Forms.Button();
            this.listBoxClienti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(421, 61);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(187, 22);
            this.textBoxNume.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(614, 61);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(185, 22);
            this.textBoxEmail.TabIndex = 1;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(536, 141);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(138, 54);
            this.buttonAdauga.TabIndex = 2;
            this.buttonAdauga.Text = "Adauga ";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(545, 218);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(111, 59);
            this.buttonSterge.TabIndex = 3;
            this.buttonSterge.Text = "Sterge ";
            this.buttonSterge.UseVisualStyleBackColor = true;
            // 
            // buttonEditeaza
            // 
            this.buttonEditeaza.Location = new System.Drawing.Point(488, 296);
            this.buttonEditeaza.Name = "buttonEditeaza";
            this.buttonEditeaza.Size = new System.Drawing.Size(231, 55);
            this.buttonEditeaza.TabIndex = 4;
            this.buttonEditeaza.Text = "Editeaza ";
            this.buttonEditeaza.UseVisualStyleBackColor = true;
            // 
            // listBoxClienti
            // 
            this.listBoxClienti.FormattingEnabled = true;
            this.listBoxClienti.ItemHeight = 16;
            this.listBoxClienti.Location = new System.Drawing.Point(2, 0);
            this.listBoxClienti.Name = "listBoxClienti";
            this.listBoxClienti.Size = new System.Drawing.Size(421, 452);
            this.listBoxClienti.TabIndex = 5;
            this.listBoxClienti.SelectedIndexChanged += new System.EventHandler(this.listBoxClienti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxClienti);
            this.Controls.Add(this.buttonEditeaza);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNume);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonEditeaza;
        private System.Windows.Forms.ListBox listBoxClienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

