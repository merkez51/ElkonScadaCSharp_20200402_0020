namespace ElkonScada._01_TempMainPage
{
    partial class LaumasEnerjiAnalizoru
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MikserAkim = new System.Windows.Forms.Label();
            this.MixerAkımSlumMeter = new AJBauer.AGauge();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MixerGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.KatkiLaumasName = new System.Windows.Forms.Label();
            this.SuLaumasName = new System.Windows.Forms.Label();
            this.CimentoLaumasName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.XB2_AgregaKantar = new System.Windows.Forms.Label();
            this.AgregaLaumasName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.XB3_CMKantar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.XB5_KatKantar = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.XB4_SuKantar = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Hx = new System.Windows.Forms.Label();
            this.Amp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XB1_Frekans = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.XB1_ToplamAkim = new System.Windows.Forms.Label();
            this.XB1_Voltaj3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XB1_Voltaj2 = new System.Windows.Forms.Label();
            this.XB1_Voltaj1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MixerGraph)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.KatkiLaumasName);
            this.panel1.Controls.Add(this.SuLaumasName);
            this.panel1.Controls.Add(this.CimentoLaumasName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 322);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(279, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(223, 201);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MikserAkim);
            this.tabPage1.Controls.Add(this.MixerAkımSlumMeter);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(215, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MikserAkim
            // 
            this.MikserAkim.AutoSize = true;
            this.MikserAkim.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MikserAkim.Location = new System.Drawing.Point(53, 155);
            this.MikserAkim.Name = "MikserAkim";
            this.MikserAkim.Size = new System.Drawing.Size(103, 25);
            this.MikserAkim.TabIndex = 23;
            this.MikserAkim.Text = "Mikser";
            this.MikserAkim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MixerAkımSlumMeter
            // 
            this.MixerAkımSlumMeter.BackColor = System.Drawing.SystemColors.Info;
            this.MixerAkımSlumMeter.BaseArcColor = System.Drawing.Color.Maroon;
            this.MixerAkımSlumMeter.BaseArcRadius = 80;
            this.MixerAkımSlumMeter.BaseArcStart = 135;
            this.MixerAkımSlumMeter.BaseArcSweep = 270;
            this.MixerAkımSlumMeter.BaseArcWidth = 10;
            this.MixerAkımSlumMeter.Cap_Idx = ((byte)(1));
            this.MixerAkımSlumMeter.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.MixerAkımSlumMeter.CapPosition = new System.Drawing.Point(10, 10);
            this.MixerAkımSlumMeter.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.MixerAkımSlumMeter.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.MixerAkımSlumMeter.CapText = "";
            this.MixerAkımSlumMeter.Center = new System.Drawing.Point(100, 100);
            this.MixerAkımSlumMeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MixerAkımSlumMeter.Location = new System.Drawing.Point(3, 3);
            this.MixerAkımSlumMeter.MaxValue = 200F;
            this.MixerAkımSlumMeter.MinValue = 0F;
            this.MixerAkımSlumMeter.Name = "MixerAkımSlumMeter";
            this.MixerAkımSlumMeter.NeedleColor1 = AJBauer.AGauge.NeedleColorEnum.Magenta;
            this.MixerAkımSlumMeter.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MixerAkımSlumMeter.NeedleRadius = 90;
            this.MixerAkımSlumMeter.NeedleType = 0;
            this.MixerAkımSlumMeter.NeedleWidth = 3;
            this.MixerAkımSlumMeter.Range_Idx = ((byte)(2));
            this.MixerAkımSlumMeter.RangeColor = System.Drawing.SystemColors.Control;
            this.MixerAkımSlumMeter.RangeEnabled = false;
            this.MixerAkımSlumMeter.RangeEndValue = 0F;
            this.MixerAkımSlumMeter.RangeInnerRadius = 70;
            this.MixerAkımSlumMeter.RangeOuterRadius = 80;
            this.MixerAkımSlumMeter.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.MixerAkımSlumMeter.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.MixerAkımSlumMeter.RangesEndValue = new float[] {
        150F,
        250F,
        0F,
        0F,
        0F};
            this.MixerAkımSlumMeter.RangesInnerRadius = new int[] {
        25,
        90,
        70,
        70,
        70};
            this.MixerAkımSlumMeter.RangesOuterRadius = new int[] {
        80,
        20,
        80,
        80,
        80};
            this.MixerAkımSlumMeter.RangesStartValue = new float[] {
        10F,
        150F,
        0F,
        0F,
        0F};
            this.MixerAkımSlumMeter.RangeStartValue = 0F;
            this.MixerAkımSlumMeter.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.MixerAkımSlumMeter.ScaleLinesInterInnerRadius = 90;
            this.MixerAkımSlumMeter.ScaleLinesInterOuterRadius = 90;
            this.MixerAkımSlumMeter.ScaleLinesInterWidth = 1;
            this.MixerAkımSlumMeter.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.MixerAkımSlumMeter.ScaleLinesMajorInnerRadius = 70;
            this.MixerAkımSlumMeter.ScaleLinesMajorOuterRadius = 80;
            this.MixerAkımSlumMeter.ScaleLinesMajorStepValue = 50F;
            this.MixerAkımSlumMeter.ScaleLinesMajorWidth = 2;
            this.MixerAkımSlumMeter.ScaleLinesMinorColor = System.Drawing.Color.Lime;
            this.MixerAkımSlumMeter.ScaleLinesMinorInnerRadius = 75;
            this.MixerAkımSlumMeter.ScaleLinesMinorNumOf = 1;
            this.MixerAkımSlumMeter.ScaleLinesMinorOuterRadius = 80;
            this.MixerAkımSlumMeter.ScaleLinesMinorWidth = 1;
            this.MixerAkımSlumMeter.ScaleNumbersColor = System.Drawing.Color.Black;
            this.MixerAkımSlumMeter.ScaleNumbersFormat = null;
            this.MixerAkımSlumMeter.ScaleNumbersRadius = 93;
            this.MixerAkımSlumMeter.ScaleNumbersRotation = 1;
            this.MixerAkımSlumMeter.ScaleNumbersStartScaleLine = 1;
            this.MixerAkımSlumMeter.ScaleNumbersStepScaleLines = 1;
            this.MixerAkımSlumMeter.Size = new System.Drawing.Size(209, 170);
            this.MixerAkımSlumMeter.TabIndex = 24;
            this.MixerAkımSlumMeter.Text = "aGauge1";
            this.MixerAkımSlumMeter.Value = 100F;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MixerGraph);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(215, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MixerGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.MixerGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MixerGraph.Legends.Add(legend1);
            this.MixerGraph.Location = new System.Drawing.Point(-14, 3);
            this.MixerGraph.Name = "MixerGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Amp";
            this.MixerGraph.Series.Add(series1);
            this.MixerGraph.Size = new System.Drawing.Size(318, 185);
            this.MixerGraph.TabIndex = 0;
            this.MixerGraph.Text = "chart1";
            // 
            // KatkiLaumasName
            // 
            this.KatkiLaumasName.AutoSize = true;
            this.KatkiLaumasName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.KatkiLaumasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatkiLaumasName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KatkiLaumasName.Location = new System.Drawing.Point(6, 128);
            this.KatkiLaumasName.Name = "KatkiLaumasName";
            this.KatkiLaumasName.Size = new System.Drawing.Size(49, 20);
            this.KatkiLaumasName.TabIndex = 8;
            this.KatkiLaumasName.Text = "Katki";
            // 
            // SuLaumasName
            // 
            this.SuLaumasName.AutoSize = true;
            this.SuLaumasName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SuLaumasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuLaumasName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SuLaumasName.Location = new System.Drawing.Point(6, 175);
            this.SuLaumasName.Name = "SuLaumasName";
            this.SuLaumasName.Size = new System.Drawing.Size(31, 20);
            this.SuLaumasName.TabIndex = 7;
            this.SuLaumasName.Text = "Su";
            // 
            // CimentoLaumasName
            // 
            this.CimentoLaumasName.AutoSize = true;
            this.CimentoLaumasName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CimentoLaumasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CimentoLaumasName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CimentoLaumasName.Location = new System.Drawing.Point(6, 81);
            this.CimentoLaumasName.Name = "CimentoLaumasName";
            this.CimentoLaumasName.Size = new System.Drawing.Size(75, 20);
            this.CimentoLaumasName.TabIndex = 6;
            this.CimentoLaumasName.Text = "Çimento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.XB2_AgregaKantar);
            this.panel2.Controls.Add(this.AgregaLaumasName);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 43);
            this.panel2.TabIndex = 25;
            // 
            // XB2_AgregaKantar
            // 
            this.XB2_AgregaKantar.AutoSize = true;
            this.XB2_AgregaKantar.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.XB2_AgregaKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB2_AgregaKantar.Location = new System.Drawing.Point(155, 0);
            this.XB2_AgregaKantar.Name = "XB2_AgregaKantar";
            this.XB2_AgregaKantar.Size = new System.Drawing.Size(37, 41);
            this.XB2_AgregaKantar.TabIndex = 0;
            this.XB2_AgregaKantar.Text = "0";
            // 
            // AgregaLaumasName
            // 
            this.AgregaLaumasName.AutoSize = true;
            this.AgregaLaumasName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AgregaLaumasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregaLaumasName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AgregaLaumasName.Location = new System.Drawing.Point(3, 16);
            this.AgregaLaumasName.Name = "AgregaLaumasName";
            this.AgregaLaumasName.Size = new System.Drawing.Size(67, 20);
            this.AgregaLaumasName.TabIndex = 5;
            this.AgregaLaumasName.Text = "Agrega";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.XB3_CMKantar);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(4, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 43);
            this.panel3.TabIndex = 26;
            // 
            // XB3_CMKantar
            // 
            this.XB3_CMKantar.AutoSize = true;
            this.XB3_CMKantar.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.XB3_CMKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB3_CMKantar.Location = new System.Drawing.Point(151, 0);
            this.XB3_CMKantar.Name = "XB3_CMKantar";
            this.XB3_CMKantar.Size = new System.Drawing.Size(37, 41);
            this.XB3_CMKantar.TabIndex = 6;
            this.XB3_CMKantar.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.XB5_KatKantar);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(4, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 45);
            this.panel4.TabIndex = 27;
            // 
            // XB5_KatKantar
            // 
            this.XB5_KatKantar.AutoSize = true;
            this.XB5_KatKantar.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.XB5_KatKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB5_KatKantar.Location = new System.Drawing.Point(151, 0);
            this.XB5_KatKantar.Name = "XB5_KatKantar";
            this.XB5_KatKantar.Size = new System.Drawing.Size(37, 41);
            this.XB5_KatKantar.TabIndex = 6;
            this.XB5_KatKantar.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.XB4_SuKantar);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(4, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 62);
            this.panel5.TabIndex = 27;
            // 
            // XB4_SuKantar
            // 
            this.XB4_SuKantar.AutoSize = true;
            this.XB4_SuKantar.Font = new System.Drawing.Font("Consolas", 26.25F);
            this.XB4_SuKantar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB4_SuKantar.Location = new System.Drawing.Point(151, 6);
            this.XB4_SuKantar.Name = "XB4_SuKantar";
            this.XB4_SuKantar.Size = new System.Drawing.Size(37, 41);
            this.XB4_SuKantar.TabIndex = 7;
            this.XB4_SuKantar.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(279, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 205);
            this.panel7.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.Hx);
            this.panel6.Controls.Add(this.Amp);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.XB1_Frekans);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.XB1_ToplamAkim);
            this.panel6.Controls.Add(this.XB1_Voltaj3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.XB1_Voltaj2);
            this.panel6.Controls.Add(this.XB1_Voltaj1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(2, 217);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(499, 104);
            this.panel6.TabIndex = 27;
            // 
            // Hx
            // 
            this.Hx.AutoSize = true;
            this.Hx.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Hx.Location = new System.Drawing.Point(283, 8);
            this.Hx.Name = "Hx";
            this.Hx.Size = new System.Drawing.Size(30, 22);
            this.Hx.TabIndex = 34;
            this.Hx.Text = "Hz";
            // 
            // Amp
            // 
            this.Amp.AutoSize = true;
            this.Amp.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Amp.Location = new System.Drawing.Point(199, 8);
            this.Amp.Name = "Amp";
            this.Amp.Size = new System.Drawing.Size(40, 22);
            this.Amp.TabIndex = 33;
            this.Amp.Text = "Amp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(81, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Volt";
            // 
            // XB1_Frekans
            // 
            this.XB1_Frekans.AutoSize = true;
            this.XB1_Frekans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB1_Frekans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB1_Frekans.Location = new System.Drawing.Point(273, 54);
            this.XB1_Frekans.Name = "XB1_Frekans";
            this.XB1_Frekans.Size = new System.Drawing.Size(55, 24);
            this.XB1_Frekans.TabIndex = 31;
            this.XB1_Frekans.Text = "380.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(191, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "380.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(191, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "380.1";
            // 
            // XB1_ToplamAkim
            // 
            this.XB1_ToplamAkim.AutoSize = true;
            this.XB1_ToplamAkim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB1_ToplamAkim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB1_ToplamAkim.Location = new System.Drawing.Point(191, 30);
            this.XB1_ToplamAkim.Name = "XB1_ToplamAkim";
            this.XB1_ToplamAkim.Size = new System.Drawing.Size(55, 24);
            this.XB1_ToplamAkim.TabIndex = 27;
            this.XB1_ToplamAkim.Text = "380.1";
            // 
            // XB1_Voltaj3
            // 
            this.XB1_Voltaj3.AutoSize = true;
            this.XB1_Voltaj3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB1_Voltaj3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB1_Voltaj3.Location = new System.Drawing.Point(81, 77);
            this.XB1_Voltaj3.Name = "XB1_Voltaj3";
            this.XB1_Voltaj3.Size = new System.Drawing.Size(55, 24);
            this.XB1_Voltaj3.TabIndex = 26;
            this.XB1_Voltaj3.Text = "380.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "L3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(21, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "L2";
            // 
            // XB1_Voltaj2
            // 
            this.XB1_Voltaj2.AutoSize = true;
            this.XB1_Voltaj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB1_Voltaj2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB1_Voltaj2.Location = new System.Drawing.Point(81, 54);
            this.XB1_Voltaj2.Name = "XB1_Voltaj2";
            this.XB1_Voltaj2.Size = new System.Drawing.Size(55, 24);
            this.XB1_Voltaj2.TabIndex = 23;
            this.XB1_Voltaj2.Text = "380.1";
            // 
            // XB1_Voltaj1
            // 
            this.XB1_Voltaj1.AutoSize = true;
            this.XB1_Voltaj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XB1_Voltaj1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.XB1_Voltaj1.Location = new System.Drawing.Point(81, 30);
            this.XB1_Voltaj1.Name = "XB1_Voltaj1";
            this.XB1_Voltaj1.Size = new System.Drawing.Size(55, 24);
            this.XB1_Voltaj1.TabIndex = 22;
            this.XB1_Voltaj1.Text = "380.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "L1";
            // 
            // LaumasEnerjiAnalizoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LaumasEnerjiAnalizoru";
            this.Size = new System.Drawing.Size(498, 394);
            this.Load += new System.EventHandler(this.LaumasEnerjiAnalizoru_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MixerGraph)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label KatkiLaumasName;
        public System.Windows.Forms.Label SuLaumasName;
        public System.Windows.Forms.Label CimentoLaumasName;
        public System.Windows.Forms.Label AgregaLaumasName;
        private System.Windows.Forms.Label MikserAkim;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        public AJBauer.AGauge MixerAkımSlumMeter;
        private System.Windows.Forms.Label XB2_AgregaKantar;
        private System.Windows.Forms.Label XB3_CMKantar;
        private System.Windows.Forms.Label XB5_KatKantar;
        private System.Windows.Forms.Label XB4_SuKantar;
        private System.Windows.Forms.Label XB1_Frekans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label XB1_ToplamAkim;
        private System.Windows.Forms.Label XB1_Voltaj3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label XB1_Voltaj2;
        private System.Windows.Forms.Label XB1_Voltaj1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Hx;
        private System.Windows.Forms.Label Amp;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MixerGraph;
    }
}
