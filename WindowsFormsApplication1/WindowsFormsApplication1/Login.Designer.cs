namespace WindowsFormsApplication1
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBut = new System.Windows.Forms.Button();
            this.LogUserBox = new System.Windows.Forms.TextBox();
            this.LogPassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lgoin";
            // 
            // LoginBut
            // 
            this.LoginBut.Location = new System.Drawing.Point(156, 221);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(75, 23);
            this.LoginBut.TabIndex = 8;
            this.LoginBut.Text = "Login";
            this.LoginBut.UseVisualStyleBackColor = true;
            // 
            // LogUserBox
            // 
            this.LogUserBox.Location = new System.Drawing.Point(156, 135);
            this.LogUserBox.Name = "LogUserBox";
            this.LogUserBox.Size = new System.Drawing.Size(100, 20);
            this.LogUserBox.TabIndex = 9;
            // 
            // LogPassBox
            // 
            this.LogPassBox.Location = new System.Drawing.Point(156, 163);
            this.LogPassBox.Name = "LogPassBox";
            this.LogPassBox.PasswordChar = '*';
            this.LogPassBox.Size = new System.Drawing.Size(100, 20);
            this.LogPassBox.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.LogPassBox);
            this.Controls.Add(this.LogUserBox);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(413, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.TextBox LogUserBox;
        private System.Windows.Forms.TextBox LogPassBox;
    }
}
