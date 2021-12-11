
namespace Practice1_Surgai_P81
{
    partial class Form4
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.searchDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchDateLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(82, 56);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата:";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(41, 99);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(77, 13);
            this.temperatureLabel.TabIndex = 1;
            this.temperatureLabel.Text = "Температура:";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(12, 138);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(106, 13);
            this.pressureLabel.TabIndex = 2;
            this.pressureLabel.Text = "Атмосферний тиск:";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(124, 96);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(160, 20);
            this.temperatureTextBox.TabIndex = 3;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Location = new System.Drawing.Point(124, 138);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(160, 20);
            this.pressureTextBox.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(124, 56);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(104, 185);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 46);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Створити запис";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.temperatureColumn,
            this.pressureColumn});
            this.dataGridView.Location = new System.Drawing.Point(370, 96);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(346, 150);
            this.dataGridView.TabIndex = 8;
            // 
            // searchDateDateTimePicker
            // 
            this.searchDateDateTimePicker.Location = new System.Drawing.Point(370, 56);
            this.searchDateDateTimePicker.Name = "searchDateDateTimePicker";
            this.searchDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.searchDateDateTimePicker.TabIndex = 9;
            // 
            // searchDateLabel
            // 
            this.searchDateLabel.AutoSize = true;
            this.searchDateLabel.Location = new System.Drawing.Point(367, 33);
            this.searchDateLabel.Name = "searchDateLabel";
            this.searchDateLabel.Size = new System.Drawing.Size(74, 13);
            this.searchDateLabel.TabIndex = 10;
            this.searchDateLabel.Text = "Оберіть дату:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(611, 253);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(105, 30);
            this.findButton.TabIndex = 11;
            this.findButton.Text = "Знайти записи";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Дата";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // temperatureColumn
            // 
            this.temperatureColumn.HeaderText = "Температура";
            this.temperatureColumn.Name = "temperatureColumn";
            this.temperatureColumn.ReadOnly = true;
            // 
            // pressureColumn
            // 
            this.pressureColumn.HeaderText = "Атмосферний тиск";
            this.pressureColumn.Name = "pressureColumn";
            this.pressureColumn.ReadOnly = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(370, 253);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 30);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Скидання";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 295);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.searchDateLabel);
            this.Controls.Add(this.searchDateDateTimePicker);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.dateLabel);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task 3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker searchDateDateTimePicker;
        private System.Windows.Forms.Label searchDateLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureColumn;
        private System.Windows.Forms.Button resetButton;
    }
}