namespace Qaser_simuling
{
    partial class showPdf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showPdf));
            this.pdf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lodpdf = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.lodpdf)).BeginInit();
            this.SuspendLayout();
            // 
            // pdf
            // 
            this.pdf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdf.FormattingEnabled = true;
            this.pdf.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.pdf.Location = new System.Drawing.Point(45, 10);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(35, 21);
            this.pdf.TabIndex = 0;
            this.pdf.SelectedIndexChanged += new System.EventHandler(this.pdf_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDF";
            // 
            // lodpdf
            // 
            this.lodpdf.Enabled = true;
            this.lodpdf.Location = new System.Drawing.Point(13, 37);
            this.lodpdf.Name = "lodpdf";
            this.lodpdf.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("lodpdf.OcxState")));
            this.lodpdf.Size = new System.Drawing.Size(852, 505);
            this.lodpdf.TabIndex = 2;
            // 
            // showPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 554);
            this.Controls.Add(this.lodpdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "showPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOW PDF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.showPdf_FormClosing);
            this.Load += new System.EventHandler(this.showPdf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lodpdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pdf;
        private System.Windows.Forms.Label label1;
        private AxAcroPDFLib.AxAcroPDF lodpdf;
    }
}