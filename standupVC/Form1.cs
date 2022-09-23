using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandupVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Weekend
        {
            public bool LabShift, NotWorked;
            public string Day;
            public String result;
            public void Output()
            {
                if (!NotWorked)
                {
                    this.result = "\r\n" + this.Day + " >> I will work a lab shift. ";
                }
                else
                {
                    this.result = "";
                }
            }
        }
        public class Weekday
        {
            public bool LabShift, NotWorked;
            public String result;
            public string TicksAddressed, TicksActioned, FrontDesk, OperatorConsole,
              ServicePhones, AdditionalTasks, Day;
            public void Output()
            {
                if (!NotWorked)
                {
                    if (this.Day == "Friday")
                    {
                        this.result = "\r\n" + this.Day + " >> I've worked " + this.FrontDesk + " hours on front desk, " + this.ServicePhones + " hours on service phones, and " + this.OperatorConsole + " hours on Operator so far, and will work more as scheduled. I've addressed " + this.TicksAddressed + " and actioned " + this.TicksActioned + " tickets so far, and will work on more if available. ";
                        if (this.LabShift)
                        {
                            this.result += " >> I will work a lab shift. ";
                        }
                    }
                    else
                    {
                        this.result = "\r\n" + this.Day + " >> I worked " + this.FrontDesk + " hours on front desk, " + this.ServicePhones + " hours on service phones, and " + this.OperatorConsole + " hours on Operator. I've addressed " + this.TicksAddressed + " and actioned " + this.TicksActioned + " tickets. ";
                        if (this.LabShift)
                        {
                            this.result += "I worked a lab shift. ";
                        }
                    }
                }
                else
                {
                    this.result = "";
                }

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Dictionary<int, Weekday> Weekdays =
            new Dictionary<int, Weekday>();
            Dictionary<int, Weekend> Weekends =
            new Dictionary<int, Weekend>();
            string[] weekdayArray = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
            string[] weekendArray = { "Saturday", "Sunday"};
            bool[] weekdayNotworked = {monoff.Checked, tueoff.Checked, wedoff.Checked, thuoff.Checked, frioff.Checked};
            bool[] weekdayLab = { monlab.Checked, tuelab.Checked, wedlab.Checked, thulab.Checked, frilab.Checked };
            bool[] weekendNotworked = { satoff.Checked, sunoff.Checked };
            bool[] weekendLab = { satlab.Checked, sunlab.Checked};
            string[] weekdayFrontDesk = { monfrn.Text, tuefrn.Text, wedfrn.Text, thufrn.Text, frifrn.Text};
            string[] weekdayService = { monsrv.Text, tuesrv.Text, wedsrv.Text, thusrv.Text, frisrv.Text };
            string[] weekdayOperator = { monops.Text, tueops.Text, wedops.Text, thuops.Text, friops.Text };
            string[] weekdayAddressed = { monadr.Text, tueadr.Text, wedadr.Text, thuadr.Text, friadr.Text };
            string[] weekdayActioned = { monact.Text, tueact.Text, wedact.Text, thuact.Text, friact.Text };
            string[] weekdayAdditional = { monadt.Text, tueadt.Text, wedadt.Text, thuadt.Text, friadt.Text };
            String imped = impdmt.Text;
            String result = "";
            for (int i = 0; i < 5; i++) 
            {
                Weekdays[i] = new Weekday();
            }
            for (int i = 0; i < 5; i++)
            {
                Weekdays[i].Day = weekdayArray[i];
                Weekdays[i].NotWorked = weekdayNotworked[i];
                Weekdays[i].LabShift = weekdayLab[i];
                Weekdays[i].FrontDesk = weekdayFrontDesk[i];
                Weekdays[i].ServicePhones = weekdayService[i];
                Weekdays[i].OperatorConsole = weekdayOperator[i];
                Weekdays[i].TicksAddressed = weekdayAddressed[i];
                Weekdays[i].TicksActioned = weekdayActioned[i];
                Weekdays[i].AdditionalTasks = weekdayAdditional[i];
            }
            for (int i = 0; i < 2; i++)
            {
                Weekends[i] = new Weekend();
            }
            for (int i = 0; i < 2; i++)
            {
                Weekends[i].Day = weekendArray[i];
                Weekends[i].NotWorked = weekendNotworked[i];
                Weekends[i].LabShift = weekendLab[i];
            }

            for (int i = 0; i < 5; i++)
            {
                Weekdays[i].Output();
                result += Weekdays[i].result;
            }
            for (int i = 0; i < 2; i++)
            {
                Weekends[i].Output();
                result += Weekends[i].result;
            }
            result += "\r\n\r\n" + "Impediments: " + imped;

            result += "\r\n\r\n" + "Generated with Visual Standup Version " + version;
            resbox.Text = result;
        }
        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void Friday_Click(object sender, EventArgs e)
        {

        }
    }
}
