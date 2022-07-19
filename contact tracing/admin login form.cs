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
            if (tbox__user.Text == "janescolano" && tbox__pass.Text == "ganda")
            {
                new form__admin().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Unsuccessful login attempt. Wrong username or password.");
                tbox__user.Clear();
                tbox__pass.Clear();
                lbl__user.Focus();
            }
        }
    }
}
