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
            this.SuspendLayout();
            // 
            // lbl__adminlogin
            // 
            this.lbl__adminlogin.AutoSize = true;
            this.lbl__adminlogin.Font = new System.Drawing.Font("Oswald", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__adminlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__adminlogin.Location = new System.Drawing.Point(281, 125);
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
            this.lbl__user.Location = new System.Drawing.Point(124, 101);
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
            this.lbl__pass.Location = new System.Drawing.Point(124, 164);
            this.lbl__pass.Name = "lbl__pass";
            this.lbl__pass.Size = new System.Drawing.Size(73, 21);
            this.lbl__pass.TabIndex = 14;
            this.lbl__pass.Text = "Password";
            // 
            // tbox__user
            // 
            this.tbox__user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__user.Location = new System.Drawing.Point(85, 125);
            this.tbox__user.Name = "tbox__user";
            this.tbox__user.Size = new System.Drawing.Size(153, 20);
            this.tbox__user.TabIndex = 15;
            // 
            // tbox__pass
            // 
            this.tbox__pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__pass.Location = new System.Drawing.Point(85, 188);
            this.tbox__pass.Name = "tbox__pass";
            this.tbox__pass.Size = new System.Drawing.Size(153, 20);
            this.tbox__pass.TabIndex = 16;
            // 
            // form__adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(553, 322);
            this.Controls.Add(this.tbox__pass);
            this.Controls.Add(this.tbox__user);
            this.Controls.Add(this.lbl__pass);
            this.Controls.Add(this.lbl__user);
            this.Controls.Add(this.lbl__adminlogin);
            this.Name = "form__adminlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin LOGIN ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl__adminlogin;
        private System.Windows.Forms.Label lbl__user;
        private System.Windows.Forms.Label lbl__pass;
        private System.Windows.Forms.TextBox tbox__user;
        private System.Windows.Forms.TextBox tbox__pass;
    }
}