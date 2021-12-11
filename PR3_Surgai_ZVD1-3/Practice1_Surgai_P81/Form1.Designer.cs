
namespace Practice1_Surgai_P81
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.selectedDateLabel1 = new System.Windows.Forms.Label();
            this.selectedDateLabel2 = new System.Windows.Forms.Label();
            this.nextButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(62, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // selectedDateLabel1
            // 
            this.selectedDateLabel1.AutoSize = true;
            this.selectedDateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedDateLabel1.Location = new System.Drawing.Point(313, 152);
            this.selectedDateLabel1.Name = "selectedDateLabel1";
            this.selectedDateLabel1.Size = new System.Drawing.Size(112, 20);
            this.selectedDateLabel1.TabIndex = 2;
            this.selectedDateLabel1.Text = "Обрана дата:";
            // 
            // selectedDateLabel2
            // 
            this.selectedDateLabel2.AutoSize = true;
            this.selectedDateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedDateLabel2.Location = new System.Drawing.Point(431, 152);
            this.selectedDateLabel2.Name = "selectedDateLabel2";
            this.selectedDateLabel2.Size = new System.Drawing.Size(0, 20);
            this.selectedDateLabel2.TabIndex = 3;
            // 
            // nextButton1
            // 
            this.nextButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton1.Location = new System.Drawing.Point(540, 286);
            this.nextButton1.Name = "nextButton1";
            this.nextButton1.Size = new System.Drawing.Size(92, 33);
            this.nextButton1.TabIndex = 4;
            this.nextButton1.Text = "Далі";
            this.nextButton1.UseVisualStyleBackColor = true;
            this.nextButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 341);
            this.Controls.Add(this.nextButton1);
            this.Controls.Add(this.selectedDateLabel2);
            this.Controls.Add(this.selectedDateLabel1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label selectedDateLabel1;
        private System.Windows.Forms.Label selectedDateLabel2;
        private System.Windows.Forms.Button nextButton1;
    }
}

