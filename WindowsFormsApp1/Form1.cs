using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetTimeFormat()
        {
            switch (comboBoxTimeFormat.Text)
            {
                case ("Полное время"):
                    {
                        labelForTime.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss.fff");
                    }
                    break;
                case ("Только дата"):
                    {
                        labelForTime.Text = DateTime.Now.ToString("dd-MMMM-yyyy");
                    }
                    break;
                case ("Краткое время"):
                    {
                        labelForTime.Text = DateTime.Now.ToString("HH:mm:ss");
                    }
                    break;
                case ("Часы"):
                    {
                        labelForTime.Text = DateTime.Now.ToString("HH:mm:ss");
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Выберите формат времени");
                        labelForTime.Text = "Текущее время";
                    }
                    break;
            }             
        }
        private void SetComboboxColor()
        {
            string comboColor = comboBoxTimeFormat.BackColor.ToString();
            label1.Text = comboColor;
            switch (comboColor)
            {
                case ("Color.White"):
                    {
                        comboBoxTimeFormat.BackColor = Color.Green;
                    }
                    break;
                case ("Color.Green"):
                    {
                        comboBoxTimeFormat.BackColor = Color.Yellow;
                    }
                    break;
                case ("Color.Yellow"):
                    {
                        comboBoxTimeFormat.BackColor = Color.White;
                    }
                    break;
                default:
                    break;
            }
        }

        private void buttonShowTime_MouseClick(object sender, MouseEventArgs e)
        {

            SetTimeFormat();
        }

        private void buttonShowTime_MouseHover(object sender, EventArgs e)
        {
            buttonShowTime.ForeColor = Color.Blue;
        }

        private void buttonShowTime_MouseLeave(object sender, EventArgs e)
        {
            buttonShowTime.ForeColor = Color.Black;
        }

        private void buttonAnother_Click(object sender, EventArgs e)
        {
            SetComboboxColor();
        }
    }
}
