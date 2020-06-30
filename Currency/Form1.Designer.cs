namespace Currency
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWthrBadIdeal = new System.Windows.Forms.Label();
            this.labelWthrMediumIdeal = new System.Windows.Forms.Label();
            this.labelWthrGoodIdeal = new System.Windows.Forms.Label();
            this.labelWthrBad = new System.Windows.Forms.Label();
            this.labelWthrMedium = new System.Windows.Forms.Label();
            this.labelWthrGood = new System.Windows.Forms.Label();
            this.hourCount = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.Button();
            this.hours = new System.Windows.Forms.Label();
            this.hoursOfWish = new System.Windows.Forms.NumericUpDown();
            this.wish = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursOfWish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelWthrBadIdeal);
            this.panel1.Controls.Add(this.labelWthrMediumIdeal);
            this.panel1.Controls.Add(this.labelWthrGoodIdeal);
            this.panel1.Controls.Add(this.labelWthrBad);
            this.panel1.Controls.Add(this.labelWthrMedium);
            this.panel1.Controls.Add(this.labelWthrGood);
            this.panel1.Controls.Add(this.hourCount);
            this.panel1.Controls.Add(this.btCalc);
            this.panel1.Controls.Add(this.hours);
            this.panel1.Controls.Add(this.hoursOfWish);
            this.panel1.Controls.Add(this.wish);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 100);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1087, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "3 - Дождь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1065, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "2 - Пасмурно";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1097, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "1 - Ясно";
            // 
            // labelWthrBadIdeal
            // 
            this.labelWthrBadIdeal.AutoSize = true;
            this.labelWthrBadIdeal.Location = new System.Drawing.Point(736, 55);
            this.labelWthrBadIdeal.Name = "labelWthrBadIdeal";
            this.labelWthrBadIdeal.Size = new System.Drawing.Size(46, 17);
            this.labelWthrBadIdeal.TabIndex = 15;
            this.labelWthrBadIdeal.Text = "label6";
            // 
            // labelWthrMediumIdeal
            // 
            this.labelWthrMediumIdeal.AutoSize = true;
            this.labelWthrMediumIdeal.Location = new System.Drawing.Point(736, 34);
            this.labelWthrMediumIdeal.Name = "labelWthrMediumIdeal";
            this.labelWthrMediumIdeal.Size = new System.Drawing.Size(46, 17);
            this.labelWthrMediumIdeal.TabIndex = 14;
            this.labelWthrMediumIdeal.Text = "label5";
            // 
            // labelWthrGoodIdeal
            // 
            this.labelWthrGoodIdeal.AutoSize = true;
            this.labelWthrGoodIdeal.Location = new System.Drawing.Point(736, 13);
            this.labelWthrGoodIdeal.Name = "labelWthrGoodIdeal";
            this.labelWthrGoodIdeal.Size = new System.Drawing.Size(46, 17);
            this.labelWthrGoodIdeal.TabIndex = 13;
            this.labelWthrGoodIdeal.Text = "label4";
            // 
            // labelWthrBad
            // 
            this.labelWthrBad.AutoSize = true;
            this.labelWthrBad.Location = new System.Drawing.Point(469, 55);
            this.labelWthrBad.Name = "labelWthrBad";
            this.labelWthrBad.Size = new System.Drawing.Size(46, 17);
            this.labelWthrBad.TabIndex = 12;
            this.labelWthrBad.Text = "label3";
            // 
            // labelWthrMedium
            // 
            this.labelWthrMedium.AutoSize = true;
            this.labelWthrMedium.Location = new System.Drawing.Point(469, 34);
            this.labelWthrMedium.Name = "labelWthrMedium";
            this.labelWthrMedium.Size = new System.Drawing.Size(46, 17);
            this.labelWthrMedium.TabIndex = 11;
            this.labelWthrMedium.Text = "label2";
            // 
            // labelWthrGood
            // 
            this.labelWthrGood.AutoSize = true;
            this.labelWthrGood.Location = new System.Drawing.Point(469, 15);
            this.labelWthrGood.Name = "labelWthrGood";
            this.labelWthrGood.Size = new System.Drawing.Size(46, 17);
            this.labelWthrGood.TabIndex = 10;
            this.labelWthrGood.Text = "label1";
            // 
            // hourCount
            // 
            this.hourCount.AutoSize = true;
            this.hourCount.Location = new System.Drawing.Point(1097, 15);
            this.hourCount.Name = "hourCount";
            this.hourCount.Size = new System.Drawing.Size(55, 17);
            this.hourCount.TabIndex = 9;
            this.hourCount.Text = "Hour: 0";
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(284, 13);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(129, 59);
            this.btCalc.TabIndex = 5;
            this.btCalc.Text = "Рассчитать";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(227, 36);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(46, 17);
            this.hours.TabIndex = 4;
            this.hours.Text = "часов";
            // 
            // hoursOfWish
            // 
            this.hoursOfWish.Location = new System.Drawing.Point(101, 34);
            this.hoursOfWish.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.hoursOfWish.Name = "hoursOfWish";
            this.hoursOfWish.Size = new System.Drawing.Size(120, 22);
            this.hoursOfWish.TabIndex = 3;
            // 
            // wish
            // 
            this.wish.AutoSize = true;
            this.wish.Location = new System.Drawing.Point(13, 36);
            this.wish.Name = "wish";
            this.wish.Size = new System.Drawing.Size(82, 17);
            this.wish.TabIndex = 1;
            this.wish.Text = "Прогноз на";
            // 
            // chart1
            // 
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(13, 120);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1175, 678);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 810);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursOfWish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.NumericUpDown hoursOfWish;
        private System.Windows.Forms.Label wish;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label hourCount;
        private System.Windows.Forms.Label labelWthrBadIdeal;
        private System.Windows.Forms.Label labelWthrMediumIdeal;
        private System.Windows.Forms.Label labelWthrGoodIdeal;
        private System.Windows.Forms.Label labelWthrBad;
        private System.Windows.Forms.Label labelWthrMedium;
        private System.Windows.Forms.Label labelWthrGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

