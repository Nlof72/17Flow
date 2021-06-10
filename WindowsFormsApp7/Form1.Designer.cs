
namespace WindowsFormsApp7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Modeling = new System.Windows.Forms.Button();
            this.Lambda1 = new System.Windows.Forms.NumericUpDown();
            this.Lambda2 = new System.Windows.Forms.NumericUpDown();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.T = new System.Windows.Forms.NumericUpDown();
            this.MeanDisc = new System.Windows.Forms.Label();
            this.VarDisc = new System.Windows.Forms.Label();
            this.ChiSquareDisc = new System.Windows.Forms.Label();
            this.MeanCon = new System.Windows.Forms.Label();
            this.VarCon = new System.Windows.Forms.Label();
            this.ChiSquareCon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lambda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lambda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T)).BeginInit();
            this.SuspendLayout();
            // 
            // Modeling
            // 
            this.Modeling.Location = new System.Drawing.Point(12, 192);
            this.Modeling.Name = "Modeling";
            this.Modeling.Size = new System.Drawing.Size(105, 41);
            this.Modeling.TabIndex = 0;
            this.Modeling.Text = "Modeling";
            this.Modeling.UseVisualStyleBackColor = true;
            this.Modeling.Click += new System.EventHandler(this.Modeling_Click);
            // 
            // Lambda1
            // 
            this.Lambda1.DecimalPlaces = 2;
            this.Lambda1.Location = new System.Drawing.Point(12, 12);
            this.Lambda1.Name = "Lambda1";
            this.Lambda1.Size = new System.Drawing.Size(120, 22);
            this.Lambda1.TabIndex = 1;
            this.Lambda1.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // Lambda2
            // 
            this.Lambda2.DecimalPlaces = 2;
            this.Lambda2.Location = new System.Drawing.Point(12, 53);
            this.Lambda2.Name = "Lambda2";
            this.Lambda2.Size = new System.Drawing.Size(120, 22);
            this.Lambda2.TabIndex = 2;
            this.Lambda2.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(12, 98);
            this.N.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 22);
            this.N.TabIndex = 3;
            this.N.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(346, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series6";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series8";
            series3.ChartArea = "ChartArea2";
            series3.Legend = "Legend1";
            series3.Name = "Series7";
            series4.ChartArea = "ChartArea2";
            series4.Legend = "Legend1";
            series4.Name = "Series3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(930, 594);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title1.DockedToChartArea = "ChartArea1";
            title1.Name = "Title1";
            title1.Text = "Discrete";
            title2.DockedToChartArea = "ChartArea2";
            title2.Name = "Title2";
            title2.Text = "Continuous";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(12, 140);
            this.T.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(120, 22);
            this.T.TabIndex = 5;
            this.T.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MeanDisc
            // 
            this.MeanDisc.AutoSize = true;
            this.MeanDisc.Location = new System.Drawing.Point(37, 270);
            this.MeanDisc.Name = "MeanDisc";
            this.MeanDisc.Size = new System.Drawing.Size(43, 17);
            this.MeanDisc.TabIndex = 6;
            this.MeanDisc.Text = "Mean";
            // 
            // VarDisc
            // 
            this.VarDisc.AutoSize = true;
            this.VarDisc.Location = new System.Drawing.Point(37, 323);
            this.VarDisc.Name = "VarDisc";
            this.VarDisc.Size = new System.Drawing.Size(30, 17);
            this.VarDisc.TabIndex = 7;
            this.VarDisc.Text = "Var";
            // 
            // ChiSquareDisc
            // 
            this.ChiSquareDisc.AutoSize = true;
            this.ChiSquareDisc.Location = new System.Drawing.Point(37, 387);
            this.ChiSquareDisc.Name = "ChiSquareDisc";
            this.ChiSquareDisc.Size = new System.Drawing.Size(55, 17);
            this.ChiSquareDisc.TabIndex = 8;
            this.ChiSquareDisc.Text = "ChiDisc";
            // 
            // MeanCon
            // 
            this.MeanCon.AutoSize = true;
            this.MeanCon.Location = new System.Drawing.Point(37, 447);
            this.MeanCon.Name = "MeanCon";
            this.MeanCon.Size = new System.Drawing.Size(68, 17);
            this.MeanCon.TabIndex = 9;
            this.MeanCon.Text = "MeanCon";
            // 
            // VarCon
            // 
            this.VarCon.AutoSize = true;
            this.VarCon.Location = new System.Drawing.Point(37, 500);
            this.VarCon.Name = "VarCon";
            this.VarCon.Size = new System.Drawing.Size(55, 17);
            this.VarCon.TabIndex = 10;
            this.VarCon.Text = "VarCon";
            // 
            // ChiSquareCon
            // 
            this.ChiSquareCon.AutoSize = true;
            this.ChiSquareCon.Location = new System.Drawing.Point(37, 550);
            this.ChiSquareCon.Name = "ChiSquareCon";
            this.ChiSquareCon.Size = new System.Drawing.Size(51, 17);
            this.ChiSquareCon.TabIndex = 11;
            this.ChiSquareCon.Text = "chiCon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "DiscreteStats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ContinuousStats";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChiSquareCon);
            this.Controls.Add(this.VarCon);
            this.Controls.Add(this.MeanCon);
            this.Controls.Add(this.ChiSquareDisc);
            this.Controls.Add(this.VarDisc);
            this.Controls.Add(this.MeanDisc);
            this.Controls.Add(this.T);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Lambda2);
            this.Controls.Add(this.Lambda1);
            this.Controls.Add(this.Modeling);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Lambda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lambda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Modeling;
        private System.Windows.Forms.NumericUpDown Lambda1;
        private System.Windows.Forms.NumericUpDown Lambda2;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown T;
        private System.Windows.Forms.Label MeanDisc;
        private System.Windows.Forms.Label VarDisc;
        private System.Windows.Forms.Label ChiSquareDisc;
        private System.Windows.Forms.Label MeanCon;
        private System.Windows.Forms.Label VarCon;
        private System.Windows.Forms.Label ChiSquareCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

