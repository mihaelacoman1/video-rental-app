namespace VideoRentalApp
{
    partial class FormFilm
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
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.textBoxGen = new System.Windows.Forms.TextBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonEditeaza = new System.Windows.Forms.Button();
            this.listBoxFilme = new System.Windows.Forms.ListBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(68, 6);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(184, 22);
            this.textBoxTitlu.TabIndex = 0;
            // 
            // textBoxGen
            // 
            this.textBoxGen.Location = new System.Drawing.Point(67, 42);
            this.textBoxGen.Name = "textBoxGen";
            this.textBoxGen.Size = new System.Drawing.Size(185, 22);
            this.textBoxGen.TabIndex = 1;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(215, 101);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(130, 46);
            this.buttonSterge.TabIndex = 3;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonEditeaza
            // 
            this.buttonEditeaza.Location = new System.Drawing.Point(111, 169);
            this.buttonEditeaza.Name = "buttonEditeaza";
            this.buttonEditeaza.Size = new System.Drawing.Size(132, 47);
            this.buttonEditeaza.TabIndex = 4;
            this.buttonEditeaza.Text = "Editeaza";
            this.buttonEditeaza.UseVisualStyleBackColor = true;
            this.buttonEditeaza.Click += new System.EventHandler(this.buttonEditeaza_Click);
            // 
            // listBoxFilme
            // 
            this.listBoxFilme.FormattingEnabled = true;
            this.listBoxFilme.ItemHeight = 16;
            this.listBoxFilme.Location = new System.Drawing.Point(351, 6);
            this.listBoxFilme.Name = "listBoxFilme";
            this.listBoxFilme.Size = new System.Drawing.Size(448, 452);
            this.listBoxFilme.TabIndex = 5;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(15, 101);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(133, 44);
            this.buttonAdauga.TabIndex = 2;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titlu";
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFilme);
            this.Controls.Add(this.buttonEditeaza);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textBoxGen);
            this.Controls.Add(this.textBoxTitlu);
            this.Name = "FormFilm";
            this.Text = "FormFilm";
            this.Load += new System.EventHandler(this.FormFilm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.TextBox textBoxGen;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonEditeaza;
        private System.Windows.Forms.ListBox listBoxFilme;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}