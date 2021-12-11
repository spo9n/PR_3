using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practice1_Surgai_P81
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (temperatureTextBox.Text.Length == 0 || pressureTextBox.Text.Length == 0)
            {
                MessageBox.Show("Необхідно заповнити усі поля!");
            }
            else
            {
                string pathToFile = "data.txt";

                dataGridView.Rows.Add(dateTimePicker.Value.ToString(), temperatureTextBox.Text, pressureTextBox.Text);

                try
                {
                    using (StreamWriter sw = new StreamWriter(pathToFile, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(dateTimePicker.Value.ToString() + "; Temperature = " + temperatureTextBox.Text + "; Pressure = " + pressureTextBox.Text + ".");
                    }

                    MessageBox.Show("Запис створено!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Помилка! " + exception);
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value.ToString() != searchDateDateTimePicker.Value.ToString())
                {
                    dataGridView.Rows[i].Visible = false;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Visible = true;
            }
        }
    }
}