namespace VideoRentalApp
{
    partial class FormInchirieri
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
            this.dateInchiriere = new System.Windows.Forms.DateTimePicker();
            this.dateReturnare = new System.Windows.Forms.DateTimePicker();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.textBoxClienti = new System.Windows.Forms.TextBox();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.textBoxGen = new System.Windows.Forms.TextBox();
            this.listBoxInchirieri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateInchiriere
            // 
            this.dateInchiriere.Location = new System.Drawing.Point(94, 192);
            this.dateInchiriere.Name = "dateInchiriere";
            this.dateInchiriere.Size = new System.Drawing.Size(288, 22);
            this.dateInchiriere.TabIndex = 2;
            // 
            // dateReturnare
            // 
            this.dateReturnare.Location = new System.Drawing.Point(1, 263);
            this.dateReturnare.Name = "dateReturnare";
            this.dateReturnare.Size = new System.Drawing.Size(288, 22);
            this.dateReturnare.TabIndex = 3;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(60, 344);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(266, 71);
            this.buttonAdauga.TabIndex = 4;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // textBoxClienti
            // 
            this.textBoxClienti.Location = new System.Drawing.Point(1, 1);
            this.textBoxClienti.Name = "textBoxClienti";
            this.textBoxClienti.Size = new System.Drawing.Size(220, 22);
            this.textBoxClienti.TabIndex = 5;
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(172, 53);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(223, 22);
            this.textBoxTitlu.TabIndex = 6;
            // 
            // textBoxGen
            // 
            this.textBoxGen.Location = new System.Drawing.Point(1, 95);
            this.textBoxGen.Name = "textBoxGen";
            this.textBoxGen.Size = new System.Drawing.Size(233, 22);
            this.textBoxGen.TabIndex = 7;
            // 
            // listBoxInchirieri
            // 
            this.listBoxInchirieri.FormattingEnabled = true;
            this.listBoxInchirieri.ItemHeight = 16;
            this.listBoxInchirieri.Location = new System.Drawing.Point(388, 1);
            this.listBoxInchirieri.Name = "listBoxInchirieri";
            this.listBoxInchirieri.Size = new System.Drawing.Size(411, 468);
            this.listBoxInchirieri.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Titlu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "DataInchiriere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "DataReturnare";
            // 
            // FormInchirieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxInchirieri);
            this.Controls.Add(this.textBoxGen);
            this.Controls.Add(this.textBoxTitlu);
            this.Controls.Add(this.textBoxClienti);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.dateReturnare);
            this.Controls.Add(this.dateInchiriere);
            this.Name = "FormInchirieri";
            this.Text = "FormInchirieri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateInchiriere;
        private System.Windows.Forms.DateTimePicker dateReturnare;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.TextBox textBoxClienti;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.TextBox textBoxGen;
        private System.Windows.Forms.ListBox listBoxInchirieri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}