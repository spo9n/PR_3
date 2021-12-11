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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(yearRadioButton.Checked)
            {
                newDateTextBox.Text = (Convert.ToDateTime(startDateTextBox.Text).AddYears(Convert.ToInt32(setTextBox.Text))).ToString();
            }

            if (monthRadioButton.Checked)
            {
                newDateTextBox.Text = (Convert.ToDateTime(startDateTextBox.Text).AddMonths(Convert.ToInt32(setTextBox.Text))).ToString();
            }

            if (weekRadioButton.Checked)
            {
                newDateTextBox.Text = (Convert.ToDateTime(startDateTextBox.Text).AddDays(Convert.ToInt32(setTextBox.Text) * 7)).ToString();
            }

            if (dayRadioButton.Checked)
            {
                newDateTextBox.Text = (Convert.ToDateTime(startDateTextBox.Text).AddDays(Convert.ToInt32(setTextBox.Text))).ToString();
            }

            if (hourRadioButton.Checked)
            {
                newDateTextBox.Text = (Convert.ToDateTime(startDateTextBox.Text).AddHours(Convert.ToInt32(setTextBox.Text))).ToString();
            }

            if (minuteRadioButton.Checked)
            {
                newDateTextBox.Text = (Convert.ToDateTime(startDateTextBox.Text).AddMinutes(Convert.ToInt32(setTextBox.Text))).ToString();
            }

            if (secondsRadioButton.Checked)
            {
                newDateTextBox.Text = (Convert.ToDateTime(startDateTextBox.Text).AddSeconds(Convert.ToInt32(setTextBox.Text))).ToString();
            }

        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();

            this.Hide();

            f4.Show();
        }
    }
}
