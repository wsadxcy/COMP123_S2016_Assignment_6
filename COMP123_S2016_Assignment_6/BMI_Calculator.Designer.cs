namespace COMP123_S2016_Assignment_6
{
    partial class BMI_Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DotButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.EraceButton = new System.Windows.Forms.Button();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MyHeight = new System.Windows.Forms.Label();
            this.MyWeight = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMILable = new System.Windows.Forms.Label();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.DotButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 222);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DotButton
            // 
            this.DotButton.Location = new System.Drawing.Point(147, 168);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(67, 49);
            this.DotButton.TabIndex = 11;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(75, 168);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(66, 49);
            this.Button0.TabIndex = 10;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Crimson;
            this.ResetButton.Location = new System.Drawing.Point(3, 168);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(66, 49);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "R";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(147, 113);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(67, 49);
            this.Button3.TabIndex = 8;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(75, 113);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(66, 49);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(3, 113);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(66, 49);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(147, 58);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(67, 49);
            this.Button6.TabIndex = 5;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(75, 58);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(66, 49);
            this.Button5.TabIndex = 4;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(3, 58);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(66, 49);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(147, 3);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(67, 49);
            this.Button9.TabIndex = 2;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(75, 3);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(66, 49);
            this.Button8.TabIndex = 1;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(3, 3);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(66, 49);
            this.Button7.TabIndex = 0;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.BMI_CalculatorButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CalculateButton.Location = new System.Drawing.Point(235, 328);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(57, 109);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "=";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // EraceButton
            // 
            this.EraceButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EraceButton.Location = new System.Drawing.Point(159, 167);
            this.EraceButton.Name = "EraceButton";
            this.EraceButton.Size = new System.Drawing.Size(70, 42);
            this.EraceButton.TabIndex = 2;
            this.EraceButton.Text = "<-";
            this.EraceButton.UseVisualStyleBackColor = false;
            this.EraceButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // SwitchButton
            // 
            this.SwitchButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SwitchButton.Location = new System.Drawing.Point(235, 218);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(57, 104);
            this.SwitchButton.TabIndex = 3;
            this.SwitchButton.Text = "S";
            this.SwitchButton.UseVisualStyleBackColor = false;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.White;
            this.HeightTextBox.Location = new System.Drawing.Point(6, 39);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeightTextBox.Size = new System.Drawing.Size(141, 34);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.Click += new System.EventHandler(this.TextBoxFocusChange);
            this.HeightTextBox.TextChanged += new System.EventHandler(this.TextBoxFocusChange);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.Color.White;
            this.WeightTextBox.Location = new System.Drawing.Point(6, 106);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WeightTextBox.Size = new System.Drawing.Size(138, 34);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.Click += new System.EventHandler(this.TextBoxFocusChange);
            // 
            // MyHeight
            // 
            this.MyHeight.AutoSize = true;
            this.MyHeight.Location = new System.Drawing.Point(1, 9);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(156, 27);
            this.MyHeight.TabIndex = 6;
            this.MyHeight.Text = "My Height";
            // 
            // MyWeight
            // 
            this.MyWeight.AutoSize = true;
            this.MyWeight.Location = new System.Drawing.Point(1, 76);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(156, 27);
            this.MyWeight.TabIndex = 7;
            this.MyWeight.Text = "My Weight";
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.White;
            this.BMITextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Location = new System.Drawing.Point(6, 178);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(138, 34);
            this.BMITextBox.TabIndex = 8;
            // 
            // BMILable
            // 
            this.BMILable.AutoSize = true;
            this.BMILable.Location = new System.Drawing.Point(1, 148);
            this.BMILable.Name = "BMILable";
            this.BMILable.Size = new System.Drawing.Size(60, 27);
            this.BMILable.TabIndex = 9;
            this.BMILable.Text = "BMI";
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Location = new System.Drawing.Point(153, 13);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(126, 31);
            this.Metric.TabIndex = 10;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(153, 50);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(158, 31);
            this.Imperial.TabIndex = 11;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(153, 127);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(139, 34);
            this.ResultTextBox.TabIndex = 12;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(171, 97);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(108, 27);
            this.Result.TabIndex = 13;
            this.Result.Text = "Result";
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.Imperial);
            this.Controls.Add(this.Metric);
            this.Controls.Add(this.BMILable);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.MyWeight);
            this.Controls.Add(this.MyHeight);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.EraceButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMI_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_Calculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button EraceButton;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Label BMILable;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label Result;
    }
}

