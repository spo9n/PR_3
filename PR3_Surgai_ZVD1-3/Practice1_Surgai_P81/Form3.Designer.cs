
namespace Practice1_Surgai_P81
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondsRadioButton = new System.Windows.Forms.RadioButton();
            this.minuteRadioButton = new System.Windows.Forms.RadioButton();
            this.hourRadioButton = new System.Windows.Forms.RadioButton();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.setTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.newDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nextButton3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть початкове значення дати/часу";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(77, 41);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(154, 20);
            this.startDateTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secondsRadioButton);
            this.groupBox1.Controls.Add(this.minuteRadioButton);
            this.groupBox1.Controls.Add(this.hourRadioButton);
            this.groupBox1.Controls.Add(this.dayRadioButton);
            this.groupBox1.Controls.Add(this.weekRadioButton);
            this.groupBox1.Controls.Add(this.monthRadioButton);
            this.groupBox1.Controls.Add(this.yearRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(54, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Змінити дату на";
            // 
            // secondsRadioButton
            // 
            this.secondsRadioButton.AutoSize = true;
            this.secondsRadioButton.Location = new System.Drawing.Point(7, 159);
            this.secondsRadioButton.Name = "secondsRadioButton";
            this.secondsRadioButton.Size = new System.Drawing.Size(66, 17);
            this.secondsRadioButton.TabIndex = 6;
            this.secondsRadioButton.TabStop = true;
            this.secondsRadioButton.Text = "секунди";
            this.secondsRadioButton.UseVisualStyleBackColor = true;
            // 
            // minuteRadioButton
            // 
            this.minuteRadioButton.AutoSize = true;
            this.minuteRadioButton.Location = new System.Drawing.Point(7, 135);
            this.minuteRadioButton.Name = "minuteRadioButton";
            this.minuteRadioButton.Size = new System.Drawing.Size(66, 17);
            this.minuteRadioButton.TabIndex = 5;
            this.minuteRadioButton.TabStop = true;
            this.minuteRadioButton.Text = "хвилини";
            this.minuteRadioButton.UseVisualStyleBackColor = true;
            // 
            // hourRadioButton
            // 
            this.hourRadioButton.AutoSize = true;
            this.hourRadioButton.Location = new System.Drawing.Point(7, 112);
            this.hourRadioButton.Name = "hourRadioButton";
            this.hourRadioButton.Size = new System.Drawing.Size(60, 17);
            this.hourRadioButton.TabIndex = 4;
            this.hourRadioButton.TabStop = true;
            this.hourRadioButton.Text = "години";
            this.hourRadioButton.UseVisualStyleBackColor = true;
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(7, 89);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(39, 17);
            this.dayRadioButton.TabIndex = 3;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "дні";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Location = new System.Drawing.Point(7, 66);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(52, 17);
            this.weekRadioButton.TabIndex = 2;
            this.weekRadioButton.TabStop = true;
            this.weekRadioButton.Text = "тижні";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(7, 43);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(55, 17);
            this.monthRadioButton.TabIndex = 1;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "місяці";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Location = new System.Drawing.Point(7, 20);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(49, 17);
            this.yearRadioButton.TabIndex = 0;
            this.yearRadioButton.TabStop = true;
            this.yearRadioButton.Text = "роки";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "На яке значення потрібно змінити";
            // 
            // setTextBox
            // 
            this.setTextBox.Location = new System.Drawing.Point(218, 291);
            this.setTextBox.Name = "setTextBox";
            this.setTextBox.Size = new System.Drawing.Size(36, 20);
            this.setTextBox.TabIndex = 4;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(103, 326);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(109, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Змінити дату";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // newDateTextBox
            // 
            this.newDateTextBox.Location = new System.Drawing.Point(77, 397);
            this.newDateTextBox.Name = "newDateTextBox";
            this.newDateTextBox.Size = new System.Drawing.Size(154, 20);
            this.newDateTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Нова дата/час";
            // 
            // nextButton3
            // 
            this.nextButton3.Location = new System.Drawing.Point(218, 434);
            this.nextButton3.Name = "nextButton3";
            this.nextButton3.Size = new System.Drawing.Size(75, 23);
            this.nextButton3.TabIndex = 17;
            this.nextButton3.Text = "Далі";
            this.nextButton3.UseVisualStyleBackColor = true;
            this.nextButton3.Click += new System.EventHandler(this.nextButton3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 469);
            this.Controls.Add(this.nextButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newDateTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.setTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task 2.2";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton secondsRadioButton;
        private System.Windows.Forms.RadioButton minuteRadioButton;
        private System.Windows.Forms.RadioButton hourRadioButton;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox newDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextButton3;
    }
}