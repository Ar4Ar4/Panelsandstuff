namespace WindowsFormsApplication1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HomButt = new System.Windows.Forms.Button();
            this.Regisbutt = new System.Windows.Forms.Button();
            this.LogButt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.login1 = new WindowsFormsApplication1.Login();
            this.regis1 = new WindowsFormsApplication1.Regis();
            this.home1 = new WindowsFormsApplication1.Home();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailout = new System.Windows.Forms.TextBox();
            this.userout = new System.Windows.Forms.TextBox();
            this.passout = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Regisbutt);
            this.panel1.Controls.Add(this.LogButt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HomButt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 446);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "UCP App";
            // 
            // HomButt
            // 
            this.HomButt.Location = new System.Drawing.Point(54, 99);
            this.HomButt.Name = "HomButt";
            this.HomButt.Size = new System.Drawing.Size(75, 23);
            this.HomButt.TabIndex = 1;
            this.HomButt.Text = "Home";
            this.HomButt.UseVisualStyleBackColor = true;
            this.HomButt.Click += new System.EventHandler(this.HomButt_Click);
            // 
            // Regisbutt
            // 
            this.Regisbutt.Location = new System.Drawing.Point(54, 148);
            this.Regisbutt.Name = "Regisbutt";
            this.Regisbutt.Size = new System.Drawing.Size(75, 23);
            this.Regisbutt.TabIndex = 2;
            this.Regisbutt.Text = "Registration";
            this.Regisbutt.UseVisualStyleBackColor = true;
            this.Regisbutt.Click += new System.EventHandler(this.Regisbutt_Click);
            // 
            // LogButt
            // 
            this.LogButt.Location = new System.Drawing.Point(54, 196);
            this.LogButt.Name = "LogButt";
            this.LogButt.Size = new System.Drawing.Size(75, 23);
            this.LogButt.TabIndex = 3;
            this.LogButt.Text = "Login\r\n";
            this.LogButt.UseVisualStyleBackColor = true;
            this.LogButt.Click += new System.EventHandler(this.LogButt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passout);
            this.panel2.Controls.Add(this.userout);
            this.panel2.Controls.Add(this.emailout);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(730, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 446);
            this.panel2.TabIndex = 7;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.MistyRose;
            this.login1.Location = new System.Drawing.Point(282, 36);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(413, 328);
            this.login1.TabIndex = 6;
            this.login1.Visible = false;
            // 
            // regis1
            // 
            this.regis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.regis1.Location = new System.Drawing.Point(237, 36);
            this.regis1.Name = "regis1";
            this.regis1.Size = new System.Drawing.Size(476, 304);
            this.regis1.TabIndex = 5;
            this.regis1.Visible = false;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(237, 36);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(470, 351);
            this.home1.TabIndex = 4;
            this.home1.Visible = false;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // emailout
            // 
            this.emailout.Location = new System.Drawing.Point(78, 99);
            this.emailout.Name = "emailout";
            this.emailout.Size = new System.Drawing.Size(100, 20);
            this.emailout.TabIndex = 7;
            // 
            // userout
            // 
            this.userout.Location = new System.Drawing.Point(78, 125);
            this.userout.Name = "userout";
            this.userout.Size = new System.Drawing.Size(100, 20);
            this.userout.TabIndex = 8;
            // 
            // passout
            // 
            this.passout.Location = new System.Drawing.Point(78, 151);
            this.passout.Name = "passout";
            this.passout.Size = new System.Drawing.Size(100, 20);
            this.passout.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.regis1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Regisbutt;
        private System.Windows.Forms.Button LogButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomButt;
        private Home home1;
        private Regis regis1;
        private Login login1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passout;
        private System.Windows.Forms.TextBox userout;
        private System.Windows.Forms.TextBox emailout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

