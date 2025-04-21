using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearInputCalendarApp
{
    public partial class EasterFormApp : Form
    {
        public EasterFormApp()
        {
            InitializeComponent();
        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            if (textBoxYear.Text.Length == 4 && int.TryParse(textBoxYear.Text, out int year))
            {
                DateTime dt;
                int a, b, c, d, e1, day;
                a = year % 19;
                b = year % 4;
                c = year % 7;
                d = (19 * a + 24) % 30;
                e1 = (2 * b + 4 * c + 6 * d + 5) % 7;
                day = 22 + d + e1;
                string verb = "is";
                if (year != DateTime.Now.Year)
                    verb = (year > DateTime.Now.Year ? "will be" : "was");
                if (day <= 31)
                {
                    msg.Text = String.Format($"Easter Sunday {year}, {verb} on March {day}");
                    dt = new DateTime(year, 3, day);
                }
                else
                {
                    msg.Text = String.Format($"Easter Sunday {year}, {verb} on April {day - 31}");
                    dt = new DateTime(year, 4, day - 31);
                }                
                monthCalendar.SetDate(dt);
            }
            else
            {
                MessageBox.Show("Please enter a valid 4-digit year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
