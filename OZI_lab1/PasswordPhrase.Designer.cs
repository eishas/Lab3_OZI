namespace OZI_lab1
{
    partial class PasswordPhrase
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
            this.textBox_passwordPhrase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit_password_phrase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_passwordPhrase
            // 
            this.textBox_passwordPhrase.Location = new System.Drawing.Point(17, 47);
            this.textBox_passwordPhrase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_passwordPhrase.Name = "textBox_passwordPhrase";
            this.textBox_passwordPhrase.Size = new System.Drawing.Size(465, 22);
            this.textBox_passwordPhrase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть парольну фразу:";
            // 
            // submit_password_phrase
            // 
            this.submit_password_phrase.BackColor = System.Drawing.Color.Aquamarine;
            this.submit_password_phrase.Location = new System.Drawing.Point(180, 79);
            this.submit_password_phrase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit_password_phrase.Name = "submit_password_phrase";
            this.submit_password_phrase.Size = new System.Drawing.Size(136, 47);
            this.submit_password_phrase.TabIndex = 2;
            this.submit_password_phrase.Text = "Встановити парольну фразу";
            this.submit_password_phrase.UseVisualStyleBackColor = false;
            this.submit_password_phrase.Click += new System.EventHandler(this.submit_password_phrase_Click);
            // 
            // PasswordPhrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(500, 140);
            this.Controls.Add(this.submit_password_phrase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_passwordPhrase);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordPhrase";
            this.Text = "PasswordPhrase";
            this.Load += new System.EventHandler(this.PasswordPhrase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_passwordPhrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_password_phrase;
    }
}