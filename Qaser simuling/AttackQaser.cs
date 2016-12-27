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
    public partial class AttackQaser : Form
    {
        public static string Message;
        int key = 0;
        public AttackQaser()
        {
            InitializeComponent();
        }

        private void AttackQaser_Load(object sender, EventArgs e)
        {
            label1.Text = Message;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnNext.Show();
            btnStart.Hide();
            ms.Show();
            keyShow.Show();
            label3.Show();
            label4.Show();
            btnBack.Show();
            setData();
        }


        private void setData(){
            keyShow.Text = key.ToString();
            ms.Text = Algorithms.decriptionQaser(Message, key);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            key = (key + 1) % 26;
            setData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            key = (key - 1) % 26;
            if (key < 0)
                key = 25;
            setData();
        }

    }
}
