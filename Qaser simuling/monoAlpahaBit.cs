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
    public partial class monoAlpahaBit : Form
    {

        string alpha = "abcdefghijklmnopqrstuvwxyz";
        char[] key = new char[26];
        List<TextBox> ShowKey;
        List<Label> plainLatter;  

        int pointer = 0;                   // the pointer to point the char in plain text or cipher text 
        int ii = 0;                        // for pointing

        List<string> exam;


        public monoAlpahaBit()
        {
            InitializeComponent();
            //initialize the label in the Lists
            plainLatter = new List<Label> { pA, pB, pC, pd, pE, pF, pG, pH, pI, pJ, pK, pL, pM, pN, pO, pP, pQ, pR, pS, pT, pU, pV, pW, pX, pY, pZ };
            ShowKey = new List<TextBox>{ c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26 };

            #region Example Init
            exam = new List<string> { 
                "I f we w i s h t o r e p l a c e l e t t e r s",
                "universtiy of zakho",
                "we are discovered save yourself",
                "MEET ME AFTER THE TOGA PARTY"
            };

            #endregion

            clearAll();
            genrateKey();
           
        }


        #region create&Genrate delete
        private void c26_TextChanged(object sender, EventArgs e)
        {
            TextBox n = (TextBox)sender;
            string name = n.Name;
            name = name.Replace("c", "");
            int index = int.Parse(name);
            string txt = n.Text;
            try
            {
                if (!(txt[0] >= 'a' && txt[0] <= 'z'))
                {
                    n.Text = "";
                    return;
                }

                if (!notInKey(txt[0], index - 1))
                {
                    n.Text = "";
                    return;
                }

                key[index - 1] = txt[0];
            }
            catch (Exception ex) { }
        }


        private bool notInKey(char a, int x)
        {

            bool flag = true;

            for (int i = 0; i < 26; i++)
            {
                if (i == x)
                    continue;
                if (a == key[i])
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }


        private void genrateKey()
        {

            Random r = new Random();
            int x = 0;
            while (x < 26)
            {
                char n = alpha[r.Next(26)];
                bool flag = true;
                for (int i = 0; i < 26; i++)
                    if (n == key[i])
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                {
                    key[x] = n;
                    x++;
                }
            }
            setKey();

        }

        private void setKey()
        {

            for (int i = 0; i < 26; i++)
            {
                ShowKey[i].Text = key[i].ToString();
            }

        }

        private void clearAll()
        {
            for (int i = 0; i < 26; i++)
            {
                ShowKey[i].Text = "";
                key[i] = '#';
            }
        }

        private void btnGenertateKey_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            a.Enabled = false;
            clearAll();
            genrateKey();
            a.Enabled = true;
        }

        #endregion

        #region Button EnAndDe
        private void en_Click(object sender, EventArgs e)
        {
            string txt = txtPlan.Text;
            if (txt=="")
            {
                MessageBox.Show("Please Enter Plain Text!");
                return;
            }
           

            txtCipher.Text = Algorithms.encriptionMono(txt, keyToString());
        }

        private void de_Click(object sender, EventArgs e)
        {
            string txt = txtCipher.Text;
            if (txt == "")
            {
                MessageBox.Show("Please Enter Cipher Text!");
                return;
            }
            string txtkey = "";
            for (int i = 0; i < 26; i++)
                txtkey += key[i];

            txtPlan.Text = Algorithms.decriptionMono(txt, txtkey);
        }
        #endregion

        #region timers Tick
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
                        changeColorText(ShowKey, Color.DarkOrange);
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
                    changeColorText(ShowKey, Color.DarkOrange);
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
                    changeColorText(ShowKey, Color.DarkOrange);
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
                changeColorText(ShowKey, Color.DarkOrange);
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
                string cipher = Algorithms.encriptionMono(txtPlan.Text[pointer].ToString(), keyToString());
                cipherShow.Text = cipher;
                txtCipher.Text += cipher;
                plainLatter[x].BackColor = Color.Red;
                ShowKey[x].BackColor = Color.Green;
                pont.Location = new Point(plainLatter[x].Location.X, pont.Location.Y);
                travel.Stop();
                show.Start();
            }
        }

        private void travelDe_Tick(object sender, EventArgs e)
        {
            string plain = Algorithms.decriptionMono(txtCipher.Text[pointer].ToString(),keyToString());
            int x = Convert.ToInt32(plain[0]) - 97;
            if (ii <= x)
            {
                changeColorText(ShowKey, Color.DarkOrange);
                ShowKey[ii].BackColor = Color.Black;
                ii++;
            }
            else
            {
                txtShow.Show();
                pointDe.Show();
                txtShow.Text = plain;
                txtPlan.Text += plain;
                plainLatter[x].BackColor = Color.Red;
                ShowKey[x].BackColor = Color.Green;
                pointDe.Location = new Point(plainLatter[x].Location.X, pont.Location.Y);
                travelDe.Stop();
                showDe.Start();
            }
        }


        #endregion

        #region servicies
        private void changeColor(List<Label> x, Color c)
        {
            foreach (Label item in x)
                item.BackColor = c;
        }

        private void changeColorText(List<TextBox> x, Color c)
        {
            foreach (TextBox item in x)
                item.BackColor = c;
        }

        private string keyToString() {
            string txtkey = "";
            for (int i = 0; i < 26; i++)
                txtkey += key[i];
            return txtkey;
        }

        private void controlState(bool x)
        {
            txtCipher.ReadOnly = !x;
            txtPlan.ReadOnly = !x;
           
            en.Enabled = x;
            de.Enabled = x;
            button1.Enabled = x;
            txtShow.Visible = !x;
            cipherShow.Visible = !x;
            button2.Enabled = !x;
            btnPlayEn.Enabled = x;
            btnStopDe.Enabled = !x;
            btnGenertateKey.Enabled = x;
            button3.Enabled = x;
            button4.Enabled = x;
        }
        #endregion

        #region button Play&Stop
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

        private void button2_Click(object sender, EventArgs e)
        {
            controlState(true);
            show.Stop();
            travel.Stop();
            changeColor(plainLatter, Color.Goldenrod);
            changeColorText(ShowKey, Color.DarkOrange);
            pont.Hide();
        }

        private void btnPlayEn_Click_1(object sender, EventArgs e)
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

        private void btnStopDe_Click(object sender, EventArgs e)
        {
            controlState(true);
            showDe.Stop();
            travelDe.Stop();
            changeColor(plainLatter, Color.Goldenrod);
            changeColorText(ShowKey, Color.DarkOrange);
            pointDe.Hide();
        }

        #endregion

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

        private void monoAlpahaBit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            show.Interval = trackBar1.Value;
            showDe.Interval = trackBar1.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int x =  ran.Next(0, exam.Count);
            txtPlan.Text = exam[x];
        }

        private void monoAlpahaBit_Load(object sender, EventArgs e)
        {

        }

    }
}
