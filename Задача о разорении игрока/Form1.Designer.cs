namespace Part3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.probWin = new System.Windows.Forms.NumericUpDown();
            this.amCasino = new System.Windows.Forms.NumericUpDown();
            this.amYours = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.probLose = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amGames = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.probLoseEth = new System.Windows.Forms.TextBox();
            this.factProbLose = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.probWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amCasino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amYours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amGames)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вероятность победы в 1-ой игре";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во денег соперника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кол-во Ваших денег";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вероятность проигрыша в 1-ой игре";
            // 
            // probWin
            // 
            this.probWin.DecimalPlaces = 2;
            this.probWin.Location = new System.Drawing.Point(26, 69);
            this.probWin.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probWin.Name = "probWin";
            this.probWin.Size = new System.Drawing.Size(120, 20);
            this.probWin.TabIndex = 5;
            this.probWin.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
            // 
            // amCasino
            // 
            this.amCasino.Location = new System.Drawing.Point(167, 228);
            this.amCasino.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.amCasino.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amCasino.Name = "amCasino";
            this.amCasino.Size = new System.Drawing.Size(120, 20);
            this.amCasino.TabIndex = 6;
            this.amCasino.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // amYours
            // 
            this.amYours.Location = new System.Drawing.Point(167, 190);
            this.amYours.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.amYours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amYours.Name = "amYours";
            this.amYours.Size = new System.Drawing.Size(120, 20);
            this.amYours.TabIndex = 8;
            this.amYours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea5.AxisX.Maximum = 3D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(360, 32);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.IsXValueIndexed = true;
            series5.Name = "Series1";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(530, 452);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // probLose
            // 
            this.probLose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.probLose.Enabled = false;
            this.probLose.Location = new System.Drawing.Point(26, 129);
            this.probLose.Name = "probLose";
            this.probLose.Size = new System.Drawing.Size(120, 20);
            this.probLose.TabIndex = 11;
            this.probLose.Text = "auto";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(87, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Игра!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во игр";
            // 
            // amGames
            // 
            this.amGames.Location = new System.Drawing.Point(167, 267);
            this.amGames.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amGames.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amGames.Name = "amGames";
            this.amGames.Size = new System.Drawing.Size(120, 20);
            this.amGames.TabIndex = 14;
            this.amGames.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Вероятность разорения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Фактический процент проигрышей";
            // 
            // probLoseEth
            // 
            this.probLoseEth.Enabled = false;
            this.probLoseEth.Location = new System.Drawing.Point(31, 348);
            this.probLoseEth.Name = "probLoseEth";
            this.probLoseEth.Size = new System.Drawing.Size(100, 20);
            this.probLoseEth.TabIndex = 18;
            this.probLoseEth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // factProbLose
            // 
            this.factProbLose.Enabled = false;
            this.factProbLose.Location = new System.Drawing.Point(200, 348);
            this.factProbLose.Name = "factProbLose";
            this.factProbLose.Size = new System.Drawing.Size(100, 20);
            this.factProbLose.TabIndex = 19;
            this.factProbLose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(532, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Поражения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(695, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Победы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 496);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.factProbLose);
            this.Controls.Add(this.probLoseEth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amGames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.probLose);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.amYours);
            this.Controls.Add(this.amCasino);
            this.Controls.Add(this.probWin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Задача о разорении игрока";
            ((System.ComponentModel.ISupportInitialize)(this.probWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amCasino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amYours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown probWin;
        private System.Windows.Forms.NumericUpDown amCasino;
        private System.Windows.Forms.NumericUpDown amYours;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox probLose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown amGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox probLoseEth;
        private System.Windows.Forms.TextBox factProbLose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

