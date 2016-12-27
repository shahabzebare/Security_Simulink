namespace Qaser_simuling
{
    partial class AnalizeShow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalizeShow));
            this.enFre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msFr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.enFre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msFr)).BeginInit();
            this.SuspendLayout();
            // 
            // enFre
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LogarithmBase = 2D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.LogarithmBase = 2D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 16D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.enFre.ChartAreas.Add(chartArea1);
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.GradientLine;
            legend1.ItemColumnSpacing = 10;
            legend1.Name = "Legend1";
            this.enFre.Legends.Add(legend1);
            this.enFre.Location = new System.Drawing.Point(12, 33);
            this.enFre.Name = "enFre";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=0.6, MaxPixelPointWidth=26";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Label = "#VAL";
            series1.LabelToolTip = "#VAL";
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Frequncy";
            series1.SmartLabelStyle.Enabled = false;
            series1.SmartLabelStyle.MovingDirection = System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.enFre.Series.Add(series1);
            this.enFre.Size = new System.Drawing.Size(629, 300);
            this.enFre.TabIndex = 0;
            this.enFre.Text = "English Frequency ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENGLISH LETTER FREQUENCIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(657, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "MESSAGE LETTER FREQUENCIES";
            // 
            // msFr
            // 
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LogarithmBase = 2D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.LogarithmBase = 5D;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.msFr.ChartAreas.Add(chartArea2);
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.GradientLine;
            legend2.ItemColumnSpacing = 10;
            legend2.Name = "Legend1";
            this.msFr.Legends.Add(legend2);
            this.msFr.Location = new System.Drawing.Point(657, 33);
            this.msFr.Name = "msFr";
            this.msFr.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PointWidth=0.6, MaxPixelPointWidth=26";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Label = "#VAL{N3}";
            series2.LabelToolTip = "#VAL";
            series2.Legend = "Legend1";
            series2.MarkerSize = 1;
            series2.Name = "Frequncy";
            series2.SmartLabelStyle.Enabled = false;
            series2.SmartLabelStyle.MovingDirection = System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValuesPerPoint = 4;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.msFr.Series.Add(series2);
            this.msFr.Size = new System.Drawing.Size(629, 300);
            this.msFr.TabIndex = 2;
            this.msFr.Text = "Message Frequency ";
            this.msFr.Click += new System.EventHandler(this.msFr_Click);
            // 
            // AnalizeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msFr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enFre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalizeShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalizeShow";
            this.Load += new System.EventHandler(this.AnalizeShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enFre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msFr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart enFre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart msFr;
    }
}