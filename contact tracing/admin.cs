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
    public partial class form__admin : Form
    {
        public form__admin()
        {
            InitializeComponent();
        }

        private void btn__select_Click(object sender, EventArgs e)
        {
            List<string> alldates = new List<string>();
            string date = __datepick.Text;
            int selecteddate = 0;
            var files = Directory.EnumerateFiles(@"C:\Users\joy\source\repos\contact tracing\data\all records");
            foreach (string file in files)
            {
                string content = File.ReadAllText(file);
                if (content.Contains(date))
                {
                    alldates.Add(content);
                    selecteddate++;
                    continue;
                }
            }
            if (selecteddate == 0)
            {
                MessageBox.Show("Searching records...");
                MessageBox.Show("No records on the selected date");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\joy\source\repos\contact tracing\data\by date\this date.txt");
                foreach (string content in alldates)
                {

                    file.WriteLine(content);
                }
                file.Close();

                MessageBox.Show("Searching records...");
                MessageBox.Show("There are " + selecteddate + " record(s) on the selected date");
                
                if (MessageBox.Show("Proceed to view the records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Sorting out...");
                    MessageBox.Show("Success");
                    form__bydate view = new form__bydate();
                    view.ShowDialog();
                }
                
            }

        }
    }
}
