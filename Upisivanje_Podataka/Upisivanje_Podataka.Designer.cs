namespace Upisivanje_Podataka
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
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.txt_Ime = new System.Windows.Forms.TextBox();
            this.txt_Prezime = new System.Windows.Forms.TextBox();
            this.txt_Godina_rodenja = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.Location = new System.Drawing.Point(635, 108);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(120, 252);
            this.btn_Spremi.TabIndex = 0;
            this.btn_Spremi.Text = "Spremi";
            this.btn_Spremi.UseVisualStyleBackColor = true;
            // 
            // txt_Ime
            // 
            this.txt_Ime.Location = new System.Drawing.Point(183, 108);
            this.txt_Ime.Multiline = true;
            this.txt_Ime.Name = "txt_Ime";
            this.txt_Ime.Size = new System.Drawing.Size(363, 33);
            this.txt_Ime.TabIndex = 1;
            // 
            // txt_Prezime
            // 
            this.txt_Prezime.Location = new System.Drawing.Point(183, 179);
            this.txt_Prezime.Multiline = true;
            this.txt_Prezime.Name = "txt_Prezime";
            this.txt_Prezime.Size = new System.Drawing.Size(363, 33);
            this.txt_Prezime.TabIndex = 3;
            // 
            // txt_Godina_rodenja
            // 
            this.txt_Godina_rodenja.Location = new System.Drawing.Point(183, 253);
            this.txt_Godina_rodenja.Multiline = true;
            this.txt_Godina_rodenja.Name = "txt_Godina_rodenja";
            this.txt_Godina_rodenja.Size = new System.Drawing.Size(363, 33);
            this.txt_Godina_rodenja.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(183, 327);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(363, 33);
            this.txt_Email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Godina rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Godina_rodenja);
            this.Controls.Add(this.txt_Prezime);
            this.Controls.Add(this.txt_Ime);
            this.Controls.Add(this.btn_Spremi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.TextBox txt_Ime;
        private System.Windows.Forms.TextBox txt_Prezime;
        private System.Windows.Forms.TextBox txt_Godina_rodenja;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

