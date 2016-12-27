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
    public partial class playfair : Form
    {
        private Label[,] lb = new Label[5, 5];
        private string salitkey = "";
        private string[,] globTbl = new string[5, 5];

        //for pointing the textes
        private int pointer = 0;
        //some example
        private Dictionary<string, string> examlpe;

        public playfair()
        {
            InitializeComponent();
            #region adding the teable to desgin
            int y = 31;
            for (int i = 0; i < 5; i++)
            {
                int x = 31;
                for (int j = 0; j < 5; j++)
                {
                    lb[i, j] = new Label();
                    lb[i, j].Name = "x" + i + j;
                    lb[i, j].Location = new System.Drawing.Point(x, y);
                    lb[i, j].Size = new System.Drawing.Size(60, 60); ;
                    lb[i, j].Text = Convert.ToChar((i + j) % 26 + 97).ToString();
                    lb[i, j].BackColor = Color.Black;
                    lb[i, j].ForeColor = Color.White;
                    lb[i, j].Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.Controls.Add(lb[i, j]);
                    x +=61;
                }
                y += 61;
            }
            setTable(genrateTabele(txtKey.Text));
            #endregion


            #region intialize the examples
            examlpe = new Dictionary<string, string> { 
                    {"university of zakho","security"},
                    {"send help soon","computer"}
            };
            #endregion
        }


        #region playfarir Algorithm services

        //genratate table by using key
        private string[,] genrateTabele(string key)
        {

            string [,]table = new string[5,5];
            // for save the removed in double in the key
            string removedKey = "";

            //remover double and replay chars in key
            for (int i = 0; i < key.Length; i++)
                if (key[i]>='a' && key[i]<='z')
                {
                    if (!removedKey.Contains(key[i]) && key[i] != 'j')
                        removedKey += key[i];
                    else if (key[i] == 'j' && !removedKey.Contains('i'))
                        removedKey += 'i';
                }

            salitkey = removedKey;
            //insert all remander alpha bit into Table
            int count = 0;
            char alpha = 'a';
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (count < removedKey.Length)
                        table[i,j] = removedKey[count++].ToString();
                    else if ((!removedKey.Contains(alpha)) && alpha != 'j')
                        table[i,j] = (alpha++).ToString();
                    else
                    {
                        j--;
                        alpha++;
                    }
            globTbl = table;
            return table;
        }

        // for remove space and add x between the double litter and add x into last if length of txet is odd
        string prossesPlainText(string str)
        {
            string text = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    continue;
                if (i % 2 != 0 && str[i] == str[i - 1])
                    text += 'x';
                text += str[i];
            }
            if (text.Length % 2 != 0)
                text += 'x';
            return text;
        }

        //finde row and column of the char in the table
        private void findeColRowOfChar(char ch, ref int col, ref int row)
        {
            if (ch == 'j')
                ch = 'i';
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (ch == globTbl[i, j][0])
                    {
                        row = i;
                        col = j;
                        break;
                    }
        }

        //encription
        string encryption(string plainText)
        {

            string cipherText = "";

            int ch1col = 0, ch2col = 0, ch1row = 0, ch2row = 0;
            for (int i = 0; i < plainText.Length; i += 2)
            {
                findeColRowOfChar(plainText[i], ref ch1col, ref ch1row);
                findeColRowOfChar(plainText[i + 1], ref ch2col, ref ch2row);
                if (ch1col == ch2col)
                {
                    cipherText += globTbl[(ch1row + 1) % 5, ch1col];
                    cipherText += globTbl[(ch2row + 1) % 5, ch2col];
                }
                else if (ch1row == ch2row)
                {
                    cipherText += globTbl[ch1row, (ch1col + 1) % 5];
                    cipherText += globTbl[ch2row, (ch2col + 1) % 5];
                }
                else
                {
                    cipherText += globTbl[ch1row, ch2col];
                    cipherText += globTbl[ch2row, ch1col];
                }
            }
            return cipherText;
        }

        //decription
        string decryption(string cipherText)
        {

            string plainText = "";

            int ch1col = 0, ch2col = 0, ch1row = 0, ch2row = 0;
            for (int i = 0; i < cipherText.Length; i += 2)
            {
                findeColRowOfChar(cipherText[i],ref ch1col,ref ch1row);
                findeColRowOfChar(cipherText[i + 1],ref ch2col,ref ch2row);
                if (ch1col == ch2col)
                {
                    plainText += globTbl[myMod(ch1row - 1, 5),ch1col];
                    plainText += globTbl[myMod(ch2row - 1, 5),ch2col];
                }
                else if (ch1row == ch2row)
                {
                    plainText += globTbl[ch1row,myMod(ch1col - 1, 5)];
                    plainText += globTbl[ch2row,myMod(ch2col - 1, 5)];
                }
                else
                {
                    plainText += globTbl[ch1row,ch2col];
                    plainText += globTbl[ch2row,ch1col];
                }
            }

            return plainText;
        }

        //my Mod
        int myMod(int x, int y)
        {
            int r = x % y;
            return r < 0 ? r + y : r;
        }

        #endregion

        #region other services

        //change the visible and enable of the some control
        private void controlState(bool x)
        {
            txtCipher.ReadOnly = !x;
            txtPlan.ReadOnly = !x;
            txtKey.ReadOnly = !x;
            en.Enabled = x;
            de.Enabled = x;
            button1.Enabled = x;
            lblPlainShow1.Visible = !x;
            lblPlainShow1.Text = "";
            lblPlainShow2.Visible = !x;
            lblPlainShow2.Text = "";
            lblCipherShow1.Visible = !x;
            lblCipherShow1.Text = "";
            lblCipherShow2.Visible = !x;
            lblCipherShow2.Text = "";
            button2.Enabled = !x;
            btnPlayEn.Enabled = x;
            btnStopDe.Enabled = !x;
            button3.Enabled = x;
            example.Enabled = x;
            button4.Enabled = x;
        }

        //set the table into design
        private void setTable(string[,] a)
        {
            int color = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (a[i, j] == "i" || lb[i, j].Text == "j")
                        lb[i, j].Text = "i/j";
                    else
                        lb[i, j].Text = a[i, j];


                    lb[i, j].BackColor = color < salitkey.Length ? Color.Red : Color.Black;
                    color++;
                }
        }

        //closing winows
        private void playfair_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        #endregion


        #region some control events
        // set the table by using text change in key textbox
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
       
            setTable(genrateTabele(txtKey.Text));
            txtKey.Text = salitkey;
            txtKey.Select(txtKey.Text.Length, 0);
        }

        //btn propering text
        private void button3_Click(object sender, EventArgs e)
        {
            txtPlan.Text = prossesPlainText(txtPlan.Text);
            txtPlan.Select(txtPlan.Text.Length, 0);
        }

        //set speed of the timer 
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tmEncritpion.Interval = trackBar1.Value;
            tmDecription.Interval = trackBar1.Value;
        }

        //btn encription
        private void en_Click(object sender, EventArgs e)
        {
            //propering text
            txtPlan.Text = prossesPlainText(txtPlan.Text);
            txtPlan.Select(txtPlan.Text.Length, 0);
            txtCipher.Text = encryption(txtPlan.Text);
        }

        //btn decription
        private void de_Click(object sender, EventArgs e)
        {
            txtPlan.Text = decryption(txtCipher.Text);
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

        //seting the randiom example
        private void example_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int num = rn.Next(0, examlpe.Count);
            txtPlan.Text = examlpe.ElementAt(num).Key;
            txtKey.Text = examlpe.ElementAt(num).Value;
            txtCipher.Text = "";
        }


        //show frequcy
        private void button4_Click(object sender, EventArgs e)
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

        #endregion

        #region play Encription

        //timer for play Encription
        private void tmEncritpion_Tick(object sender, EventArgs e)
        {
            string plain = txtPlan.Text;
            if (pointer < plain.Length)
            {
                setTable(globTbl);

                lblPlainShow1.Text = plain[pointer].ToString();
                lblPlainShow2.Text = plain[pointer + 1].ToString();

                int fcol = 0, frow = 0;
                findeColRowOfChar(plain[pointer], ref fcol, ref frow);
                lb[frow, fcol].BackColor = Color.DarkBlue;

                int scol = 0, srow = 0;
                findeColRowOfChar(plain[pointer + 1], ref scol, ref srow);
                lb[srow, scol].BackColor = Color.Orange;

                if (fcol == scol)
                {
                    int newFrow = (frow + 1) % 5;
                    int newSrow = (srow + 1) % 5;

                    lblCipherShow1.Text = globTbl[newFrow, fcol];
                    lblCipherShow2.Text = globTbl[newSrow, scol];

                    lb[newFrow, fcol].BackColor = Color.DarkOrchid;
                    lb[newSrow, scol].BackColor = Color.Yellow;

                }
                else if (frow == srow)
                {
                    int newFcol = (fcol + 1) % 5;
                    int newScol = (scol + 1) % 5;

                    lblCipherShow1.Text = globTbl[frow, newFcol];
                    lblCipherShow2.Text = globTbl[srow, newScol];

                    lb[frow, newFcol].BackColor = Color.DarkOrchid;
                    lb[srow, newScol].BackColor = Color.Yellow;
                }
                else
                {
                    lblCipherShow1.Text = globTbl[frow, scol];
                    lblCipherShow2.Text = globTbl[srow, fcol];

                    lb[frow, scol].BackColor = Color.DarkOrchid;
                    lb[srow, fcol].BackColor = Color.Yellow;
                }
                txtCipher.Text += lblCipherShow1.Text + lblCipherShow2.Text;
                pointer += 2;
            }
            else
            {
                controlState(true);
                setTable(globTbl);
                tmEncritpion.Stop();
            }
        }

        //btn play encription
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlan.Text == "")
            {
                MessageBox.Show("Please Enter Plain Text!");
                return;
            }
            //propering text
            txtPlan.Text = prossesPlainText(txtPlan.Text);
            txtPlan.Select(txtPlan.Text.Length, 0);
            //start
            controlState(false);
            pointer = 0;
            txtCipher.Text = "";
            btnStopDe.Enabled = false;
            tmEncritpion.Start();
        }

        //stop encription
        private void button2_Click(object sender, EventArgs e)
        {
            controlState(true);
            setTable(globTbl);
            tmEncritpion.Stop();
        }
        #endregion

        #region play Decription

        //timer for play Encription
        private void tmDecritpion_Tick(object sender, EventArgs e)
        {
            string plain = txtCipher.Text;
            if (pointer < plain.Length)
            {
                setTable(globTbl);

                lblCipherShow1.Text = plain[pointer].ToString();
                lblCipherShow2.Text = plain[pointer + 1].ToString();

                int fcol = 0, frow = 0;
                findeColRowOfChar(plain[pointer], ref fcol, ref frow);
                lb[frow, fcol].BackColor = Color.DarkOrchid;

                int scol = 0, srow = 0;
                findeColRowOfChar(plain[pointer + 1], ref scol, ref srow);
                lb[srow, scol].BackColor = Color.Yellow;

                if (fcol == scol)
                {
                    int newFrow = myMod(frow - 1, 5);
                    int newSrow = myMod(srow - 1, 5);

                    lblPlainShow1.Text = globTbl[newFrow, fcol];
                    lblPlainShow2.Text = globTbl[newSrow, scol];

                    lb[newFrow, fcol].BackColor = Color.DarkBlue;
                    lb[newSrow, scol].BackColor = Color.Orange;

                }
                else if (frow == srow)
                {
                    int newFcol = myMod(fcol - 1,5);
                    int newScol = myMod(scol - 1,5);

                    lblPlainShow1.Text = globTbl[frow, newFcol];
                    lblPlainShow2.Text = globTbl[srow, newScol];

                    lb[frow, newFcol].BackColor = Color.DarkBlue;
                    lb[srow, newScol].BackColor = Color.Orange;
                }
                else
                {
                    lblPlainShow1.Text = globTbl[frow, scol];
                    lblPlainShow2.Text = globTbl[srow, fcol];

                    lb[frow, scol].BackColor = Color.DarkBlue;
                    lb[srow, fcol].BackColor = Color.Orange;
                }
                txtPlan.Text += lblPlainShow1.Text + lblPlainShow2.Text;
                pointer += 2;
            }
            else
            {
                controlState(true);
                setTable(globTbl);
                tmDecription.Stop();
            }
        }

        //btn play decription
        private void BtnDec_Click(object sender, EventArgs e)
        {
            if (txtCipher.Text == "")
            {
                MessageBox.Show("Please Enter Cipher Text!");
                return;
            }
            //start
            controlState(false);
            pointer = 0;
            txtPlan.Text = "";
            button2.Enabled = false;
            tmDecription.Start();
        }

        //stop decription
        private void btnStop_Click(object sender, EventArgs e)
        {
            controlState(true);
            setTable(globTbl);
            tmDecription.Stop();
        }
        #endregion

        


       
    }
}
