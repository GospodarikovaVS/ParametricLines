using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParamLines
{
    public partial class ToolForm : Form
    {
        private CanvasForm Canvas;
        private Color Action;
        private Color BackGround;


        public ToolForm()
        {
            InitializeComponent();
            Action = Color.Black;
            BackGround = Color.White;
            Canvas = new CanvasForm(Action, BackGround);
            Canvas.Owner = this;
            Canvas.Show();
            radioButton1.Checked = true;
            radioButton15.Checked = true;
            radioButton18.Checked = true;
        }

        RadioButton GetSelectedRadioButton(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                RadioButton radioButton = control as RadioButton;
                if (radioButton != null && radioButton.Checked)
                    return radioButton;
            }
            return null;
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            string s = GetSelectedRadioButton(groupBox1).Name;
            s = s.Substring(11);
            Canvas.MyPainter.wx = Convert.ToDouble(textBox1.Text);
            Canvas.MyPainter.wx0 = Convert.ToDouble(textBox2.Text);
            Canvas.MyPainter.wy = Convert.ToDouble(textBox3.Text);
            Canvas.MyPainter.wy0 = Convert.ToDouble(textBox4.Text);
            Canvas.MyPainter.r0 = Convert.ToDouble(textBox5.Text);
            Canvas.MyPainter.r1 = Convert.ToDouble(textBox6.Text);
            Canvas.Clear();
            Canvas.DrawGraphic(Convert.ToInt32(s));
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            string sB = GetSelectedRadioButton(groupBox5).Name;
            string sL = GetSelectedRadioButton(groupBox4).Name;
            sB = sB.Substring(11);
            sL = sL.Substring(11);
            int Act = Convert.ToInt32(sL);
            int Back = Convert.ToInt32(sB);
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
            if (Act == 21)
            {
                c1 = Convert.ToInt32(TextLines1.Text);
                c2 = Convert.ToInt32(TextLines2.Text);
                c3 = Convert.ToInt32(TextLines3.Text);

            }
            else
            {
                Canvas.MyPainter.ColorAct(Act, ref c1, ref c2, ref c3);
            }
            if (Back == 22)
            {
                c4 = Convert.ToInt32(TextBack1.Text);
                c5 = Convert.ToInt32(TextBack2.Text);
                c6 = Convert.ToInt32(TextBack3.Text);

            }
            else
            {
                Canvas.MyPainter.ColorBckgr(Back, ref c4, ref c5, ref c6);
            }

            Action = Color.FromArgb(c1, c2, c3);
            BackGround = Color.FromArgb(c4, c5, c6);
            Canvas.ChangeColors(Action, BackGround);

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "4";
                textBox2.Text = "1";
                textBox3.Text = "3";
                textBox4.Text = "1";
                textBox5.Text = "4";
                textBox6.Text = "3";
                richTextBox1.Text = "x(t) = r0 * cos(wx * t + wx0)";
                richTextBox2.Text = "y(t) = r1 * sin(wy * t + wy0)";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "4";
                textBox2.Text = "1";
                textBox3.Text = "4";
                textBox4.Text = "0,5";
                textBox5.Text = "4";
                textBox6.Text = "2";
                richTextBox1.Text = "x(t) = (r0 + r1 * t) * cos(wx * t + wx0)";
                richTextBox2.Text = "y(t) = (r0 + r1 * t) * sin(wy * t + wy0)";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "1,5";
                textBox2.Text = "0,2";
                textBox3.Text = "1,5";
                textBox4.Text = "0,5";
                textBox5.Text = "0,8";
                textBox6.Text = "0,18";
                richTextBox1.Text = "x(t) = r0 * exp(r1*t) * cos(wx * t + wx0)";
                richTextBox2.Text = "y(t) = r0 * exp(r1*t) * sin(wy * t + wy0)";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "2";
                textBox2.Text = "1";
                textBox3.Text = "1";
                textBox4.Text = "0,5";
                textBox5.Text = "1";
                textBox6.Text = "0,5";
                richTextBox1.Text = "x(t) = (r0 + r1 * sqrt(t)) * cos(wx * t + wx0)";
                richTextBox2.Text = "y(t) = (r0 + r1 * sqrt(t)) * sin(wy * t + wy0)";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "4";
                textBox2.Text = "1,6";
                textBox3.Text = "4";
                textBox4.Text = "1,6";
                textBox5.Text = "1,2";
                textBox6.Text = "0";
                richTextBox1.Text = "x(t) = r0 * (t - sin(wx * t + wx0))";
                richTextBox2.Text = "y(t) = r0 * (1 - cos(wy * t + wy0))";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "1";
                textBox2.Text = "0";
                textBox3.Text = "1";
                textBox4.Text = "0";
                textBox5.Text = "3";
                textBox6.Text = "1";
                richTextBox1.Text = "x(t) = (r0 * cos(t) + r1) * cos(wx * t + wx0))";
                richTextBox2.Text = "y(t) = (r0 * cos(t) + r1) * sin(wy * t + wy0))";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "1";
                textBox2.Text = "0,5";
                textBox3.Text = "1";
                textBox4.Text = "0,5";
                textBox5.Text = "4";
                textBox6.Text = "1";
                richTextBox1.Text = "x(t) = (r0 * cos(t) - r1/cos(t)) * cos(wx * t + wx0)";
                richTextBox2.Text = "y(t) = (r0 * cos(t)-r1/cos(t)) * sin(wy * t + wy0)";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "2";
                textBox2.Text = "0";
                textBox3.Text = "2";
                textBox4.Text = "0";
                textBox5.Text = "3";
                textBox6.Text = "0";
                richTextBox1.Text = "x(t) = r0 * sin(wy * t + wy0) * cos(t)";
                richTextBox2.Text = "y(t) = r0 * sin(wy * t + wy0) * sin(t)";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            //эллипс
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                Canvas.Clear();
                textBox1.Text = "3";
                textBox2.Text = "1";
                textBox3.Text = "3";
                textBox4.Text = "1";
                textBox5.Text = "2";
                textBox6.Text = "0";
                richTextBox1.Text = "x(t) = r0*(1+cos(wy*t+wy0)+sin(wy*t+wy0)^2)*cos(t)";
                richTextBox2.Text = "y(t) = r0*(1+cos(wy*t+wy0)+sin(wy*t+wy0)^2)*sin(t)";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            //Парабола
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            //cos
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            //sin
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                TextLines1.Text = "0";
                TextLines2.Text = "0";
                TextLines3.Text = "0";
                TextLines1.Enabled = false;
                TextLines2.Enabled = false;
                TextLines3.Enabled = false;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                TextLines1.Text = "255";
                TextLines2.Text = "0";
                TextLines3.Text = "0";
                TextLines1.Enabled = false;
                TextLines2.Enabled = false;
                TextLines3.Enabled = false;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                TextLines1.Text = "0";
                TextLines2.Text = "0";
                TextLines3.Text = "255";
                TextLines1.Enabled = false;
                TextLines2.Enabled = false;
                TextLines3.Enabled = false;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                TextLines1.Text = "";
                TextLines2.Text = "";
                TextLines3.Text = "";
                TextLines1.Enabled = true;
                TextLines2.Enabled = true;
                TextLines3.Enabled = true;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                TextLines1.Text = "255";
                TextLines2.Text = "255";
                TextLines3.Text = "255";
                TextLines1.Enabled = false;
                TextLines2.Enabled = false;
                TextLines3.Enabled = false;
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                TextLines1.Text = "173";
                TextLines2.Text = "216";
                TextLines3.Text = "230";
                TextLines1.Enabled = false;
                TextLines2.Enabled = false;
                TextLines3.Enabled = false;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                TextLines1.Text = "255";
                TextLines2.Text = "0";
                TextLines3.Text = "0";
                TextLines1.Enabled = false;
                TextLines2.Enabled = false;
                TextLines3.Enabled = false;
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                TextLines1.Text = "255";
                TextLines2.Text = "0";
                TextLines3.Text = "0";
                TextLines1.Enabled = false;
                TextLines2.Enabled = false;
                TextLines3.Enabled = false;
            }
        }

    }
}
