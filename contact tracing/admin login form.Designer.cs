namespace contact_tracing
{
    partial class form__adminlogin
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
            this.lbl__adminlogin = new System.Windows.Forms.Label();
            this.lbl__user = new System.Windows.Forms.Label();
            this.lbl__pass = new System.Windows.Forms.Label();
            this.tbox__user = new System.Windows.Forms.TextBox();
            this.tbox__pass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn__login = new System.Windows.Forms.Button();
            this.cbox__showpass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl__adminlogin
            // 
            this.lbl__adminlogin.AutoSize = true;
            this.lbl__adminlogin.Font = new System.Drawing.Font("Oswald", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__adminlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__adminlogin.Location = new System.Drawing.Point(26, 21);
            this.lbl__adminlogin.Name = "lbl__adminlogin";
            this.lbl__adminlogin.Size = new System.Drawing.Size(157, 65);
            this.lbl__adminlogin.TabIndex = 9;
            this.lbl__adminlogin.Text = "ADMIN";
            // 
            // lbl__user
            // 
            this.lbl__user.AutoSize = true;
            this.lbl__user.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__user.Location = new System.Drawing.Point(65, 35);
            this.lbl__user.Name = "lbl__user";
            this.lbl__user.Size = new System.Drawing.Size(76, 21);
            this.lbl__user.TabIndex = 11;
            this.lbl__user.Text = "Username";
            // 
            // lbl__pass
            // 
            this.lbl__pass.AutoSize = true;
            this.lbl__pass.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__pass.Location = new System.Drawing.Point(65, 92);
            this.lbl__pass.Name = "lbl__pass";
            this.lbl__pass.Size = new System.Drawing.Size(73, 21);
            this.lbl__pass.TabIndex = 14;
            this.lbl__pass.Text = "Password";
            // 
            // tbox__user
            // 
            this.tbox__user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__user.Location = new System.Drawing.Point(21, 59);
            this.tbox__user.Name = "tbox__user";
            this.tbox__user.Size = new System.Drawing.Size(159, 20);
            this.tbox__user.TabIndex = 15;
            // 
            // tbox__pass
            // 
            this.tbox__pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__pass.Location = new System.Drawing.Point(21, 116);
            this.tbox__pass.Name = "tbox__pass";
            this.tbox__pass.Size = new System.Drawing.Size(159, 20);
            this.tbox__pass.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lbl__adminlogin);
            this.panel1.Location = new System.Drawing.Point(278, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 110);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.cbox__showpass);
            this.panel2.Controls.Add(this.btn__login);
            this.panel2.Controls.Add(this.tbox__pass);
            this.panel2.Controls.Add(this.lbl__pass);
            this.panel2.Controls.Add(this.lbl__user);
            this.panel2.Controls.Add(this.tbox__user);
            this.panel2.Location = new System.Drawing.Point(45, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 194);
            this.panel2.TabIndex = 18;
            // 
            // btn__login
            // 
            this.btn__login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__login.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__login.Location = new System.Drawing.Point(21, 142);
            this.btn__login.Name = "btn__login";
            this.btn__login.Size = new System.Drawing.Size(67, 38);
            this.btn__login.TabIndex = 31;
            this.btn__login.Text = "LOGIN";
            this.btn__login.UseVisualStyleBackColor = false;
            this.btn__login.Click += new System.EventHandler(this.btn__login_Click);
            // 
            // cbox__showpass
            // 
            this.cbox__showpass.AutoSize = true;
            this.cbox__showpass.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox__showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.cbox__showpass.Location = new System.Drawing.Point(94, 142);
            this.cbox__showpass.Name = "cbox__showpass";
            this.cbox__showpass.Size = new System.Drawing.Size(112, 24);
            this.cbox__showpass.TabIndex = 32;
            this.cbox__showpass.Text = "Show Password";
            this.cbox__showpass.UseVisualStyleBackColor = true;
            this.cbox__showpass.CheckedChanged += new System.EventHandler(this.cbox__showpass_CheckedChanged);
            // 
            // form__adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(553, 310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "form__adminlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin LOGIN ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl__adminlogin;
        private System.Windows.Forms.Label lbl__user;
        private System.Windows.Forms.Label lbl__pass;
        private System.Windows.Forms.TextBox tbox__user;
        private System.Windows.Forms.TextBox tbox__pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn__login;
        private System.Windows.Forms.CheckBox cbox__showpass;
    }
}