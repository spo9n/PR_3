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
    public partial class Form1 : Form
    {
        List<string> redDates = new List<string>() { "25.12", "31.12", "08.03", "14.10" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectedDateLabel2.Text = monthCalendar1.SelectionStart.ToShortDateString();
           
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string myDate = monthCalendar1.SelectionStart.ToShortDateString();
            selectedDateLabel2.ForeColor = Color.Black;

            selectedDateLabel2.Text = myDate;

            if(Convert.ToInt32(monthCalendar1.SelectionStart.DayOfWeek) == 0 || Convert.ToInt32(monthCalendar1.SelectionStart.DayOfWeek) == 6)
            {
                selectedDateLabel2.ForeColor = Color.Red;
            }
            else
            {
                for (int i = 0; i < redDates.Count; i++)
                {
                    if (myDate.Contains(redDates[i]))
                    {
                        selectedDateLabel2.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();

            this.Hide();

            f2.Show();
        }
    }
}
