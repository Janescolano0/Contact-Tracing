using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing
{
    public partial class form__adminlogin : Form
    {
        public form__adminlogin()
        {
            InitializeComponent();
        }

        private void btn__login_Click(object sender, EventArgs e)
        {
            if (tbox__user.Text == "janescolano" && tbox__pass.Text == "1010")
            {
                form__admin show = new form__admin();
                show.ShowDialog();
            }

            else
            {
                MessageBox.Show("Login failed. Please try again.");
                tbox__user.Clear();
                tbox__pass.Clear();
                lbl__user.Focus();
            }
        }

        private void cbox__showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox__showpass.Checked)
            {
                tbox__pass.UseSystemPasswordChar = false;
            }

            else
            {
                tbox__pass.UseSystemPasswordChar = true;
            }
        }
    }
}
