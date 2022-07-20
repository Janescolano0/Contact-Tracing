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
    public partial class form__bydate : Form
    {
        public form__bydate()
        {
            InitializeComponent();
            var selecteddatefile = Directory.GetFiles(@"C:\Users\joy\source\repos\contact tracing\data\by date\");
            foreach (string file in selecteddatefile)
            {
                string selectdate = File.ReadAllText(file);
                lbl__underscore.Text = lbl__underscore.Text + selectdate + "\n";
            }
        }

        private void lbl__recs_Click(object sender, EventArgs e)
        {

        }

        private void lbl__underscore_Click(object sender, EventArgs e)
        {

        }
    }
}
