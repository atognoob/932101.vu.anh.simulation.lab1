namespace Flight
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edStep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EndSpeed5 = new System.Windows.Forms.TextBox();
            this.MH5 = new System.Windows.Forms.TextBox();
            this.Distance5 = new System.Windows.Forms.TextBox();
            this.TimeStep5 = new System.Windows.Forms.TextBox();
            this.EndSpeed4 = new System.Windows.Forms.TextBox();
            this.MH4 = new System.Windows.Forms.TextBox();
            this.Distance4 = new System.Windows.Forms.TextBox();
            this.TimeStep4 = new System.Windows.Forms.TextBox();
            this.EndSpeed3 = new System.Windows.Forms.TextBox();
            this.MH3 = new System.Windows.Forms.TextBox();
            this.Distance3 = new System.Windows.Forms.TextBox();
            this.TimeStep3 = new System.Windows.Forms.TextBox();
            this.EndSpeed2 = new System.Windows.Forms.TextBox();
            this.MH2 = new System.Windows.Forms.TextBox();
            this.Distance2 = new System.Windows.Forms.TextBox();
            this.TimeStep2 = new System.Windows.Forms.TextBox();
            this.EndSpeed1 = new System.Windows.Forms.TextBox();
            this.MH1 = new System.Windows.Forms.TextBox();
            this.Distance1 = new System.Windows.Forms.TextBox();
            this.TimeStep1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edStep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 133);
            this.panel1.TabIndex = 0;
            // 
            // edStep
            // 
            this.edStep.DecimalPlaces = 3;
            this.edStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edStep.Location = new System.Drawing.Point(269, 27);
            this.edStep.Name = "edStep";
            this.edStep.Size = new System.Drawing.Size(120, 20);
            this.edStep.TabIndex = 12;
            this.edStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Step";
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonStart.Location = new System.Drawing.Point(269, 74);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 42);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // edSize
            // 
            this.edSize.Location = new System.Drawing.Point(269, 1);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 20);
            this.edSize.TabIndex = 9;
            this.edSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // edWeight
            // 
            this.edWeight.Location = new System.Drawing.Point(56, 79);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(120, 20);
            this.edWeight.TabIndex = 8;
            this.edWeight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(56, 53);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 20);
            this.edAngle.TabIndex = 7;
            this.edAngle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(56, 27);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 20);
            this.edSpeed.TabIndex = 6;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(56, 1);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 20);
            this.edHeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.BorderWidth = 3;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 139);
            this.chart1.Name = "chart1";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "[1]";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "[2]";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "[3]";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "[4]";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "[5]";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(747, 418);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "TimeStep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Distance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "MaxHeight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(398, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "SpeedAtTheEndPoint";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.EndSpeed5);
            this.panel2.Controls.Add(this.MH5);
            this.panel2.Controls.Add(this.Distance5);
            this.panel2.Controls.Add(this.TimeStep5);
            this.panel2.Controls.Add(this.EndSpeed4);
            this.panel2.Controls.Add(this.MH4);
            this.panel2.Controls.Add(this.Distance4);
            this.panel2.Controls.Add(this.TimeStep4);
            this.panel2.Controls.Add(this.EndSpeed3);
            this.panel2.Controls.Add(this.MH3);
            this.panel2.Controls.Add(this.Distance3);
            this.panel2.Controls.Add(this.TimeStep3);
            this.panel2.Controls.Add(this.EndSpeed2);
            this.panel2.Controls.Add(this.MH2);
            this.panel2.Controls.Add(this.Distance2);
            this.panel2.Controls.Add(this.TimeStep2);
            this.panel2.Controls.Add(this.EndSpeed1);
            this.panel2.Controls.Add(this.MH1);
            this.panel2.Controls.Add(this.Distance1);
            this.panel2.Controls.Add(this.TimeStep1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(753, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 554);
            this.panel2.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "[5]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "[4]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "[3]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "[2]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "[1]";
            // 
            // EndSpeed5
            // 
            this.EndSpeed5.Location = new System.Drawing.Point(427, 217);
            this.EndSpeed5.Name = "EndSpeed5";
            this.EndSpeed5.ReadOnly = true;
            this.EndSpeed5.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed5.TabIndex = 27;
            // 
            // MH5
            // 
            this.MH5.Location = new System.Drawing.Point(309, 217);
            this.MH5.Name = "MH5";
            this.MH5.ReadOnly = true;
            this.MH5.Size = new System.Drawing.Size(65, 20);
            this.MH5.TabIndex = 26;
            // 
            // Distance5
            // 
            this.Distance5.Location = new System.Drawing.Point(202, 217);
            this.Distance5.Name = "Distance5";
            this.Distance5.ReadOnly = true;
            this.Distance5.Size = new System.Drawing.Size(65, 20);
            this.Distance5.TabIndex = 25;
            // 
            // TimeStep5
            // 
            this.TimeStep5.Location = new System.Drawing.Point(100, 217);
            this.TimeStep5.Name = "TimeStep5";
            this.TimeStep5.ReadOnly = true;
            this.TimeStep5.Size = new System.Drawing.Size(65, 20);
            this.TimeStep5.TabIndex = 24;
            // 
            // EndSpeed4
            // 
            this.EndSpeed4.Location = new System.Drawing.Point(427, 174);
            this.EndSpeed4.Name = "EndSpeed4";
            this.EndSpeed4.ReadOnly = true;
            this.EndSpeed4.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed4.TabIndex = 23;
            // 
            // MH4
            // 
            this.MH4.Location = new System.Drawing.Point(309, 174);
            this.MH4.Name = "MH4";
            this.MH4.ReadOnly = true;
            this.MH4.Size = new System.Drawing.Size(65, 20);
            this.MH4.TabIndex = 22;
            // 
            // Distance4
            // 
            this.Distance4.Location = new System.Drawing.Point(202, 174);
            this.Distance4.Name = "Distance4";
            this.Distance4.ReadOnly = true;
            this.Distance4.Size = new System.Drawing.Size(65, 20);
            this.Distance4.TabIndex = 21;
            // 
            // TimeStep4
            // 
            this.TimeStep4.Location = new System.Drawing.Point(100, 174);
            this.TimeStep4.Name = "TimeStep4";
            this.TimeStep4.ReadOnly = true;
            this.TimeStep4.Size = new System.Drawing.Size(65, 20);
            this.TimeStep4.TabIndex = 20;
            // 
            // EndSpeed3
            // 
            this.EndSpeed3.Location = new System.Drawing.Point(427, 125);
            this.EndSpeed3.Name = "EndSpeed3";
            this.EndSpeed3.ReadOnly = true;
            this.EndSpeed3.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed3.TabIndex = 19;
            // 
            // MH3
            // 
            this.MH3.Location = new System.Drawing.Point(309, 125);
            this.MH3.Name = "MH3";
            this.MH3.ReadOnly = true;
            this.MH3.Size = new System.Drawing.Size(65, 20);
            this.MH3.TabIndex = 18;
            // 
            // Distance3
            // 
            this.Distance3.Location = new System.Drawing.Point(202, 125);
            this.Distance3.Name = "Distance3";
            this.Distance3.ReadOnly = true;
            this.Distance3.Size = new System.Drawing.Size(65, 20);
            this.Distance3.TabIndex = 17;
            // 
            // TimeStep3
            // 
            this.TimeStep3.Location = new System.Drawing.Point(100, 125);
            this.TimeStep3.Name = "TimeStep3";
            this.TimeStep3.ReadOnly = true;
            this.TimeStep3.Size = new System.Drawing.Size(65, 20);
            this.TimeStep3.TabIndex = 16;
            // 
            // EndSpeed2
            // 
            this.EndSpeed2.Location = new System.Drawing.Point(427, 74);
            this.EndSpeed2.Name = "EndSpeed2";
            this.EndSpeed2.ReadOnly = true;
            this.EndSpeed2.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed2.TabIndex = 15;
            // 
            // MH2
            // 
            this.MH2.Location = new System.Drawing.Point(309, 74);
            this.MH2.Name = "MH2";
            this.MH2.ReadOnly = true;
            this.MH2.Size = new System.Drawing.Size(65, 20);
            this.MH2.TabIndex = 14;
            // 
            // Distance2
            // 
            this.Distance2.Location = new System.Drawing.Point(202, 74);
            this.Distance2.Name = "Distance2";
            this.Distance2.ReadOnly = true;
            this.Distance2.Size = new System.Drawing.Size(65, 20);
            this.Distance2.TabIndex = 13;
            // 
            // TimeStep2
            // 
            this.TimeStep2.Location = new System.Drawing.Point(100, 74);
            this.TimeStep2.Name = "TimeStep2";
            this.TimeStep2.ReadOnly = true;
            this.TimeStep2.Size = new System.Drawing.Size(65, 20);
            this.TimeStep2.TabIndex = 12;
            // 
            // EndSpeed1
            // 
            this.EndSpeed1.Location = new System.Drawing.Point(427, 31);
            this.EndSpeed1.Name = "EndSpeed1";
            this.EndSpeed1.ReadOnly = true;
            this.EndSpeed1.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed1.TabIndex = 11;
            // 
            // MH1
            // 
            this.MH1.Location = new System.Drawing.Point(309, 31);
            this.MH1.Name = "MH1";
            this.MH1.ReadOnly = true;
            this.MH1.Size = new System.Drawing.Size(65, 20);
            this.MH1.TabIndex = 10;
            // 
            // Distance1
            // 
            this.Distance1.Location = new System.Drawing.Point(202, 31);
            this.Distance1.Name = "Distance1";
            this.Distance1.ReadOnly = true;
            this.Distance1.Size = new System.Drawing.Size(65, 20);
            this.Distance1.TabIndex = 9;
            // 
            // TimeStep1
            // 
            this.TimeStep1.Location = new System.Drawing.Point(100, 31);
            this.TimeStep1.Name = "TimeStep1";
            this.TimeStep1.ReadOnly = true;
            this.TimeStep1.Size = new System.Drawing.Size(65, 20);
            this.TimeStep1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EndSpeed5;
        private System.Windows.Forms.TextBox MH5;
        private System.Windows.Forms.TextBox Distance5;
        private System.Windows.Forms.TextBox TimeStep5;
        private System.Windows.Forms.TextBox EndSpeed4;
        private System.Windows.Forms.TextBox MH4;
        private System.Windows.Forms.TextBox Distance4;
        private System.Windows.Forms.TextBox TimeStep4;
        private System.Windows.Forms.TextBox EndSpeed3;
        private System.Windows.Forms.TextBox MH3;
        private System.Windows.Forms.TextBox Distance3;
        private System.Windows.Forms.TextBox TimeStep3;
        private System.Windows.Forms.TextBox EndSpeed2;
        private System.Windows.Forms.TextBox MH2;
        private System.Windows.Forms.TextBox Distance2;
        private System.Windows.Forms.TextBox TimeStep2;
        private System.Windows.Forms.TextBox EndSpeed1;
        private System.Windows.Forms.TextBox MH1;
        private System.Windows.Forms.TextBox Distance1;
        private System.Windows.Forms.TextBox TimeStep1;
        private System.Windows.Forms.NumericUpDown edStep;
    }
}

