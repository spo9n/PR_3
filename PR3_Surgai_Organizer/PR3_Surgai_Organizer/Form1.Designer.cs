
namespace PR3_Surgai_Organizer
{
    partial class MainForm
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
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Location = new System.Drawing.Point(24, 63);
            this.endDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.endDateDateTimePicker.TabIndex = 0;
            // 
            // selectDateLabel
            // 
            this.selectDateLabel.AutoSize = true;
            this.selectDateLabel.Location = new System.Drawing.Point(21, 43);
            this.selectDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectDateLabel.Name = "selectDateLabel";
            this.selectDateLabel.Size = new System.Drawing.Size(242, 16);
            this.selectDateLabel.TabIndex = 1;
            this.selectDateLabel.Text = "Оберіть кінцевий термін виконання:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зміст завдання:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(82, 289);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 49);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Додати запис";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.Location = new System.Drawing.Point(27, 127);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(262, 150);
            this.textRichTextBox.TabIndex = 4;
            this.textRichTextBox.Text = "";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateColumn,
            this.endDateColumn,
            this.textColumn,
            this.statusColumn});
            this.dataGridView.Location = new System.Drawing.Point(328, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(449, 234);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(633, 289);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(144, 49);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Видалити запис";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // startDateColumn
            // 
            this.startDateColumn.HeaderText = "Дата створення";
            this.startDateColumn.Name = "startDateColumn";
            // 
            // endDateColumn
            // 
            this.endDateColumn.HeaderText = "Кінцевий термін виконання";
            this.endDateColumn.Name = "endDateColumn";
            // 
            // textColumn
            // 
            this.textColumn.HeaderText = "Зміст";
            this.textColumn.Name = "textColumn";
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Статус";
            this.statusColumn.Name = "statusColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 351);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textRichTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сургай П-81";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.Label selectDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
    }
}

