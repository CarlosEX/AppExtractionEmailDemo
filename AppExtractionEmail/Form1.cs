using System;
using System.Windows.Forms;
using CisonExtractionEmail;

namespace AppExtractionEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] listOfEmails = ExtractionEmail.Extract(textBox1.Text).Split(',');

            dataGridView1.Rows.Clear();

            foreach (string email in listOfEmails)
            {
                dataGridView1.Rows.Add(email);
            }
            
        }
    }
}
