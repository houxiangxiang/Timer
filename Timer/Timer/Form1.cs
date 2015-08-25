using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private DateTimeVisitor dataTimeVisitor = new DateTimeVisitor();
        private PomodoroVisitor pomodoroVisitor = new PomodoroVisitor();

        public Form1()
        {
            InitializeComponent();
            dataTimeVisitor.visit(this);
        }

        public bool PomodoroStart
        {
            get; set;
        }

        public TextBox getTextBoxTime()
        {
            return textBoxTime;
        }

        public TextBox getTextBoxDate()
        {
            return textBoxDate;
        }

        public NumericUpDown getNumericUpDownSec()
        {
            return numericUpDownSec;
        }

        public NumericUpDown getNumericUpDownMin()
        {
            return numericUpDownMin;
        }

        public NumericUpDown getNumericUpDownHour()
        {
            return numericUpDownHour;
        }

        private void timerTrigger_Tick(object sender, EventArgs e)
        {
            dataTimeVisitor.visit(this);
            pomodoroVisitor.visit(this);
        }

        private void buttonPomodoroStart_Click(object sender, EventArgs e)
        {
            PomodoroStart = true;
        }

        private void buttonPomodoroStop_Click(object sender, EventArgs e)
        {
            PomodoroStart = false;
            numericUpDownSec.Value = numericUpDownMin.Value = numericUpDownHour.Value = 0; 
        }
    }

    abstract public class Visitor
    {
        public abstract void visit(Form1 form); 
    }

    public class DateTimeVisitor : Visitor
    {
        public override void visit(Form1 form)
        {
            form.getTextBoxTime().Text = DateTime.Now.ToString("HH:mm:ss tt");
            form.getTextBoxDate().Text = DateTime.Now.DayOfWeek.ToString() + 
                " " + DateTime.Now.ToString("d");
        }
    }

    public class PomodoroVisitor : Visitor
    {
        private Thread ringThread = null;
        private const int ringNumbers = 20;
        private const int ringInterval = 500; // milli seconds
        private bool isRinging = false;

        public override void visit(Form1 form)
        {
            if (!form.PomodoroStart)
            {
                // in case still ring
                disablePomodoro(form);
                 
                return; 
            }

            if (isRinging)
            {
                if (!ringThread.IsAlive)
                {
                    disablePomodoro(form);
                }

                return;
            }

            decimal newSec = form.getNumericUpDownSec().Value, 
                    newMin = form.getNumericUpDownMin().Value, 
                    newHour = form.getNumericUpDownHour().Value; 

            if (newSec == 0 && newMin == 0 && newHour == 0)
            {
                startRing();
                return; 
            }

            if (newSec == 0)
            {
                newMin--;
                newSec = 59; 
            }
            else
            {
                newSec--; 
            }

            if (newMin < 0)
            {
                newHour--;
                newMin = 59;
            }

            // in case we missed the second when timer is reset
            if (newHour < 0)
            {
                newSec = newMin = newHour = 0;
                startRing();
            }

            form.getNumericUpDownSec().Value = newSec;
            form.getNumericUpDownMin().Value = newMin;
            form.getNumericUpDownHour().Value = newHour; 
        }

        private void disablePomodoro(Form1 form)
        {
            form.PomodoroStart = false;
            if (isRinging)
            {
                isRinging = false;
                ringThread.Abort();
            }
        }

        private void startRing()
        {
            isRinging = true;
            ringThread = new Thread(ring);
            ringThread.Start();
        }

        static private void ring()
        {
            for (int i=0; i<ringNumbers; i++)
            {
                System.Media.SystemSounds.Asterisk.Play();
                System.Threading.Thread.Sleep(ringInterval);
            }
        }
    }
}
