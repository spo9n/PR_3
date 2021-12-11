using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_Surgai_Organizer
{
    public partial class MainForm : Form
    {
        int rowIndex = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textRichTextBox.Text.Length == 0)
            {
                MessageBox.Show("Необхідно написати зміст завдання!");
            }
            else
            {
                dataGridView.Rows.Add(DateTime.Now.ToShortDateString(), endDateDateTimePicker.Value.ToShortDateString(), textRichTextBox.Text, "Не виконано");
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rowIndex != -1)
            {
                try
                {
                    dataGridView.Rows.RemoveAt(rowIndex);
                    dataGridView.Refresh();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Помилка: " + exception);
                }
            }
            else
            {
                MessageBox.Show("Для видалення необхідно обрати запис!");
            }
        }
    }
}