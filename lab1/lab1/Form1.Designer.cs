﻿namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(80, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "-4.41";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(80, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "11.25";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(80, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "0.6";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(270, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(80, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "0.7";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(422, 39);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 4;
            button1.Text = "Розрахунок";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 5;
            label1.Text = "Xn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 18);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 6;
            label2.Text = "Xk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 18);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 7;
            label3.Text = "h";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 18);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 8;
            label4.Text = "a";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView1.Location = new Point(12, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(294, 337);
            dataGridView1.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(333, 121);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(397, 317);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // x
            // 
            x.HeaderText = "x";
            x.MinimumWidth = 6;
            x.Name = "x";
            x.Width = 125;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.MinimumWidth = 6;
            y.Name = "y";
            y.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
    }
}
