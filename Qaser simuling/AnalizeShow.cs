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
    public partial class AnalizeShow : Form
    {
        private Analize an = new Analize();

        public static string message;

        public AnalizeShow()
        {
            InitializeComponent();
        }

        private void AnalizeShow_Load(object sender, EventArgs e)
        { 
            an.setMessage(message);

            Dictionary<char, double> fe = an.FrequencyOfLetters;
            Dictionary<char, double> mfe = an.FrequenceOfLettersInMessages;

            msFr.Series["Frequncy"].LabelAngle = -90;

            foreach (var item in mfe)
            {
                msFr.Series["Frequncy"].Points.AddXY(item.Key.ToString(), item.Value);
            }

            enFre.Series["Frequncy"].LabelAngle = -90;
           
            foreach (var item in fe)
            {
                enFre.Series["Frequncy"].Points.AddXY(item.Key.ToString(), item.Value);
            }

        }

        private void msFr_Click(object sender, EventArgs e)
        {

        }
    }
}
