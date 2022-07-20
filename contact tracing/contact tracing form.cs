using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace contact_tracing
{
    public partial class form__contacttracingform : Form
    {
        public form__contacttracingform()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;

        private void ClearTextBoxes()
        {
            Action < Control.ControlCollection > func = null;
            func = (controls) =>

                {
                    foreach (Control control in controls)
                        if (control is TextBox)
                            (control as TextBox).Clear();
                        else
                            func(control.Controls);
                };

            func(Controls);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\joy\source\repos\contact tracing\data\all records\" + tbox__last.Text + ", " + tbox__first.Text + ", " + tbox__middle.Text + ".txt", true);

            file.WriteLine("");
            file.WriteLine("Personal Details");
            file.WriteLine("");
            file.WriteLine("Date: " + calendar__dateselect.Text);
            file.WriteLine("");
            file.WriteLine("First Name: " + tbox__first.Text);
            file.WriteLine("Middle Name: " + tbox__middle.Text);
            file.WriteLine("Last Name: " + tbox__last.Text);
            file.WriteLine("Age: " + tbox__age.Text);
            file.WriteLine("Date of Birth: " + tbox__birth.Text);
            file.WriteLine("Gender: " + tbox__gender.Text);
            file.WriteLine("Contact Info: " + tbox__contact.Text);
            file.WriteLine("Email: " + tbox__email.Text);
            file.WriteLine("Address: " + tbox__address.Text);
            
            file.Close();

            MessageBox.Show("Thanks for filling out the form!", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Always wear your facemask. Be careful. ", "Contact Tracing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn__clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btn__admin_Click(object sender, EventArgs e)
        {
            form__adminlogin show = new form__adminlogin();
            show.ShowDialog();
        }

        private void btn__startcam_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[cbox__camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevie_NewFrame;
            captureDevice.Start();
            cameratimer.Start();
        }

        private void CaptureDevie_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbox__camera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void form__contacttracingform_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter_info in filter)
                cbox__camera.Items.Add(filter_info.Name);
            cbox__camera.SelectedIndex = 0;
        }

        private void form__contacttracingform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void cameratimer_Tick(object sender, EventArgs e)
        {

            if (pbox__camera.Image != null)
            {
                BarcodeReader QRcode = new BarcodeReader();
                Result result = QRcode.Decode((Bitmap)pbox__camera.Image);
                if (result != null)
                {
                    tbox__viewinfo.Text = result.ToString();
                    cameratimer.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
    }
}
