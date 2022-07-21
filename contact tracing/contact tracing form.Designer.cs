namespace contact_tracing
{
    partial class form__contacttracingform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form__contacttracingform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn__admin = new System.Windows.Forms.Button();
            this.calendar__dateselect = new System.Windows.Forms.DateTimePicker();
            this.lbl__contacttracingform = new System.Windows.Forms.Label();
            this.lbl__personaldeets = new System.Windows.Forms.Label();
            this.lbl__last = new System.Windows.Forms.Label();
            this.lbl__middle = new System.Windows.Forms.Label();
            this.tbox__middle = new System.Windows.Forms.TextBox();
            this.tbox__last = new System.Windows.Forms.TextBox();
            this.lbl__first = new System.Windows.Forms.Label();
            this.tbox__first = new System.Windows.Forms.TextBox();
            this.lbl__age = new System.Windows.Forms.Label();
            this.lbl__birth = new System.Windows.Forms.Label();
            this.lbl__gender = new System.Windows.Forms.Label();
            this.tbox__age = new System.Windows.Forms.TextBox();
            this.tbox__birth = new System.Windows.Forms.TextBox();
            this.tbox__gender = new System.Windows.Forms.TextBox();
            this.lbl__contact = new System.Windows.Forms.Label();
            this.lbl__email = new System.Windows.Forms.Label();
            this.tbox__contact = new System.Windows.Forms.TextBox();
            this.tbox__email = new System.Windows.Forms.TextBox();
            this.lbl__address = new System.Windows.Forms.Label();
            this.tbox__address = new System.Windows.Forms.TextBox();
            this.btn__submit = new System.Windows.Forms.Button();
            this.btn__clear = new System.Windows.Forms.Button();
            this.tbox__viewinfo = new System.Windows.Forms.TextBox();
            this.pbox__camera = new System.Windows.Forms.PictureBox();
            this.btn__startcam = new System.Windows.Forms.Button();
            this.btn__autofill = new System.Windows.Forms.Button();
            this.lbl__qrcode = new System.Windows.Forms.Label();
            this.lbl__qrcodescan = new System.Windows.Forms.Label();
            this.lbl__infoqrcode = new System.Windows.Forms.Label();
            this.cbox__camera = new System.Windows.Forms.ComboBox();
            this.lbl__camera = new System.Windows.Forms.Label();
            this.cameratimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox__camera)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.btn__admin);
            this.panel1.Controls.Add(this.calendar__dateselect);
            this.panel1.Controls.Add(this.lbl__contacttracingform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 100);
            this.panel1.TabIndex = 8;
            // 
            // btn__admin
            // 
            this.btn__admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__admin.Font = new System.Drawing.Font("Oswald", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__admin.Location = new System.Drawing.Point(1095, 5);
            this.btn__admin.Name = "btn__admin";
            this.btn__admin.Size = new System.Drawing.Size(133, 92);
            this.btn__admin.TabIndex = 30;
            this.btn__admin.Text = "ADMIN";
            this.btn__admin.UseVisualStyleBackColor = false;
            this.btn__admin.Click += new System.EventHandler(this.btn__admin_Click);
            // 
            // calendar__dateselect
            // 
            this.calendar__dateselect.CalendarFont = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar__dateselect.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar__dateselect.Location = new System.Drawing.Point(834, 33);
            this.calendar__dateselect.Name = "calendar__dateselect";
            this.calendar__dateselect.Size = new System.Drawing.Size(232, 28);
            this.calendar__dateselect.TabIndex = 29;
            // 
            // lbl__contacttracingform
            // 
            this.lbl__contacttracingform.AutoSize = true;
            this.lbl__contacttracingform.Font = new System.Drawing.Font("Oswald", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__contacttracingform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__contacttracingform.Location = new System.Drawing.Point(3, 5);
            this.lbl__contacttracingform.Name = "lbl__contacttracingform";
            this.lbl__contacttracingform.Size = new System.Drawing.Size(601, 87);
            this.lbl__contacttracingform.TabIndex = 8;
            this.lbl__contacttracingform.Text = "Contact Tracing Form";
            // 
            // lbl__personaldeets
            // 
            this.lbl__personaldeets.AutoSize = true;
            this.lbl__personaldeets.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__personaldeets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__personaldeets.Location = new System.Drawing.Point(29, 119);
            this.lbl__personaldeets.Name = "lbl__personaldeets";
            this.lbl__personaldeets.Size = new System.Drawing.Size(211, 40);
            this.lbl__personaldeets.TabIndex = 15;
            this.lbl__personaldeets.Text = "Personal Details";
            // 
            // lbl__last
            // 
            this.lbl__last.AutoSize = true;
            this.lbl__last.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__last.Location = new System.Drawing.Point(40, 269);
            this.lbl__last.Name = "lbl__last";
            this.lbl__last.Size = new System.Drawing.Size(79, 21);
            this.lbl__last.TabIndex = 14;
            this.lbl__last.Text = "Last Name";
            // 
            // lbl__middle
            // 
            this.lbl__middle.AutoSize = true;
            this.lbl__middle.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__middle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__middle.Location = new System.Drawing.Point(40, 226);
            this.lbl__middle.Name = "lbl__middle";
            this.lbl__middle.Size = new System.Drawing.Size(94, 21);
            this.lbl__middle.TabIndex = 13;
            this.lbl__middle.Text = "Middle Name";
            // 
            // tbox__middle
            // 
            this.tbox__middle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__middle.Location = new System.Drawing.Point(140, 227);
            this.tbox__middle.Name = "tbox__middle";
            this.tbox__middle.Size = new System.Drawing.Size(153, 20);
            this.tbox__middle.TabIndex = 12;
            // 
            // tbox__last
            // 
            this.tbox__last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__last.Location = new System.Drawing.Point(140, 272);
            this.tbox__last.Name = "tbox__last";
            this.tbox__last.Size = new System.Drawing.Size(153, 20);
            this.tbox__last.TabIndex = 11;
            // 
            // lbl__first
            // 
            this.lbl__first.AutoSize = true;
            this.lbl__first.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__first.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__first.Location = new System.Drawing.Point(40, 183);
            this.lbl__first.Name = "lbl__first";
            this.lbl__first.Size = new System.Drawing.Size(81, 21);
            this.lbl__first.TabIndex = 10;
            this.lbl__first.Text = "First Name";
            // 
            // tbox__first
            // 
            this.tbox__first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__first.Location = new System.Drawing.Point(140, 183);
            this.tbox__first.Name = "tbox__first";
            this.tbox__first.Size = new System.Drawing.Size(153, 20);
            this.tbox__first.TabIndex = 9;
            // 
            // lbl__age
            // 
            this.lbl__age.AutoSize = true;
            this.lbl__age.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__age.Location = new System.Drawing.Point(331, 180);
            this.lbl__age.Name = "lbl__age";
            this.lbl__age.Size = new System.Drawing.Size(35, 21);
            this.lbl__age.TabIndex = 16;
            this.lbl__age.Text = "Age";
            // 
            // lbl__birth
            // 
            this.lbl__birth.AutoSize = true;
            this.lbl__birth.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__birth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__birth.Location = new System.Drawing.Point(331, 226);
            this.lbl__birth.Name = "lbl__birth";
            this.lbl__birth.Size = new System.Drawing.Size(95, 21);
            this.lbl__birth.TabIndex = 17;
            this.lbl__birth.Text = "Date of Birth";
            // 
            // lbl__gender
            // 
            this.lbl__gender.AutoSize = true;
            this.lbl__gender.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__gender.Location = new System.Drawing.Point(331, 272);
            this.lbl__gender.Name = "lbl__gender";
            this.lbl__gender.Size = new System.Drawing.Size(57, 21);
            this.lbl__gender.TabIndex = 18;
            this.lbl__gender.Text = "Gender";
            // 
            // tbox__age
            // 
            this.tbox__age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__age.Location = new System.Drawing.Point(437, 180);
            this.tbox__age.Name = "tbox__age";
            this.tbox__age.Size = new System.Drawing.Size(40, 20);
            this.tbox__age.TabIndex = 19;
            // 
            // tbox__birth
            // 
            this.tbox__birth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__birth.Location = new System.Drawing.Point(437, 226);
            this.tbox__birth.Name = "tbox__birth";
            this.tbox__birth.Size = new System.Drawing.Size(120, 20);
            this.tbox__birth.TabIndex = 20;
            // 
            // tbox__gender
            // 
            this.tbox__gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__gender.Location = new System.Drawing.Point(437, 272);
            this.tbox__gender.Name = "tbox__gender";
            this.tbox__gender.Size = new System.Drawing.Size(67, 20);
            this.tbox__gender.TabIndex = 21;
            // 
            // lbl__contact
            // 
            this.lbl__contact.AutoSize = true;
            this.lbl__contact.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__contact.Location = new System.Drawing.Point(645, 183);
            this.lbl__contact.Name = "lbl__contact";
            this.lbl__contact.Size = new System.Drawing.Size(92, 21);
            this.lbl__contact.TabIndex = 22;
            this.lbl__contact.Text = "Contact Info";
            // 
            // lbl__email
            // 
            this.lbl__email.AutoSize = true;
            this.lbl__email.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__email.Location = new System.Drawing.Point(645, 224);
            this.lbl__email.Name = "lbl__email";
            this.lbl__email.Size = new System.Drawing.Size(45, 21);
            this.lbl__email.TabIndex = 23;
            this.lbl__email.Text = "Email";
            // 
            // tbox__contact
            // 
            this.tbox__contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__contact.Location = new System.Drawing.Point(743, 183);
            this.tbox__contact.Name = "tbox__contact";
            this.tbox__contact.Size = new System.Drawing.Size(159, 20);
            this.tbox__contact.TabIndex = 24;
            // 
            // tbox__email
            // 
            this.tbox__email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__email.Location = new System.Drawing.Point(743, 224);
            this.tbox__email.Name = "tbox__email";
            this.tbox__email.Size = new System.Drawing.Size(228, 20);
            this.tbox__email.TabIndex = 25;
            // 
            // lbl__address
            // 
            this.lbl__address.AutoSize = true;
            this.lbl__address.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__address.Location = new System.Drawing.Point(645, 268);
            this.lbl__address.Name = "lbl__address";
            this.lbl__address.Size = new System.Drawing.Size(63, 21);
            this.lbl__address.TabIndex = 26;
            this.lbl__address.Text = "Address";
            // 
            // tbox__address
            // 
            this.tbox__address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.tbox__address.Location = new System.Drawing.Point(743, 269);
            this.tbox__address.Name = "tbox__address";
            this.tbox__address.Size = new System.Drawing.Size(456, 20);
            this.tbox__address.TabIndex = 27;
            // 
            // btn__submit
            // 
            this.btn__submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__submit.Font = new System.Drawing.Font("Oswald", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__submit.Location = new System.Drawing.Point(1038, 119);
            this.btn__submit.Name = "btn__submit";
            this.btn__submit.Size = new System.Drawing.Size(150, 60);
            this.btn__submit.TabIndex = 28;
            this.btn__submit.Text = "Submit";
            this.btn__submit.UseVisualStyleBackColor = false;
            this.btn__submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn__clear
            // 
            this.btn__clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__clear.Font = new System.Drawing.Font("Oswald", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__clear.Location = new System.Drawing.Point(1038, 193);
            this.btn__clear.Name = "btn__clear";
            this.btn__clear.Size = new System.Drawing.Size(150, 60);
            this.btn__clear.TabIndex = 29;
            this.btn__clear.Text = "Clear";
            this.btn__clear.UseVisualStyleBackColor = false;
            this.btn__clear.Click += new System.EventHandler(this.btn__clear_Click);
            // 
            // tbox__viewinfo
            // 
            this.tbox__viewinfo.AcceptsReturn = true;
            this.tbox__viewinfo.AcceptsTab = true;
            this.tbox__viewinfo.BackColor = System.Drawing.Color.Navy;
            this.tbox__viewinfo.Font = new System.Drawing.Font("News Cycle", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox__viewinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.tbox__viewinfo.Location = new System.Drawing.Point(36, 466);
            this.tbox__viewinfo.Multiline = true;
            this.tbox__viewinfo.Name = "tbox__viewinfo";
            this.tbox__viewinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox__viewinfo.Size = new System.Drawing.Size(410, 247);
            this.tbox__viewinfo.TabIndex = 30;
            // 
            // pbox__camera
            // 
            this.pbox__camera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox__camera.BackgroundImage")));
            this.pbox__camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox__camera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbox__camera.Location = new System.Drawing.Point(897, 427);
            this.pbox__camera.Name = "pbox__camera";
            this.pbox__camera.Size = new System.Drawing.Size(291, 286);
            this.pbox__camera.TabIndex = 31;
            this.pbox__camera.TabStop = false;
            // 
            // btn__startcam
            // 
            this.btn__startcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__startcam.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__startcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__startcam.Location = new System.Drawing.Point(770, 665);
            this.btn__startcam.Name = "btn__startcam";
            this.btn__startcam.Size = new System.Drawing.Size(121, 48);
            this.btn__startcam.TabIndex = 32;
            this.btn__startcam.Text = "Start";
            this.btn__startcam.UseVisualStyleBackColor = false;
            this.btn__startcam.Click += new System.EventHandler(this.btn__startcam_Click);
            // 
            // btn__autofill
            // 
            this.btn__autofill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(65)))), ((int)(((byte)(96)))));
            this.btn__autofill.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__autofill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.btn__autofill.Location = new System.Drawing.Point(452, 665);
            this.btn__autofill.Name = "btn__autofill";
            this.btn__autofill.Size = new System.Drawing.Size(121, 48);
            this.btn__autofill.TabIndex = 33;
            this.btn__autofill.Text = "Fill";
            this.btn__autofill.UseVisualStyleBackColor = false;
            this.btn__autofill.Click += new System.EventHandler(this.btn__autofill_Click);
            // 
            // lbl__qrcode
            // 
            this.lbl__qrcode.AutoSize = true;
            this.lbl__qrcode.Font = new System.Drawing.Font("Oswald", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__qrcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__qrcode.Location = new System.Drawing.Point(29, 372);
            this.lbl__qrcode.Name = "lbl__qrcode";
            this.lbl__qrcode.Size = new System.Drawing.Size(117, 40);
            this.lbl__qrcode.TabIndex = 34;
            this.lbl__qrcode.Text = "QR Code";
            // 
            // lbl__qrcodescan
            // 
            this.lbl__qrcodescan.AutoSize = true;
            this.lbl__qrcodescan.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__qrcodescan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__qrcodescan.Location = new System.Drawing.Point(790, 468);
            this.lbl__qrcodescan.Name = "lbl__qrcodescan";
            this.lbl__qrcodescan.Size = new System.Drawing.Size(101, 21);
            this.lbl__qrcodescan.TabIndex = 35;
            this.lbl__qrcodescan.Text = "Scan QR Code";
            // 
            // lbl__infoqrcode
            // 
            this.lbl__infoqrcode.AutoSize = true;
            this.lbl__infoqrcode.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__infoqrcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__infoqrcode.Location = new System.Drawing.Point(452, 468);
            this.lbl__infoqrcode.Name = "lbl__infoqrcode";
            this.lbl__infoqrcode.Size = new System.Drawing.Size(96, 21);
            this.lbl__infoqrcode.TabIndex = 36;
            this.lbl__infoqrcode.Text = "QR Code Info";
            // 
            // cbox__camera
            // 
            this.cbox__camera.BackColor = System.Drawing.Color.Navy;
            this.cbox__camera.Font = new System.Drawing.Font("News Cycle", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox__camera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.cbox__camera.FormattingEnabled = true;
            this.cbox__camera.Location = new System.Drawing.Point(897, 397);
            this.cbox__camera.Name = "cbox__camera";
            this.cbox__camera.Size = new System.Drawing.Size(291, 27);
            this.cbox__camera.TabIndex = 37;
            // 
            // lbl__camera
            // 
            this.lbl__camera.AutoSize = true;
            this.lbl__camera.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__camera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(206)))), ((int)(((byte)(218)))));
            this.lbl__camera.Location = new System.Drawing.Point(830, 399);
            this.lbl__camera.Name = "lbl__camera";
            this.lbl__camera.Size = new System.Drawing.Size(61, 21);
            this.lbl__camera.TabIndex = 38;
            this.lbl__camera.Text = "Camera";
            // 
            // cameratimer
            // 
            this.cameratimer.Interval = 1000;
            this.cameratimer.Tick += new System.EventHandler(this.cameratimer_Tick);
            // 
            // form__contacttracingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1240, 758);
            this.Controls.Add(this.lbl__camera);
            this.Controls.Add(this.cbox__camera);
            this.Controls.Add(this.lbl__infoqrcode);
            this.Controls.Add(this.lbl__qrcodescan);
            this.Controls.Add(this.lbl__qrcode);
            this.Controls.Add(this.btn__autofill);
            this.Controls.Add(this.btn__startcam);
            this.Controls.Add(this.pbox__camera);
            this.Controls.Add(this.tbox__viewinfo);
            this.Controls.Add(this.btn__clear);
            this.Controls.Add(this.btn__submit);
            this.Controls.Add(this.tbox__address);
            this.Controls.Add(this.lbl__address);
            this.Controls.Add(this.tbox__email);
            this.Controls.Add(this.tbox__contact);
            this.Controls.Add(this.lbl__email);
            this.Controls.Add(this.lbl__contact);
            this.Controls.Add(this.tbox__gender);
            this.Controls.Add(this.tbox__birth);
            this.Controls.Add(this.tbox__age);
            this.Controls.Add(this.lbl__gender);
            this.Controls.Add(this.lbl__birth);
            this.Controls.Add(this.lbl__age);
            this.Controls.Add(this.lbl__personaldeets);
            this.Controls.Add(this.lbl__last);
            this.Controls.Add(this.lbl__middle);
            this.Controls.Add(this.tbox__middle);
            this.Controls.Add(this.tbox__last);
            this.Controls.Add(this.lbl__first);
            this.Controls.Add(this.tbox__first);
            this.Controls.Add(this.panel1);
            this.Name = "form__contacttracingform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form__contacttracingform_FormClosing);
            this.Load += new System.EventHandler(this.form__contacttracingform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox__camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl__contacttracingform;
        private System.Windows.Forms.Label lbl__personaldeets;
        private System.Windows.Forms.Label lbl__last;
        private System.Windows.Forms.Label lbl__middle;
        private System.Windows.Forms.TextBox tbox__middle;
        private System.Windows.Forms.TextBox tbox__last;
        private System.Windows.Forms.Label lbl__first;
        private System.Windows.Forms.TextBox tbox__first;
        private System.Windows.Forms.Label lbl__age;
        private System.Windows.Forms.Label lbl__birth;
        private System.Windows.Forms.Label lbl__gender;
        private System.Windows.Forms.TextBox tbox__age;
        private System.Windows.Forms.TextBox tbox__birth;
        private System.Windows.Forms.TextBox tbox__gender;
        private System.Windows.Forms.Label lbl__contact;
        private System.Windows.Forms.Label lbl__email;
        private System.Windows.Forms.TextBox tbox__contact;
        private System.Windows.Forms.TextBox tbox__email;
        private System.Windows.Forms.Label lbl__address;
        private System.Windows.Forms.TextBox tbox__address;
        private System.Windows.Forms.Button btn__submit;
        private System.Windows.Forms.DateTimePicker calendar__dateselect;
        private System.Windows.Forms.Button btn__clear;
        private System.Windows.Forms.Button btn__admin;
        private System.Windows.Forms.TextBox tbox__viewinfo;
        private System.Windows.Forms.PictureBox pbox__camera;
        private System.Windows.Forms.Button btn__startcam;
        private System.Windows.Forms.Button btn__autofill;
        private System.Windows.Forms.Label lbl__qrcode;
        private System.Windows.Forms.Label lbl__qrcodescan;
        private System.Windows.Forms.Label lbl__infoqrcode;
        private System.Windows.Forms.ComboBox cbox__camera;
        private System.Windows.Forms.Label lbl__camera;
        private System.Windows.Forms.Timer cameratimer;
    }
}