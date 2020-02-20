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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.initPrice = new System.Windows.Forms.Label();
            this.wish = new System.Windows.Forms.Label();
            this.initialPrice = new System.Windows.Forms.NumericUpDown();
            this.daysOfWish = new System.Windows.Forms.NumericUpDown();
            this.days = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Label();
            this.dayCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysOfWish)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dayCount);
            this.panel1.Controls.Add(this.cash);
            this.panel1.Controls.Add(this.sellButton);
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.btCalc);
            this.panel1.Controls.Add(this.days);
            this.panel1.Controls.Add(this.daysOfWish);
            this.panel1.Controls.Add(this.initialPrice);
            this.panel1.Controls.Add(this.wish);
            this.panel1.Controls.Add(this.initPrice);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 100);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(13, 120);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f4";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1175, 678);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // initPrice
            // 
            this.initPrice.AutoSize = true;
            this.initPrice.Location = new System.Drawing.Point(13, 15);
            this.initPrice.Name = "initPrice";
            this.initPrice.Size = new System.Drawing.Size(121, 17);
            this.initPrice.TabIndex = 0;
            this.initPrice.Text = "Начальная цена:";
            // 
            // wish
            // 
            this.wish.AutoSize = true;
            this.wish.Location = new System.Drawing.Point(13, 50);
            this.wish.Name = "wish";
            this.wish.Size = new System.Drawing.Size(82, 17);
            this.wish.TabIndex = 1;
            this.wish.Text = "Прогноз на";
            // 
            // initialPrice
            // 
            this.initialPrice.DecimalPlaces = 4;
            this.initialPrice.Location = new System.Drawing.Point(140, 15);
            this.initialPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.initialPrice.Name = "initialPrice";
            this.initialPrice.Size = new System.Drawing.Size(120, 22);
            this.initialPrice.TabIndex = 2;
            // 
            // daysOfWish
            // 
            this.daysOfWish.Location = new System.Drawing.Point(101, 50);
            this.daysOfWish.Name = "daysOfWish";
            this.daysOfWish.Size = new System.Drawing.Size(120, 22);
            this.daysOfWish.TabIndex = 3;
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(227, 50);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(40, 17);
            this.days.TabIndex = 4;
            this.days.Text = "дней";
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
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(516, 15);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(100, 33);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(622, 15);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(103, 33);
            this.sellButton.TabIndex = 7;
            this.sellButton.Text = "Продать";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(516, 55);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(56, 17);
            this.cash.TabIndex = 8;
            this.cash.Text = "Cash: 0";
            // 
            // dayCount
            // 
            this.dayCount.AutoSize = true;
            this.dayCount.Location = new System.Drawing.Point(970, 15);
            this.dayCount.Name = "dayCount";
            this.dayCount.Size = new System.Drawing.Size(49, 17);
            this.dayCount.TabIndex = 9;
            this.dayCount.Text = "Day: 0";
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysOfWish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.NumericUpDown daysOfWish;
        private System.Windows.Forms.NumericUpDown initialPrice;
        private System.Windows.Forms.Label wish;
        private System.Windows.Forms.Label initPrice;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label cash;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label dayCount;
    }
}

