namespace Presentationslager
{
    partial class FormBokning
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
            this.listBoxTillangligaBocker = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListaBocker = new System.Windows.Forms.Button();
            this.listBoxBockerBokning = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntLaggTillBok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenomforBokning = new System.Windows.Forms.Button();
            this.BtnTaBortBok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTillangligaBocker
            // 
            this.listBoxTillangligaBocker.FormattingEnabled = true;
            this.listBoxTillangligaBocker.Location = new System.Drawing.Point(12, 25);
            this.listBoxTillangligaBocker.Name = "listBoxTillangligaBocker";
            this.listBoxTillangligaBocker.Size = new System.Drawing.Size(228, 277);
            this.listBoxTillangligaBocker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tillgängliga böcker";
            // 
            // btnListaBocker
            // 
            this.btnListaBocker.Location = new System.Drawing.Point(13, 309);
            this.btnListaBocker.Name = "btnListaBocker";
            this.btnListaBocker.Size = new System.Drawing.Size(98, 23);
            this.btnListaBocker.TabIndex = 2;
            this.btnListaBocker.Text = "Återställ formulär";
            this.btnListaBocker.UseVisualStyleBackColor = true;
            this.btnListaBocker.Click += new System.EventHandler(this.BtnLaddaOmFormular_Click);
            // 
            // listBoxBockerBokning
            // 
            this.listBoxBockerBokning.FormattingEnabled = true;
            this.listBoxBockerBokning.Location = new System.Drawing.Point(327, 25);
            this.listBoxBockerBokning.Name = "listBoxBockerBokning";
            this.listBoxBockerBokning.Size = new System.Drawing.Size(233, 277);
            this.listBoxBockerBokning.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bokningslista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lägg till bok";
            // 
            // bntLaggTillBok
            // 
            this.bntLaggTillBok.Location = new System.Drawing.Point(246, 90);
            this.bntLaggTillBok.Name = "bntLaggTillBok";
            this.bntLaggTillBok.Size = new System.Drawing.Size(75, 46);
            this.bntLaggTillBok.TabIndex = 6;
            this.bntLaggTillBok.Text = "--->";
            this.bntLaggTillBok.UseVisualStyleBackColor = true;
            this.bntLaggTillBok.Click += new System.EventHandler(this.bntLaggTillBok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medlemsnummer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(584, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btnGenomforBokning
            // 
            this.btnGenomforBokning.Location = new System.Drawing.Point(584, 53);
            this.btnGenomforBokning.Name = "btnGenomforBokning";
            this.btnGenomforBokning.Size = new System.Drawing.Size(127, 23);
            this.btnGenomforBokning.TabIndex = 9;
            this.btnGenomforBokning.Text = "Genomför bokning";
            this.btnGenomforBokning.UseVisualStyleBackColor = true;
            // 
            // BtnTaBortBok
            // 
            this.BtnTaBortBok.Location = new System.Drawing.Point(246, 173);
            this.BtnTaBortBok.Name = "BtnTaBortBok";
            this.BtnTaBortBok.Size = new System.Drawing.Size(75, 46);
            this.BtnTaBortBok.TabIndex = 11;
            this.BtnTaBortBok.Text = "<---";
            this.BtnTaBortBok.UseVisualStyleBackColor = true;
            this.BtnTaBortBok.Click += new System.EventHandler(this.BtnTaBortBok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ta bort bok";
            // 
            // FormBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 345);
            this.Controls.Add(this.BtnTaBortBok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenomforBokning);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntLaggTillBok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxBockerBokning);
            this.Controls.Add(this.btnListaBocker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTillangligaBocker);
            this.Name = "FormBokning";
            this.Text = "FormBokning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTillangligaBocker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListaBocker;
        private System.Windows.Forms.ListBox listBoxBockerBokning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntLaggTillBok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenomforBokning;
        private System.Windows.Forms.Button BtnTaBortBok;
        private System.Windows.Forms.Label label5;
    }
}