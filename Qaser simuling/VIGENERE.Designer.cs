namespace Qaser_simuling
{
    partial class VIGENERE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIGENERE));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.de = new System.Windows.Forms.Button();
            this.en = new System.Windows.Forms.Button();
            this.lblPlainShow = new System.Windows.Forms.Label();
            this.lblCipherShow = new System.Windows.Forms.Label();
            this.lblShowKey = new System.Windows.Forms.Label();
            this.btnStopDe = new System.Windows.Forms.Button();
            this.btnPlayEn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tmEncription = new System.Windows.Forms.Timer(this.components);
            this.lblPointerEn = new System.Windows.Forms.Label();
            this.lblPointerDe = new System.Windows.Forms.Label();
            this.tmDecription = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Plain Text";
            // 
            // txtPlan
            // 
            this.txtPlan.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPlan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Location = new System.Drawing.Point(697, 28);
            this.txtPlan.Multiline = true;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(384, 130);
            this.txtPlan.TabIndex = 112;
            this.txtPlan.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 115;
            this.label2.Text = "Cipher Text";
            // 
            // txtCipher
            // 
            this.txtCipher.BackColor = System.Drawing.Color.PeachPuff;
            this.txtCipher.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCipher.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipher.Location = new System.Drawing.Point(697, 269);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(384, 130);
            this.txtCipher.TabIndex = 114;
            this.txtCipher.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 117;
            this.label3.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.PeachPuff;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKey.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(697, 182);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(384, 58);
            this.txtKey.TabIndex = 116;
            this.txtKey.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
            // 
            // de
            // 
            this.de.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("de.BackgroundImage")));
            this.de.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.de.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.de.Location = new System.Drawing.Point(532, 130);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(100, 32);
            this.de.TabIndex = 119;
            this.de.Text = "Decription";
            this.de.UseVisualStyleBackColor = true;
            this.de.Click += new System.EventHandler(this.de_Click);
            // 
            // en
            // 
            this.en.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.en.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("en.BackgroundImage")));
            this.en.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.en.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.en.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.en.Location = new System.Drawing.Point(532, 97);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(100, 32);
            this.en.TabIndex = 118;
            this.en.Text = "Encription";
            this.en.UseVisualStyleBackColor = false;
            this.en.Click += new System.EventHandler(this.en_Click);
            // 
            // lblPlainShow
            // 
            this.lblPlainShow.AutoSize = true;
            this.lblPlainShow.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainShow.ForeColor = System.Drawing.Color.Red;
            this.lblPlainShow.Location = new System.Drawing.Point(648, 70);
            this.lblPlainShow.Name = "lblPlainShow";
            this.lblPlainShow.Size = new System.Drawing.Size(33, 35);
            this.lblPlainShow.TabIndex = 120;
            this.lblPlainShow.Text = "x";
            this.lblPlainShow.Visible = false;
            // 
            // lblCipherShow
            // 
            this.lblCipherShow.AutoSize = true;
            this.lblCipherShow.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipherShow.ForeColor = System.Drawing.Color.Green;
            this.lblCipherShow.Location = new System.Drawing.Point(648, 320);
            this.lblCipherShow.Name = "lblCipherShow";
            this.lblCipherShow.Size = new System.Drawing.Size(33, 35);
            this.lblCipherShow.TabIndex = 121;
            this.lblCipherShow.Text = "x";
            this.lblCipherShow.Visible = false;
            // 
            // lblShowKey
            // 
            this.lblShowKey.AutoSize = true;
            this.lblShowKey.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowKey.ForeColor = System.Drawing.Color.Magenta;
            this.lblShowKey.Location = new System.Drawing.Point(648, 193);
            this.lblShowKey.Name = "lblShowKey";
            this.lblShowKey.Size = new System.Drawing.Size(33, 35);
            this.lblShowKey.TabIndex = 122;
            this.lblShowKey.Text = "x";
            this.lblShowKey.Visible = false;
            this.lblShowKey.Click += new System.EventHandler(this.lblShowKey_Click);
            // 
            // btnStopDe
            // 
            this.btnStopDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopDe.BackgroundImage")));
            this.btnStopDe.Enabled = false;
            this.btnStopDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopDe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStopDe.Location = new System.Drawing.Point(532, 268);
            this.btnStopDe.Name = "btnStopDe";
            this.btnStopDe.Size = new System.Drawing.Size(100, 32);
            this.btnStopDe.TabIndex = 126;
            this.btnStopDe.Text = "Stop De";
            this.btnStopDe.UseVisualStyleBackColor = true;
            this.btnStopDe.Click += new System.EventHandler(this.btnStopDe_Click);
            // 
            // btnPlayEn
            // 
            this.btnPlayEn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayEn.BackgroundImage")));
            this.btnPlayEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayEn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayEn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlayEn.Location = new System.Drawing.Point(532, 233);
            this.btnPlayEn.Name = "btnPlayEn";
            this.btnPlayEn.Size = new System.Drawing.Size(100, 32);
            this.btnPlayEn.TabIndex = 125;
            this.btnPlayEn.Text = "Play De";
            this.btnPlayEn.UseVisualStyleBackColor = true;
            this.btnPlayEn.Click += new System.EventHandler(this.btnPlayEn_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(532, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 124;
            this.button2.Text = "Stop En";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(532, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 123;
            this.button1.Text = "Play En";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmEncription
            // 
            this.tmEncription.Interval = 4000;
            this.tmEncription.Tick += new System.EventHandler(this.tmEncription_Tick);
            // 
            // lblPointerEn
            // 
            this.lblPointerEn.Image = ((System.Drawing.Image)(resources.GetObject("lblPointerEn.Image")));
            this.lblPointerEn.Location = new System.Drawing.Point(646, 111);
            this.lblPointerEn.Name = "lblPointerEn";
            this.lblPointerEn.Size = new System.Drawing.Size(35, 78);
            this.lblPointerEn.TabIndex = 127;
            this.lblPointerEn.Visible = false;
            // 
            // lblPointerDe
            // 
            this.lblPointerDe.Image = ((System.Drawing.Image)(resources.GetObject("lblPointerDe.Image")));
            this.lblPointerDe.Location = new System.Drawing.Point(646, 228);
            this.lblPointerDe.Name = "lblPointerDe";
            this.lblPointerDe.Size = new System.Drawing.Size(35, 92);
            this.lblPointerDe.TabIndex = 128;
            this.lblPointerDe.Visible = false;
            // 
            // tmDecription
            // 
            this.tmDecription.Interval = 4000;
            this.tmDecription.Tick += new System.EventHandler(this.tmDecription_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(697, 424);
            this.trackBar1.Maximum = 10000;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(186, 45);
            this.trackBar1.TabIndex = 129;
            this.trackBar1.Value = 5000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 130;
            this.label4.Text = "Play Speed";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(532, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 32);
            this.button3.TabIndex = 131;
            this.button3.Text = "Show frequency";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(532, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 132;
            this.button4.Text = "Example";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // VIGENERE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 468);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblPointerDe);
            this.Controls.Add(this.lblPointerEn);
            this.Controls.Add(this.btnStopDe);
            this.Controls.Add(this.btnPlayEn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblShowKey);
            this.Controls.Add(this.lblCipherShow);
            this.Controls.Add(this.lblPlainShow);
            this.Controls.Add(this.de);
            this.Controls.Add(this.en);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VIGENERE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIGENERE CIPHER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIGENERE_FormClosing);
            this.Load += new System.EventHandler(this.VIGENERE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button de;
        private System.Windows.Forms.Button en;
        private System.Windows.Forms.Label lblPlainShow;
        private System.Windows.Forms.Label lblCipherShow;
        private System.Windows.Forms.Label lblShowKey;
        private System.Windows.Forms.Button btnStopDe;
        private System.Windows.Forms.Button btnPlayEn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmEncription;
        private System.Windows.Forms.Label lblPointerEn;
        private System.Windows.Forms.Label lblPointerDe;
        private System.Windows.Forms.Timer tmDecription;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}