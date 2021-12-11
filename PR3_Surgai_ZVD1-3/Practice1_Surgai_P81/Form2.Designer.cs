
namespace Practice1_Surgai_P81
{
    partial class Form2
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
            this.firstDateLabel = new System.Windows.Forms.Label();
            this.secondDateLabel = new System.Windows.Forms.Label();
            this.okDateLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.firstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.secondDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstDateLabel
            // 
            this.firstDateLabel.AutoSize = true;
            this.firstDateLabel.Location = new System.Drawing.Point(36, 28);
            this.firstDateLabel.Name = "firstDateLabel";
            this.firstDateLabel.Size = new System.Drawing.Size(107, 13);
            this.firstDateLabel.TabIndex = 0;
            this.firstDateLabel.Text = "Введіть першу дату:";
            // 
            // secondDateLabel
            // 
            this.secondDateLabel.AutoSize = true;
            this.secondDateLabel.Location = new System.Drawing.Point(36, 60);
            this.secondDateLabel.Name = "secondDateLabel";
            this.secondDateLabel.Size = new System.Drawing.Size(103, 13);
            this.secondDateLabel.TabIndex = 1;
            this.secondDateLabel.Text = "Введіть другу дату:";
            // 
            // okDateLabel
            // 
            this.okDateLabel.AutoSize = true;
            this.okDateLabel.Location = new System.Drawing.Point(63, 99);
            this.okDateLabel.Name = "okDateLabel";
            this.okDateLabel.Size = new System.Drawing.Size(244, 13);
            this.okDateLabel.TabIndex = 2;
            this.okDateLabel.Text = "Визначення проміжку часу поміж цими датами";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(150, 129);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(23, 181);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(45, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "в роках";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(13, 213);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(55, 13);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "в місяцях";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(29, 246);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(39, 13);
            this.dayLabel.TabIndex = 6;
            this.dayLabel.Text = "в днях";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(199, 213);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(56, 13);
            this.hourLabel.TabIndex = 7;
            this.hourLabel.Text = "в годинах";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(193, 246);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(62, 13);
            this.secondsLabel.TabIndex = 8;
            this.secondsLabel.Text = "в хвилинах";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(78, 178);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 9;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(78, 210);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 10;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(78, 243);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayTextBox.TabIndex = 11;
            // 
            // hourTextBox
            // 
            this.hourTextBox.Location = new System.Drawing.Point(261, 210);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourTextBox.TabIndex = 12;
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Location = new System.Drawing.Point(261, 243);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(100, 20);
            this.minuteTextBox.TabIndex = 13;
            // 
            // firstDateTimePicker
            // 
            this.firstDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstDateTimePicker.Location = new System.Drawing.Point(150, 28);
            this.firstDateTimePicker.Name = "firstDateTimePicker";
            this.firstDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.firstDateTimePicker.TabIndex = 14;
            // 
            // secondDateTimePicker
            // 
            this.secondDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.secondDateTimePicker.Location = new System.Drawing.Point(150, 60);
            this.secondDateTimePicker.Name = "secondDateTimePicker";
            this.secondDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.secondDateTimePicker.TabIndex = 15;
            // 
            // nextButton2
            // 
            this.nextButton2.Location = new System.Drawing.Point(286, 280);
            this.nextButton2.Name = "nextButton2";
            this.nextButton2.Size = new System.Drawing.Size(75, 23);
            this.nextButton2.TabIndex = 16;
            this.nextButton2.Text = "Далі";
            this.nextButton2.UseVisualStyleBackColor = true;
            this.nextButton2.Click += new System.EventHandler(this.nextButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 315);
            this.Controls.Add(this.nextButton2);
            this.Controls.Add(this.secondDateTimePicker);
            this.Controls.Add(this.firstDateTimePicker);
            this.Controls.Add(this.minuteTextBox);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.okDateLabel);
            this.Controls.Add(this.secondDateLabel);
            this.Controls.Add(this.firstDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task 2.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstDateLabel;
        private System.Windows.Forms.Label secondDateLabel;
        private System.Windows.Forms.Label okDateLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.DateTimePicker firstDateTimePicker;
        private System.Windows.Forms.DateTimePicker secondDateTimePicker;
        private System.Windows.Forms.Button nextButton2;
    }
}