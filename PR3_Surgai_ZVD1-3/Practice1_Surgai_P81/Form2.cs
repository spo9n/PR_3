using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_Surgai_P81
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            yearTextBox.Text = Math.Abs((firstDateTimePicker.Value.Year - secondDateTimePicker.Value.Year)).ToString();

            monthTextBox.Text = Math.Abs((firstDateTimePicker.Value.Month - secondDateTimePicker.Value.Month)).ToString();

            dayTextBox.Text = Math.Abs((firstDateTimePicker.Value - secondDateTimePicker.Value).Days).ToString();

            hourTextBox.Text = Math.Abs((firstDateTimePicker.Value - secondDateTimePicker.Value).Days * 24).ToString();

            minuteTextBox.Text = Math.Abs((firstDateTimePicker.Value - secondDateTimePicker.Value).Days * 1440).ToString();

        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();

            this.Hide();

            f3.Show();
        }
    }
}
