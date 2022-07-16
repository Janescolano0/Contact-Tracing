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

namespace contact_tracing
{
    public partial class form__contacttracingform : Form
    {
        public form__contacttracingform()
        {
            InitializeComponent();
        }

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
            StreamWriter file = new StreamWriter(@"C:\Users\joy\source\repos\contact tracing\data\" + tbox__last.Text + ", " + tbox__first.Text + ", " + tbox__middle.Text + ".txt", true);

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
    }
}
