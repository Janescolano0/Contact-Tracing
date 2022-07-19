namespace contact_tracing
{
    partial class form__admin
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
            this.lbl__dateselect = new System.Windows.Forms.Label();
            this.@__datepick = new System.Windows.Forms.DateTimePicker();
            this.lbl__records = new System.Windows.Forms.Label();
            this.btn__open = new System.Windows.Forms.Button();
            this.btn__select = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.btn__select);
            this.panel1.Controls.Add(this.btn__open);
            this.panel1.Controls.Add(this.lbl__records);
            this.panel1.Controls.Add(this.@__datepick);
            this.panel1.Controls.Add(this.lbl__dateselect);
            this.panel1.Location = new System.Drawing.Point(56, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 461);
            this.panel1.TabIndex = 0;
            // 
            // lbl__dateselect
            // 
            this.lbl__dateselect.AutoSize = true;
            this.lbl__dateselect.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__dateselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__dateselect.Location = new System.Drawing.Point(61, 48);
            this.lbl__dateselect.Name = "lbl__dateselect";
            this.lbl__dateselect.Size = new System.Drawing.Size(132, 58);
            this.lbl__dateselect.TabIndex = 16;
            this.lbl__dateselect.Text = "Select date to\r\n view records\r\n";
            // 
            // __datepick
            // 
            this.@__datepick.Location = new System.Drawing.Point(30, 109);
            this.@__datepick.Name = "__datepick";
            this.@__datepick.Size = new System.Drawing.Size(200, 20);
            this.@__datepick.TabIndex = 17;
            // 
            // lbl__records
            // 
            this.lbl__records.AutoSize = true;
            this.lbl__records.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__records.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__records.Location = new System.Drawing.Point(74, 277);
            this.lbl__records.Name = "lbl__records";
            this.lbl__records.Size = new System.Drawing.Size(108, 29);
            this.lbl__records.TabIndex = 18;
            this.lbl__records.Text = "All records";
            // 
            // btn__open
            // 
            this.btn__open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__open.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__open.Location = new System.Drawing.Point(65, 309);
            this.btn__open.Name = "btn__open";
            this.btn__open.Size = new System.Drawing.Size(127, 60);
            this.btn__open.TabIndex = 30;
            this.btn__open.Text = "Open";
            this.btn__open.UseVisualStyleBackColor = false;
            // 
            // btn__select
            // 
            this.btn__select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__select.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__select.Location = new System.Drawing.Point(65, 135);
            this.btn__select.Name = "btn__select";
            this.btn__select.Size = new System.Drawing.Size(128, 58);
            this.btn__select.TabIndex = 31;
            this.btn__select.Text = "Select";
            this.btn__select.UseVisualStyleBackColor = false;
            // 
            // form__admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(365, 574);
            this.Controls.Add(this.panel1);
            this.Name = "form__admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl__records;
        private System.Windows.Forms.DateTimePicker __datepick;
        private System.Windows.Forms.Label lbl__dateselect;
        private System.Windows.Forms.Button btn__open;
        private System.Windows.Forms.Button btn__select;
    }
}