using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qaser_simuling
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
           Time.Text= DateTime.Now.ToLongTimeString();
           Datee.Text = DateTime.Now.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Qasser().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new monoAlpahaBit().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VIGENERE().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new playfair().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new showPdf().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void date_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
