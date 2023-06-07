using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int month = int.Parse(numericUpDownMonth.Text);
            int day = int.Parse(numericUpDownDay.Text);
            int[] months = new int[12];
            for (int i = 0; i < 12; i++)
                if (i == 1)
                    months[i] = 29;
                else if (i==0||i==2||i==4||i==6||i==7||i==9||i==11)
                    months[i] = 31;
                else
                    months[i] = 30;
            int number=0;
            if (day > months[month - 1])
                labelResult.Text = "Выбрано слишком большое число";
            else
            {
                for (int i = 0; i < month-1; i++)
                    number += months[i];
                number += day;
            }
            labelResult.Text = day.ToString() + "." + month.ToString() + ".2024 " + number.ToString() + " по счету в году";
        }
    }
}
