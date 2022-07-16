namespace contact_tracing
{
    partial class form__contacttracing
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
            this.lbl__contacttracing = new System.Windows.Forms.Label();
            this.btn__form = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.btn__form);
            this.panel1.Controls.Add(this.lbl__contacttracing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(101)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 111);
            this.panel1.TabIndex = 7;
            // 
            // lbl__contacttracing
            // 
            this.lbl__contacttracing.AutoSize = true;
            this.lbl__contacttracing.Font = new System.Drawing.Font("Oswald", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__contacttracing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__contacttracing.Location = new System.Drawing.Point(3, 5);
            this.lbl__contacttracing.Name = "lbl__contacttracing";
            this.lbl__contacttracing.Size = new System.Drawing.Size(454, 87);
            this.lbl__contacttracing.TabIndex = 8;
            this.lbl__contacttracing.Text = "Contact Tracing";
            // 
            // btn__form
            // 
            this.btn__form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__form.Font = new System.Drawing.Font("Oswald", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__form.Location = new System.Drawing.Point(442, 8);
            this.btn__form.Name = "btn__form";
            this.btn__form.Size = new System.Drawing.Size(180, 84);
            this.btn__form.TabIndex = 9;
            this.btn__form.Text = "Form";
            this.btn__form.UseVisualStyleBackColor = false;
            this.btn__form.Click += new System.EventHandler(this.btn__form_Click);
            // 
            // form__contacttracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(755, 103);
            this.Controls.Add(this.panel1);
            this.Name = "form__contacttracing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl__contacttracing;
        private System.Windows.Forms.Button btn__form;
    }
}

