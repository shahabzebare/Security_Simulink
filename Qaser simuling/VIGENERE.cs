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
    public partial class VIGENERE : Form
    {
        private Label [,] lb = new Label[26,26];
        private Label [] plainLaters = new Label[26];
        private Label[] cipherLaters = new Label[26];

        private Dictionary<string, string> exam;

        // pointers
        int plainPointer = 0;
        int keyPointer = 0;
        public VIGENERE()
        {
            InitializeComponent();

            #region insert custom desgin
            int xx = 31;
            for (int i = 0; i < 26; i++)
            {
                plainLaters[i] = new Label();
                plainLaters[i].Name = "x";
                plainLaters[i].Location = new System.Drawing.Point(xx, 15);
                plainLaters[i].Size = new System.Drawing.Size(15, 15); ;
                plainLaters[i].Text = Convert.ToChar(i + 97).ToString();
                plainLaters[i].BackColor = Color.Goldenrod;
                plainLaters[i].ForeColor = Color.White;
                this.Controls.Add(plainLaters[i]);
                xx += 16;
            }

            int yy = 31;
            for (int i = 0; i < 26; i++)
            {
                cipherLaters[i] = new Label();
                cipherLaters[i].Name = "x";
                cipherLaters[i].Location = new System.Drawing.Point(15, yy);
                cipherLaters[i].Size = new System.Drawing.Size(15, 15); ;
                cipherLaters[i].Text = Convert.ToChar(i + 97).ToString();
                cipherLaters[i].BackColor = Color.DarkOrange;
                cipherLaters[i].ForeColor = Color.White;
                this.Controls.Add(cipherLaters[i]);
                yy += 16;
            }

            int y = 31;
            for (int i = 0; i < 26; i++)
            {
                int x = 31;
                for (int j = 0; j < 26; j++)
                {
                    lb[i, j] = new Label();
                    lb[i, j].Name = "x"+i+j;
                    lb[i, j].Location = new System.Drawing.Point(x, y);
                    lb[i, j].Size = new System.Drawing.Size(15, 15); ;
                    lb[i, j].Text = Convert.ToChar((i + j )% 26 + 97).ToString();
                    lb[i, j].BackColor = Color.Black;
                    lb[i, j].ForeColor = Color.White;
                   // lb[i, j].Click += new System.EventHandler(this.label1_Click);

                    this.Controls.Add(lb[i, j]);
                    x += 16;
                }
                y += 16;
            }
            #endregion


            #region intialize the examples
            exam = new Dictionary<string, string> { 
                    {"university of zakho","security"},
                    {"send help soon","computer"},
                    {"we are discovered save yourself","deceptive"}
            };
            #endregion

        }

        private void VIGENERE_Load(object sender, EventArgs e)
        {

        }

        private void en_Click(object sender, EventArgs e)
        {
            if (txtPlan.Text=="")
            {
                MessageBox.Show("Please Enter Plain Text!");
                return;
            }
            if (txtKey.Text == "")
            {
                MessageBox.Show("Please Enter Key!");
                return;
            }

            txtCipher.Text = Algorithms.encriptionVeg(txtPlan.Text,txtKey.Text);

        }

        private void de_Click(object sender, EventArgs e)
        {
            if (txtCipher.Text=="")
            {
                MessageBox.Show("Please Enter cipher Text!");
                return;
            }
            if (txtKey.Text == "")
            {
                MessageBox.Show("Please Enter Key!");
                return;
            }

            txtPlan.Text = Algorithms.decriptionVeg(txtCipher.Text, txtKey.Text);

        }

        //play encription
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlan.Text == "")
            {
                MessageBox.Show("Please Enter Plain Text!");
                return;
            }
            if (txtKey.Text == "")
            {
                MessageBox.Show("Please Enter Key!");
                return;
            }
            txtCipher.Text = "";
            
            plainPointer = 0;
            keyPointer = 0;

            controlState(false);
            btnStopDe.Enabled = false;
            tmEncription.Start();

        }

        //play timer encription
        private void tmEncription_Tick(object sender, EventArgs e)
        {
            string plain = txtPlan.Text;
            if (plain.Length > plainPointer)
            {
                if (plain[plainPointer]>='a' && plain[plainPointer]<='z')
                {
                    lblPointerEn.Show();
                    tmClear();
                    int k = Convert.ToInt32(txtKey.Text[keyPointer])-97;
                    int p = Convert.ToInt32(plain[plainPointer])-97;
                    lblPlainShow.Text = plain[plainPointer].ToString();
                    lblShowKey.Text = txtKey.Text[keyPointer].ToString();
                    //
                    string cipherText = Algorithms.encriptionVeg(plain[plainPointer].ToString(),txtKey.Text[keyPointer].ToString());
                    lblCipherShow.Text = cipherText;
                    txtCipher.Text += cipherText;

                    plainLaters[p].BackColor = Color.Red;
                    for (int i = 0; i < k; i++)
                        lb[i, p].BackColor = Color.Red;
                    cipherLaters[k].BackColor = Color.Magenta;
                    for (int i = 0; i < p; i++)
                        lb[k, i].BackColor = Color.Magenta;
                    lb[k, p].BackColor = Color.Green;

                    keyPointer = (keyPointer + 1) % txtKey.Text.Length;
                    
                }
                plainPointer++;
            }
            else
            {
                controlState(true);
                lblPointerEn.Hide();
                tmClear();
                tmEncription.Stop();
            }
        }

        private void tmClear() {
            for (int i = 0; i < 26; i++)
            {
                cipherLaters[i].BackColor = Color.DarkOrange;
                plainLaters[i].BackColor = Color.Goldenrod;

                for (int j = 0; j < 26; j++)
                {
                    lb[i, j].BackColor = Color.Black;
                }
            }
        }

        private void lblShowKey_Click(object sender, EventArgs e)
        {

        }


        private void controlState(bool x)
        {
            txtCipher.ReadOnly = !x;
            txtPlan.ReadOnly = !x;
            txtKey.ReadOnly = !x;
            en.Enabled = x;
            de.Enabled = x;
            button1.Enabled = x;
            lblPlainShow.Visible = !x;
            lblPlainShow.Text = "";
            lblCipherShow.Visible = !x;
            lblCipherShow.Text = "";
            lblShowKey.Visible = !x;
            lblShowKey.Text = "";
            button2.Enabled = !x;
            btnPlayEn.Enabled = x;
            btnStopDe.Enabled = !x;

            button3.Enabled = x;
            button4.Enabled = x;
        }

        private void tmDecription_Tick(object sender, EventArgs e)
        {
            string plain = txtCipher.Text;
            if (plain.Length > plainPointer)
            {
                if (plain[plainPointer] >= 'a' && plain[plainPointer] <= 'z')
                {
                    lblPointerDe.Show();
                    tmClear();
                    int k = Convert.ToInt32(txtKey.Text[keyPointer]) - 97;
                    int p = Convert.ToInt32(plain[plainPointer]) - 97;
                    lblCipherShow.Text = plain[plainPointer].ToString();
                    lblShowKey.Text = txtKey.Text[keyPointer].ToString();
                    //
                    string plainText = Algorithms.decriptionVeg(plain[plainPointer].ToString(), txtKey.Text[keyPointer].ToString());
                    lblPlainShow.Text = plainText;
                    txtPlan.Text += plainText;
                    int c = Convert.ToInt32(plainText[0])-97;
                    plainLaters[c].BackColor = Color.Red;
                    for (int i = 0; i < k; i++)
                        lb[i, c].BackColor = Color.Green;
                    cipherLaters[k].BackColor = Color.Magenta;
                    for (int i = 0; i < c; i++)
                        lb[k, i].BackColor = Color.Magenta;
                    lb[k, c].BackColor = Color.Green;

                    keyPointer = (keyPointer + 1) % txtKey.Text.Length;

                }
                plainPointer++;
            }
            else
            {
                controlState(true);
                lblPointerDe.Hide();
                tmClear();
                tmDecription.Stop();
            }
        }

        private void btnPlayEn_Click(object sender, EventArgs e)
        {
            if (txtCipher.Text == "")
            {
                MessageBox.Show("Please Enter Cipher Text!");
                return;
            }
            if (txtKey.Text == "")
            {
                MessageBox.Show("Please Enter Key!");
                return;
            }
            txtPlan.Text = "";

            plainPointer = 0;
            keyPointer = 0;

            controlState(false);

            button2.Enabled = false;

            tmDecription.Start();
        }

        private void btnStopDe_Click(object sender, EventArgs e)
        {
            controlState(true);
            lblPointerDe.Hide();
            tmClear();
            tmDecription.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlState(true);
            lblPointerEn.Hide();
            tmClear();
            tmEncription.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tmEncription.Interval = trackBar1.Value;
            tmDecription.Interval = trackBar1.Value;
        }

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

        private void VIGENERE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        //random example
        private void button4_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int x = ran.Next(0, exam.Count);
            txtPlan.Text = exam.ElementAt(x).Key;
            txtKey.Text = exam.ElementAt(x).Value; 
        }

    }
}
