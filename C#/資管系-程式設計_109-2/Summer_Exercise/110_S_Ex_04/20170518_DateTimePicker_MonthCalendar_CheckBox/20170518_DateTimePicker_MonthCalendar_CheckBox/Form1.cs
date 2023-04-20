using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;

namespace _20170518_DateTimePicker_MonthCalendar_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CPU_CheckedChanged(object sender, EventArgs e)
        {
            if(CPU.Checked)
            {
                NUD_CPU.Visible = true;
                NUD_CPUP.Visible = true;
            }
            else
            {
                NUD_CPU.Visible = false;
                NUD_CPUP.Visible = false;
            }
        }

        private void LCD_CheckedChanged(object sender, EventArgs e)
        {
            if (LCD.Checked)
            {
                NUD_LCD.Visible = true;
                NUD_LCDP.Visible = true;
            }
            else
            {
                NUD_LCD.Visible = false;
                NUD_LCDP.Visible = false;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Receipt.Items.Clear();
            if ((!CPU.Checked) && (!LCD.Checked)) return;
            Receipt.Items.Add("發票日期： " + DTP.Value);
            Receipt.Items.Add(" ");

            decimal CPUtotal = 0;
            decimal LCDtotal = 0;

            if(CPU.Checked)
            {
                CPUtotal = NUD_CPU.Value * NUD_CPUP.Value;
                Receipt.Items.Add("CPU(" + NUD_CPU.Value + ")顆: NT$ " + CPUtotal);
            }
            if (LCD.Checked)
            {
                LCDtotal = NUD_LCD.Value * NUD_LCDP.Value;
                Receipt.Items.Add("LCD(" + NUD_LCD.Value + ")顆: NT$ " + LCDtotal);
            }

            Receipt.Items.Add("=================================================");
            Receipt.Items.Add("總價: NT$ " + (CPUtotal + LCDtotal));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MCD.CalendarDimensions = new Size(2, 1);
        }

        private void MCD_DateSelected(object sender, DateRangeEventArgs e)
        {
            if(MCD.SelectionStart < DateTime.Today)
            {
                MessageBox.Show("起始日必須大於或等於今天", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MCD.SetDate(DateTime.Today); return;              
            }

            if (StartDate.Checked) DTP_start.Value = MCD.SelectionStart;
            if (EndDate.Checked) DTP_end.Value = MCD.SelectionStart;

            string Date = (DTP_end.Value.Date - DTP_start.Value.Date).ToString();
            Date = Date.Substring(0,Date.IndexOf("."));
            int days = int.Parse(Date);

            if (DTP_start.Value.Date > DTP_end.Value.Date || days > 7)
            {
                MessageBox.Show("迄日必須大於起始日，且期間不大於一周", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MCD.SetDate(DateTime.Today);              
                DTP_start.Value = DateTime.Today;
                DTP_end.Value = DateTime.Today;
            }

            MCD.SelectionRange = new SelectionRange(DTP_start.Value, DTP_end.Value);
        }

        private void Set_Click(object sender, EventArgs e)
        {
            if (DTP_end.Value.Date > DTP_start.Value.Date)
            MCD.SetSelectionRange(DTP_start.Value.Date, DTP_end.Value.Date);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "年":
                    MessageBox.Show(VB.DateAndTime.DateDiff(VB.DateInterval.Year, DTP_start.Value.Date, DTP_end.Value.Date) + "年", "日期差距");
                    break;

                case "季":
                    MessageBox.Show(VB.DateAndTime.DateDiff(VB.DateInterval.Quarter, DTP_start.Value.Date, DTP_end.Value.Date) + "季", "日期差距");
                    break;

                case "月":
                    MessageBox.Show(VB.DateAndTime.DateDiff(VB.DateInterval.Month, DTP_start.Value.Date, DTP_end.Value.Date) + "月", "日期差距");
                    break;

                case "周":
                    MessageBox.Show(VB.DateAndTime.DateDiff(VB.DateInterval.WeekOfYear, DTP_start.Value.Date, DTP_end.Value.Date) + "周", "日期差距");
                    break;

                case "日":
                    MessageBox.Show(VB.DateAndTime.DateDiff(VB.DateInterval.DayOfYear, DTP_start.Value.Date, DTP_end.Value.Date) + "日", "日期差距");
                    break;

                case "小時":
                    MessageBox.Show(VB.DateAndTime.DateDiff(VB.DateInterval.Hour, DTP_start.Value.Date, DTP_end.Value.Date) + "小時", "日期差距");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dt = "5/1/" + year.Text;
                MCD.SetDate(DateTime.Parse(dt));
                int MayOne = (int)DateTime.Parse("5/1/" + year.Text).DayOfWeek;
                DateTime MothersDay;
                DateTime[] Vacations = new DateTime[1];

                switch(MayOne)
                {
                    case 0:
                        MothersDay = DateTime.Parse("5/8/" + year.Text);
                        break;

                    default:
                        MothersDay = DateTime.Parse("5/" + ((7 - MayOne + 1) + 7) + "/" + year.Text);
                        break;
                }

                Vacations[0] = MothersDay;
                MCD.BoldedDates = Vacations;
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
