namespace WindowsFormsApplication1
{
    partial class Regis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.usernbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.RegSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(174, 109);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(100, 20);
            this.emailbox.TabIndex = 4;
            // 
            // usernbox
            // 
            this.usernbox.Location = new System.Drawing.Point(174, 135);
            this.usernbox.Name = "usernbox";
            this.usernbox.Size = new System.Drawing.Size(100, 20);
            this.usernbox.TabIndex = 5;
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(174, 161);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(100, 20);
            this.passbox.TabIndex = 6;
            // 
            // RegSub
            // 
            this.RegSub.Location = new System.Drawing.Point(199, 207);
            this.RegSub.Name = "RegSub";
            this.RegSub.Size = new System.Drawing.Size(75, 23);
            this.RegSub.TabIndex = 7;
            this.RegSub.Text = "Submit";
            this.RegSub.UseVisualStyleBackColor = true;
            this.RegSub.Click += new System.EventHandler(this.RegSub_Click);
            // 
            // Regis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.RegSub);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.usernbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Regis";
            this.Size = new System.Drawing.Size(524, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox usernbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button RegSub;
    }
}
