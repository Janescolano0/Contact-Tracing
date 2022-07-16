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
    public partial class form__contacttracing : Form
    {
        public form__contacttracing()
        {
            InitializeComponent();
        }

        private void btn__form_Click(object sender, EventArgs e)
        {
            form__contacttracingform show = new form__contacttracingform();
            show.ShowDialog();
        }
    }
}
