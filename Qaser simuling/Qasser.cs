using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qaser_simuling
{
    public partial class Qasser : Form
    {

        List<Label> plainLatter;           // this used for stor all Plain Lable in the desin 
        List<Label> cipherLatter;          // this used for stor all Cipher Lable in the desin
        Dictionary<string, int> example;   // for saving the some example if the user need to use
        int pointer = 0;                   // the pointer to point the char in plain text or cipher text 
        int ii = 0;                        // for pointing

        //construct 
        public Qasser()
        {
            InitializeComponent();
            //initialize the label in the Lists
            plainLatter = new List<Label> { pA, pB, pC, pd, pE, pF, pG, pH, pI, pJ, pK, pL, pM, pN, pO, pP, pQ, pR, pS, pT, pU, pV, pW, pX, pY, pZ };
            cipherLatter = new List<Label> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26 };
            //stor the examles
            example = new Dictionary<string, int> { { "welcome to my programm", 6 }, { "meet me after the toga party", 3 }, { "is a substusion cipher", 18 },{"university of zakho",23}};
        }

        #region Servises
        private void changeColor(List<Label> x, Color c)
        {
            foreach (var item in x)
                item.BackColor = c;
        }


        private void controlState(bool x)
        {
            txtCipher.ReadOnly = !x;
            txtPlan.ReadOnly = !x;
            key.Enabled = x;
            en.Enabled = x;
            de.Enabled = x;
            button1.Enabled = x;
            txtShow.Visible = !x;
            cipherShow.Visible = !x;
            button2.Enabled = !x;
            btnPlayEn.Enabled = x;
            btnStopDe.Enabled = !x;
            attack.Enabled = x;
            btnEx.Enabled = x;
            button3.Enabled = x;
        }

        #endregion

        #region Key changing
        private string getStringKey(int key)
        {
            string skey = "";
            for (int i = 0; i < 26; i++)
                skey += Convert.ToChar((i + key) % 26 + 65);
            return skey;
        }

        private void setKey(int k)
        {
            string key = getStringKey(k);
            for (int i = 0; i < 26; i++)
                cipherLatter[i].Text = key[i].ToString();
        }

        private void key_SelectedIndexChanged(object sender, EventArgs e)
        {
            setKey(int.Parse(key.SelectedItem.ToString()));
        }
        #endregion

        #region button events
        //the click event for encription Button 
        private void en_Click(object sender, EventArgs e)
        {
            if (txtPlan.Text == "")
                MessageBox.Show("Please Enter Plain Text!");
            else
                txtCipher.Text = Algorithms.encriptionQaser(txtPlan.Text, Convert.ToInt32(key.SelectedItem));
        }

        //the click event for decription Button 
        private void de_Click(object sender, EventArgs e)
        {
            if (txtCipher.Text == "")
                MessageBox.Show("Please Enter Cipher Text!");
            else
                txtPlan.Text = Algorithms.decriptionQaser(txtCipher.Text, Convert.ToInt32(key.SelectedItem));
        }

        //the click event for Play decription Button
        private void button2_Click(object sender, EventArgs e)
        {
            controlState(true);
            show.Stop();
            travel.Stop();
            changeColor(plainLatter, Color.Goldenrod);
            changeColor(cipherLatter, Color.DarkOrange);
            pont.Hide();
        }

        //the click event for Play encription Button 
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlan.Text == "")
            {
                MessageBox.Show("Please Enter Plain Text!");
                return;
            }
            pointer = -1;
            txtShow.Text = "";
            cipherShow.Text = "";
            txtCipher.Text = "";
            controlState(false);
            btnStopDe.Enabled = false;
            show.Start();

        }

        private void btnStopDe_Click(object sender, EventArgs e)
        {
            controlState(true);
            showDe.Stop();
            travelDe.Stop();
            changeColor(plainLatter, Color.Goldenrod);
            changeColor(cipherLatter, Color.DarkOrange);
            pointDe.Hide();
        }

        private void attack_Click(object sender, EventArgs e)
        {
            if (txtCipher.Text == "")
                return;
            AttackQaser.Message = txtCipher.Text;
            new AttackQaser().Show();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int num = rn.Next(0, example.Count);
            txtPlan.Text = example.ElementAt(num).Key;
            key.SelectedIndex = example.ElementAt(num).Value;
        }

        //show Frequnce
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCipher.Text == "")
            {
                MessageBox.Show("Please Enter Cipher Text");
                return;
            }
            AnalizeShow.message = txtCipher.Text;
            AnalizeShow frm = new AnalizeShow();
            frm.Show();
        }

        //text change the acsept ony a-z
        private void txtPlan_TextChanged(object sender, EventArgs e)
        {
            TextBox x = (TextBox)sender;
            string removed = "";
            foreach (var item in x.Text)
                if (item >= 'a' && item <= 'z')
                    removed += item;
            x.Text = removed;
            x.Select(removed.Length, 0);
        }

        //closing event
        private void Qasser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        //set speed
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            show.Interval = trackBar1.Value;
            showDe.Interval = trackBar1.Value;
        }

        #endregion

        #region timer Tick
        //the Trick event for play encription Button 
        private void show_Tick(object sender, EventArgs e)
        {
            if (txtPlan.Text == "")
            {
                MessageBox.Show("Please Enter Plain Text!");
                show.Enabled = false;
            }
            else
            {
                if (pointer < txtPlan.Text.Length - 1)
                {
                    pointer++;
                    if (txtPlan.Text[pointer] >= 'a' && txtPlan.Text[pointer] <= 'z')
                    {
                        show.Stop();
                        ii = 0;
                        travel.Start();
                        changeColor(plainLatter, Color.Goldenrod);
                        changeColor(cipherLatter, Color.DarkOrange);
                        pont.Hide();
                        txtShow.Text = txtPlan.Text[pointer].ToString();
                        cipherShow.Hide();
                    }

                }
                else
                {
                    show.Stop();
                    controlState(true);
                    changeColor(plainLatter, Color.Goldenrod);
                    changeColor(cipherLatter, Color.DarkOrange);
                    pont.Hide();
                }
            }

        }



        //the Tick event for Play decription Button
        private void showDe_Tick(object sender, EventArgs e)
        {
            if (pointer < txtCipher.Text.Length - 1)
            {
                pointer++;
                if (txtCipher.Text[pointer] >= 'a' && txtCipher.Text[pointer] <= 'z')
                {


                    showDe.Stop();
                    ii = 0;
                    travelDe.Start();
                    changeColor(plainLatter, Color.Goldenrod);
                    changeColor(cipherLatter, Color.DarkOrange);
                    pointDe.Hide();
                    cipherShow.Text = txtCipher.Text[pointer].ToString();
                    txtShow.Hide();
                }

            }
            else
            {
                showDe.Stop();
                controlState(true);
                changeColor(plainLatter, Color.Goldenrod);
                changeColor(cipherLatter, Color.DarkOrange);
                pointDe.Hide();
            }
        }

        private void btnPlayEn_Click(object sender, EventArgs e)
        {
            if (txtCipher.Text == "")
            {
                MessageBox.Show("Please Enter Cipher Text!");
                return;
            }
            pointer = -1;
            txtShow.Text = "";
            cipherShow.Text = "";
            txtPlan.Text = "";

            controlState(false);
            button2.Enabled = false;

            showDe.Start();
        }



        private void travel_Tick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtPlan.Text[pointer]) - 97;
            if (ii <= x)
            {
                changeColor(plainLatter, Color.Goldenrod);
                plainLatter[ii].BackColor = Color.Black;
                ii++;

            }
            else
            {
                cipherShow.Show();
                pont.Show();
                string cipher = Algorithms.encriptionQaser(txtPlan.Text[pointer].ToString(), Convert.ToInt32(key.SelectedItem));
                cipherShow.Text = cipher;
                txtCipher.Text += cipher;
                plainLatter[x].BackColor = Color.Red;
                cipherLatter[x].BackColor = Color.Green;
                pont.Location = new Point(plainLatter[x].Location.X, pont.Location.Y);
                travel.Stop();
                show.Start();
            }
        }

        private void travelDe_Tick(object sender, EventArgs e)
        {
            string plain = Algorithms.decriptionQaser(txtCipher.Text[pointer].ToString(), Convert.ToInt32(key.SelectedItem));
            int x = Convert.ToInt32(plain[0]) - 97;
            if (ii <= x)
            {
                changeColor(cipherLatter, Color.DarkOrange);
                cipherLatter[ii].BackColor = Color.Black;
                ii++;
            }
            else
            {
                txtShow.Show();
                pointDe.Show();
                txtShow.Text = plain;
                txtPlan.Text += plain;
                plainLatter[x].BackColor = Color.Red;
                cipherLatter[x].BackColor = Color.Green;
                pointDe.Location = new Point(plainLatter[x].Location.X, pont.Location.Y);
                travelDe.Stop();
                showDe.Start();
            }
        }

        #endregion

    }

}


