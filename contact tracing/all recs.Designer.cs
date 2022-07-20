namespace contact_tracing
{
    partial class form__allrecs
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
            this.lbl__recs = new System.Windows.Forms.Label();
            this.lbl__underscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl__recs
            // 
            this.lbl__recs.AutoSize = true;
            this.lbl__recs.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__recs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__recs.Location = new System.Drawing.Point(11, 16);
            this.lbl__recs.Name = "lbl__recs";
            this.lbl__recs.Size = new System.Drawing.Size(84, 29);
            this.lbl__recs.TabIndex = 11;
            this.lbl__recs.Text = "Records";
            this.lbl__recs.Click += new System.EventHandler(this.lbl__recs_Click);
            // 
            // lbl__underscore
            // 
            this.lbl__underscore.AutoSize = true;
            this.lbl__underscore.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__underscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__underscore.Location = new System.Drawing.Point(12, 45);
            this.lbl__underscore.Name = "lbl__underscore";
            this.lbl__underscore.Size = new System.Drawing.Size(965, 21);
            this.lbl__underscore.TabIndex = 12;
            this.lbl__underscore.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______________________________";
            // 
            // form__allrecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.lbl__underscore);
            this.Controls.Add(this.lbl__recs);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "form__allrecs";
            this.Text = "Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl__recs;
        private System.Windows.Forms.Label lbl__underscore;
    }
}