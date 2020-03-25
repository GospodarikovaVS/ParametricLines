using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Параметрические_кривые
{
    
    public partial class ToolForm : Form
    {
        private CanvasForm Canvas;
               
        public ToolForm()
        {
            InitializeComponent();
            Canvas = new CanvasForm(Color.Black, Color.White);
            Canvas.Owner = this;
            Canvas.Show();
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

        RadioButton GetSelectedRadioButton(GroupBox groupBox) 
        { 
            foreach(Control control in groupBox.Controls) 
            { 
                RadioButton radioButton = control as RadioButton; 
                if (radioButton != null && radioButton.Checked) 
                return radioButton; 
            } 
            return null; 
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

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
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

        private void Finish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
