namespace Presentationslager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnsNr = new System.Windows.Forms.TextBox();
            this.textBoxLosenOrd = new System.Windows.Forms.TextBox();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anställningsnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lösenord";
            // 
            // textBoxAnsNr
            // 
            this.textBoxAnsNr.Location = new System.Drawing.Point(138, 30);
            this.textBoxAnsNr.Name = "textBoxAnsNr";
            this.textBoxAnsNr.Size = new System.Drawing.Size(123, 20);
            this.textBoxAnsNr.TabIndex = 2;
            // 
            // textBoxLosenOrd
            // 
            this.textBoxLosenOrd.Location = new System.Drawing.Point(138, 68);
            this.textBoxLosenOrd.Name = "textBoxLosenOrd";
            this.textBoxLosenOrd.Size = new System.Drawing.Size(123, 20);
            this.textBoxLosenOrd.TabIndex = 3;
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(186, 107);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(75, 23);
            this.btnLoggaIn.TabIndex = 4;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 175);
            this.Controls.Add(this.btnLoggaIn);
            this.Controls.Add(this.textBoxLosenOrd);
            this.Controls.Add(this.textBoxAnsNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BibSyst Inloggning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAnsNr;
        private System.Windows.Forms.TextBox textBoxLosenOrd;
        private System.Windows.Forms.Button btnLoggaIn;
    }
}

