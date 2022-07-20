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
    public partial class form__allrecs : Form
    {
        public form__allrecs()
        {
            InitializeComponent();
            
            var allrecs = Directory.GetFiles(@"C:\Users\joy\source\repos\contact tracing\data\all records");
            foreach (var viewall in allrecs)
            {
                string viewrecords = File.ReadAllText(viewall);
                lbl__underscore.Text = lbl__underscore.Text + "\n" + viewrecords + "\n";
            }
        }

        private void lbl__recs_Click(object sender, EventArgs e)
        {

        }
    }
}
