namespace Qaser_simuling
{
    partial class playfair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playfair));
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnStopDe = new System.Windows.Forms.Button();
            this.btnPlayEn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCipherShow2 = new System.Windows.Forms.Label();
            this.lblPlainShow2 = new System.Windows.Forms.Label();
            this.de = new System.Windows.Forms.Button();
            this.en = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPlainShow1 = new System.Windows.Forms.Label();
            this.tmEncritpion = new System.Windows.Forms.Timer(this.components);
            this.lblCipherShow1 = new System.Windows.Forms.Label();
            this.tmDecription = new System.Windows.Forms.Timer(this.components);
            this.example = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 149;
            this.label4.Text = "Play Speed";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(585, 426);
            this.trackBar1.Maximum = 10000;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(186, 45);
            this.trackBar1.TabIndex = 148;
            this.trackBar1.Value = 3000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnStopDe
            // 
            this.btnStopDe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopDe.BackgroundImage")));
            this.btnStopDe.Enabled = false;
            this.btnStopDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopDe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopDe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStopDe.Location = new System.Drawing.Point(408, 288);
            this.btnStopDe.Name = "btnStopDe";
            this.btnStopDe.Size = new System.Drawing.Size(109, 32);
            this.btnStopDe.TabIndex = 145;
            this.btnStopDe.Text = "Stop De";
            this.btnStopDe.UseVisualStyleBackColor = true;
            this.btnStopDe.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlayEn
            // 
            this.btnPlayEn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayEn.BackgroundImage")));
            this.btnPlayEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayEn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayEn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlayEn.Location = new System.Drawing.Point(408, 253);
            this.btnPlayEn.Name = "btnPlayEn";
            this.btnPlayEn.Size = new System.Drawing.Size(109, 32);
            this.btnPlayEn.TabIndex = 144;
            this.btnPlayEn.Text = "Play De";
            this.btnPlayEn.UseVisualStyleBackColor = true;
            this.btnPlayEn.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(408, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 143;
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
            this.button1.Location = new System.Drawing.Point(408, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 142;
            this.button1.Text = "Play En";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCipherShow2
            // 
            this.lblCipherShow2.AutoSize = true;
            this.lblCipherShow2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipherShow2.ForeColor = System.Drawing.Color.Yellow;
            this.lblCipherShow2.Location = new System.Drawing.Point(536, 356);
            this.lblCipherShow2.Name = "lblCipherShow2";
            this.lblCipherShow2.Size = new System.Drawing.Size(33, 35);
            this.lblCipherShow2.TabIndex = 140;
            this.lblCipherShow2.Text = "x";
            this.lblCipherShow2.Visible = false;
            // 
            // lblPlainShow2
            // 
            this.lblPlainShow2.AutoSize = true;
            this.lblPlainShow2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainShow2.ForeColor = System.Drawing.Color.Orange;
            this.lblPlainShow2.Location = new System.Drawing.Point(536, 96);
            this.lblPlainShow2.Name = "lblPlainShow2";
            this.lblPlainShow2.Size = new System.Drawing.Size(33, 35);
            this.lblPlainShow2.TabIndex = 139;
            this.lblPlainShow2.Text = "x";
            this.lblPlainShow2.Visible = false;
            // 
            // de
            // 
            this.de.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("de.BackgroundImage")));
            this.de.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.de.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.de.Location = new System.Drawing.Point(408, 150);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(109, 32);
            this.de.TabIndex = 138;
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
            this.en.Location = new System.Drawing.Point(408, 117);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(109, 32);
            this.en.TabIndex = 137;
            this.en.Text = "Encription";
            this.en.UseVisualStyleBackColor = false;
            this.en.Click += new System.EventHandler(this.en_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 136;
            this.label3.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.PeachPuff;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKey.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(585, 184);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(384, 58);
            this.txtKey.TabIndex = 2;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 134;
            this.label2.Text = "Cipher Text";
            // 
            // txtCipher
            // 
            this.txtCipher.BackColor = System.Drawing.Color.PeachPuff;
            this.txtCipher.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCipher.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipher.Location = new System.Drawing.Point(585, 271);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(384, 130);
            this.txtCipher.TabIndex = 3;
            this.txtCipher.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 132;
            this.label1.Text = "Plain Text";
            // 
            // txtPlan
            // 
            this.txtPlan.BackColor = System.Drawing.Color.PeachPuff;
            this.txtPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPlan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Location = new System.Drawing.Point(585, 30);
            this.txtPlan.Multiline = true;
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(384, 130);
            this.txtPlan.TabIndex = 1;
            this.txtPlan.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(408, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 32);
            this.button3.TabIndex = 150;
            this.button3.Text = "Clean plain";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPlainShow1
            // 
            this.lblPlainShow1.AutoSize = true;
            this.lblPlainShow1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainShow1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPlainShow1.Location = new System.Drawing.Point(536, 42);
            this.lblPlainShow1.Name = "lblPlainShow1";
            this.lblPlainShow1.Size = new System.Drawing.Size(33, 35);
            this.lblPlainShow1.TabIndex = 151;
            this.lblPlainShow1.Text = "x";
            this.lblPlainShow1.Visible = false;
            // 
            // tmEncritpion
            // 
            this.tmEncritpion.Interval = 3000;
            this.tmEncritpion.Tick += new System.EventHandler(this.tmEncritpion_Tick);
            // 
            // lblCipherShow1
            // 
            this.lblCipherShow1.AutoSize = true;
            this.lblCipherShow1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipherShow1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblCipherShow1.Location = new System.Drawing.Point(536, 294);
            this.lblCipherShow1.Name = "lblCipherShow1";
            this.lblCipherShow1.Size = new System.Drawing.Size(33, 35);
            this.lblCipherShow1.TabIndex = 152;
            this.lblCipherShow1.Text = "x";
            this.lblCipherShow1.Visible = false;
            // 
            // tmDecription
            // 
            this.tmDecription.Interval = 3000;
            this.tmDecription.Tick += new System.EventHandler(this.tmDecritpion_Tick);
            // 
            // example
            // 
            this.example.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.example.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("example.BackgroundImage")));
            this.example.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.example.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.example.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.example.Location = new System.Drawing.Point(408, 49);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(109, 32);
            this.example.TabIndex = 153;
            this.example.Text = "Examples";
            this.example.UseVisualStyleBackColor = false;
            this.example.Click += new System.EventHandler(this.example_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(408, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 32);
            this.button4.TabIndex = 154;
            this.button4.Text = "Show frequency";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // playfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 469);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.example);
            this.Controls.Add(this.lblCipherShow1);
            this.Controls.Add(this.lblPlainShow1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStopDe);
            this.Controls.Add(this.btnPlayEn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCipherShow2);
            this.Controls.Add(this.lblPlainShow2);
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
            this.Name = "playfair";
            this.Text = "PLAYFAIR CIPHER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.playfair_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnStopDe;
        private System.Windows.Forms.Button btnPlayEn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCipherShow2;
        private System.Windows.Forms.Label lblPlainShow2;
        private System.Windows.Forms.Button de;
        private System.Windows.Forms.Button en;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPlainShow1;
        private System.Windows.Forms.Timer tmEncritpion;
        private System.Windows.Forms.Label lblCipherShow1;
        private System.Windows.Forms.Timer tmDecription;
        private System.Windows.Forms.Button example;
        private System.Windows.Forms.Button button4;
    }
}