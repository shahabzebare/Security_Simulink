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
    public partial class showPdf : Form
    {
        public showPdf()
        {
            InitializeComponent();
        }

        private void pdf_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Application.StartupPath+"\\pdf\\" + pdf.SelectedItem + ".pdf";
            
            
       //    MessageBox.Show(path);
            lodpdf.LoadFile(path);
        }

        private void showPdf_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void showPdf_Load(object sender, EventArgs e)
        {
            pdf.SelectedIndex = 0;
        }
    }
}
