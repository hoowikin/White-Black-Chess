using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 黑白块
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //当button1-25全部为黑色时，游戏结束
            if (button1_Color_White && button2_Color_White && button3_Color_White && button4_Color_White && button5_Color_White &&
                button6_Color_White && button7_Color_White && button8_Color_White && button9_Color_White && button10_Color_White &&
                button11_Color_White && button12_Color_White && button13_Color_Black && button14_Color_White && button15_Color_White &&
                button16_Color_White && button17_Color_White && button18_Color_White && button19_Color_White && button20_Color_White &&
                button21_Color_White && button22_Color_White && button23_Color_White && button24_Color_White && button25_Color_White)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;

            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13_Color_Black = !button13_Color_Black;
            button14_Color_White = !button14_Color_White;
            button18_Color_White = !button18_Color_White;
            button9_Color_White = !button9_Color_White;
            button12_Color_White = !button12_Color_White;

            if (button13_Color_Black)
            {
                button13.BackColor = Color.Black;
            }
            else
            {
                button13.BackColor = Color.White;
            }

            if (button14_Color_White)
            {
                button14.BackColor = Color.White;
            }
            else
            {
                button14.BackColor = Color.Black;
            }

            if (button18_Color_White)
            {
                button18.BackColor = Color.White;
            }
            else
            {
                button18.BackColor = Color.Black;
            }

            if (button9_Color_White)
            {
                button9.BackColor = Color.White;
            }
            else
            {
                button9.BackColor = Color.Black;
            }

            if (button12_Color_White)
            {
                button12.BackColor = Color.White;
            }
            else
            {
                button12.BackColor = Color.Black;
            }
        }

        bool button13_Color_Black = true;
        bool button14_Color_White = true;
        bool button18_Color_White = true;
        bool button9_Color_White = true;
        bool button12_Color_White = true;

        bool button10_Color_White = true;
        bool button19_Color_White = true;
        bool button15_Color_White = true;

        bool button6_Color_White = true;
        bool button20_Color_White = true;

        bool button8_Color_White = true;
        bool button11_Color_White = true;
        bool button17_Color_White = true;

        bool button7_Color_White = true;
        bool button16_Color_White = true;

        bool button1_Color_White = true;
        bool button2_Color_White = true;
        bool button3_Color_White = true;
        bool button4_Color_White = true;
        bool button5_Color_White = true;
        bool button21_Color_White = true;
        bool button22_Color_White = true;
        bool button23_Color_White = true;
        bool button24_Color_White = true;
        bool button25_Color_White = true;

        private void button14_Click(object sender, EventArgs e)
        {
            button14_Color_White = !button14_Color_White;
            button13_Color_Black = !button13_Color_Black;
            button10_Color_White = !button10_Color_White;
            button19_Color_White = !button19_Color_White;
            button15_Color_White = !button15_Color_White;

            if (button14_Color_White)
            {
                button14.BackColor = Color.White;
            }
            else
            {
                button14.BackColor = Color.Black;
            }

            if (button13_Color_Black)
            {
                button13.BackColor = Color.Black;
            }
            else
            {
                button13.BackColor = Color.White;
            }

            if (button10_Color_White)
            {
                button10.BackColor = Color.White;
            }
            else
            {
                button10.BackColor = Color.Black;
            }

            if (button19_Color_White)
            {
                button19.BackColor = Color.White;
            }
            else
            {
                button19.BackColor = Color.Black;
            }

            if (button15_Color_White)
            {
                button15.BackColor = Color.White;
            }
            else
            {
                button15.BackColor = Color.Black;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15_Color_White = !button15_Color_White;
            button6_Color_White = !button6_Color_White;
            button14_Color_White = !button14_Color_White;
            button20_Color_White = !button20_Color_White;

            if (button15_Color_White)
            {
                button15.BackColor = Color.White;
            }
            else
            {
                button15.BackColor = Color.Black;
            }

            if (button6_Color_White)
            {
                button6.BackColor = Color.White;
            }
            else
            {
                button6.BackColor = Color.Black;
            }

            if (button14_Color_White)
            {
                button14.BackColor = Color.White;
            }
            else
            {
                button14.BackColor = Color.Black;
            }

            if (button20_Color_White)
            {
                button20.BackColor = Color.White;
            }
            else
            {
                button20.BackColor = Color.Black;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12_Color_White = !button12_Color_White;
            button11_Color_White = !button11_Color_White;
            button13_Color_Black = !button13_Color_Black;
            button17_Color_White = !button17_Color_White;
            button8_Color_White = !button8_Color_White;

            if (button12_Color_White)
            {
                button12.BackColor = Color.White;
            }
            else
            {
                button12.BackColor = Color.Black;
            }

            if (button11_Color_White)
            {
                button11.BackColor = Color.White;
            }
            else
            {
                button11.BackColor = Color.Black;
            }

            if (button13_Color_Black)
            {
                button13.BackColor = Color.Black;
            }
            else
            {
                button13.BackColor = Color.White;
            }

            if (button17_Color_White)
            {
                button17.BackColor = Color.White;
            }
            else
            {
                button17.BackColor = Color.Black;
            }

            if (button8_Color_White)
            {
                button8.BackColor = Color.White;
            }
            else
            {
                button8.BackColor = Color.Black;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button7_Color_White = !button7_Color_White;
            button11_Color_White = !button11_Color_White;
            button12_Color_White = !button12_Color_White;
            button16_Color_White = !button16_Color_White;

            if (button7_Color_White)
            {
                button7.BackColor = Color.White;
            }
            else
            {
                button7.BackColor = Color.Black;
            }

            if (button11_Color_White)
            {
                button11.BackColor = Color.White;
            }
            else
            {
                button11.BackColor = Color.Black;
            }

            if (button12_Color_White)
            {
                button12.BackColor = Color.White;
            }
            else
            {
                button12.BackColor = Color.Black;
            }

            if (button16_Color_White)
            {
                button16.BackColor = Color.White;
            }
            else
            {
                button16.BackColor = Color.Black;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20_Color_White = !button20_Color_White;
            button15_Color_White = !button15_Color_White;
            button19_Color_White = !button19_Color_White;
            button25_Color_White = !button25_Color_White;

            if (button20_Color_White)
            {
                button20.BackColor = Color.White;
            }
            else
            {
                button20.BackColor = Color.Black;
            }

            if (button15_Color_White)
            {
                button15.BackColor = Color.White;
            }
            else
            {
                button15.BackColor = Color.Black;
            }

            if (button19_Color_White)
            {
                button19.BackColor = Color.White;
            }
            else
            {
                button19.BackColor = Color.Black;
            }

            if (button25_Color_White)
            {
                button25.BackColor = Color.White;
            }
            else
            {
                button25.BackColor = Color.Black;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19_Color_White = !button19_Color_White;
            button20_Color_White = !button20_Color_White;
            button14_Color_White = !button14_Color_White;
            button24_Color_White = !button21_Color_White;
            button18_Color_White = !button18_Color_White;

            if (button19_Color_White)
            {
                button19.BackColor = Color.White;
            }
            else
            {
                button19.BackColor = Color.Black;
            }

            if (button20_Color_White)
            {
                button20.BackColor = Color.White;
            }
            else
            {
                button20.BackColor = Color.Black;
            }

            if (button14_Color_White)
            {
                button14.BackColor = Color.White;
            }
            else
            {
                button14.BackColor = Color.Black;
            }

            if (button24_Color_White)
            {
                button24.BackColor = Color.White;
            }
            else
            {
                button24.BackColor = Color.Black;
            }

            if (button18_Color_White)
            {
                button18.BackColor = Color.White;
            }
            else
            {
                button18.BackColor = Color.Black;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18_Color_White = !button18_Color_White;
            button19_Color_White = !button19_Color_White;
            button13_Color_Black = !button13_Color_Black;
            button23_Color_White = !button23_Color_White;
            button17_Color_White = !button17_Color_White;

            if (button18_Color_White)
            {
                button18.BackColor = Color.White;
            }
            else
            {
                button18.BackColor = Color.Black;
            }

            if (button19_Color_White)
            {
                button19.BackColor = Color.White;
            }
            else
            {
                button19.BackColor = Color.Black;
            }

            if (button13_Color_Black)
            {
                button13.BackColor = Color.Black;
            }
            else
            {
                button13.BackColor = Color.White;
            }

            if (button23_Color_White)
            {
                button23.BackColor = Color.White;
            }
            else
            {
                button23.BackColor = Color.Black;
            }

            if (button17_Color_White)
            {
                button17.BackColor = Color.White;
            }
            else
            {
                button17.BackColor = Color.Black;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17_Color_White = !button17_Color_White;
            button18_Color_White = !button18_Color_White;
            button12_Color_White = !button12_Color_White;
            button22_Color_White = !button22_Color_White;
            button16_Color_White = !button16_Color_White;

            if (button17_Color_White)
            {
                button17.BackColor = Color.White;
            }
            else
            {
                button17.BackColor = Color.Black;
            }

            if (button18_Color_White)
            {
                button18.BackColor = Color.White;
            }
            else
            {
                button18.BackColor = Color.Black;
            }

            if (button12_Color_White)
            {
                button12.BackColor = Color.White;
            }
            else
            {
                button12.BackColor = Color.Black;
            }

            if (button22_Color_White)
            {
                button22.BackColor = Color.White;
            }
            else
            {
                button22.BackColor = Color.Black;
            }

            if (button16_Color_White)
            {
                button16.BackColor = Color.White;
            }
            else
            {
                button16.BackColor = Color.Black;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16_Color_White = !button16_Color_White;
            button17_Color_White = !button17_Color_White;
            button11_Color_White = !button11_Color_White;
            button21_Color_White = !button21_Color_White;

            if (button16_Color_White)
            {
                button16.BackColor = Color.White;
            }
            else
            {
                button16.BackColor = Color.Black;
            }

            if (button17_Color_White)
            {
                button17.BackColor = Color.White;
            }
            else
            {
                button17.BackColor = Color.Black;
            }

            if (button11_Color_White)
            {
                button11.BackColor = Color.White;
            }
            else
            {
                button11.BackColor = Color.Black;
            }

            if (button21_Color_White)
            {
                button21.BackColor = Color.White;
            }
            else
            {
                button21.BackColor = Color.Black;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21_Color_White = !button21_Color_White;
            button16_Color_White = !button16_Color_White;
            button22_Color_White = !button22_Color_White;

            if (button21_Color_White)
            {
                button21.BackColor = Color.White;
            }
            else
            {
                button21.BackColor = Color.Black;
            }

            if (button16_Color_White)
            {
                button16.BackColor = Color.White;
            }
            else
            {
                button16.BackColor = Color.Black;
            }

            if (button22_Color_White)
            {
                button22.BackColor = Color.White;
            }
            else
            {
                button22.BackColor = Color.Black;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22_Color_White = !button22_Color_White;
            button21_Color_White = !button21_Color_White;
            button17_Color_White = !button17_Color_White;
            button23_Color_White = !button23_Color_White;

            if (button22_Color_White)
            {
                button22.BackColor = Color.White;
            }
            else
            {
                button22.BackColor = Color.Black;
            }

            if (button21_Color_White)
            {
                button21.BackColor = Color.White;
            }
            else
            {
                button21.BackColor = Color.Black;
            }

            if (button17_Color_White)
            {
                button17.BackColor = Color.White;
            }
            else
            {
                button17.BackColor = Color.Black;
            }

            if (button23_Color_White)
            {
                button23.BackColor = Color.White;
            }
            else
            {
                button23.BackColor = Color.Black;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23_Color_White = !button23_Color_White;
            button22_Color_White = !button22_Color_White;
            button18_Color_White = !button18_Color_White;
            button24_Color_White = !button24_Color_White;

            if (button23_Color_White)
            {
                button23.BackColor = Color.White;
            }
            else
            {
                button23.BackColor = Color.Black;
            }

            if (button22_Color_White)
            {
                button22.BackColor = Color.White;
            }
            else
            {
                button22.BackColor = Color.Black;
            }

            if (button18_Color_White)
            {
                button18.BackColor = Color.White;
            }
            else
            {
                button18.BackColor = Color.Black;
            }

            if (button24_Color_White)
            {
                button24.BackColor = Color.White;
            }
            else
            {
                button24.BackColor = Color.Black;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24_Color_White = !button24_Color_White;
            button23_Color_White = !button23_Color_White;
            button19_Color_White = !button19_Color_White;
            button25_Color_White = !button25_Color_White;

            if (button24_Color_White)
            {
                button24.BackColor = Color.White;
            }
            else
            {
                button24.BackColor = Color.Black;
            }

            if (button23_Color_White)
            {
                button23.BackColor = Color.White;
            }
            else
            {
                button23.BackColor = Color.Black;
            }

            if (button19_Color_White)
            {
                button19.BackColor = Color.White;
            }
            else
            {
                button19.BackColor = Color.Black;
            }

            if (button25_Color_White)
            {
                button25.BackColor = Color.White;
            }
            else
            {
                button25.BackColor = Color.Black;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25_Color_White = !button25_Color_White;
            button24_Color_White = !button24_Color_White;
            button20_Color_White = !button20_Color_White;

            if (button25_Color_White)
            {
                button25.BackColor = Color.White;
            }
            else
            {
                button25.BackColor = Color.Black;
            }

            if (button24_Color_White)
            {
                button24.BackColor = Color.White;
            }
            else
            {
                button24.BackColor = Color.Black;
            }

            if (button20_Color_White)
            {
                button20.BackColor = Color.White;
            }
            else
            {
                button20.BackColor = Color.Black;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6_Color_White = !button6_Color_White;
            button15_Color_White = !button15_Color_White;
            button10_Color_White = !button10_Color_White;
            button1_Color_White = !button1_Color_White;

            if (button6_Color_White)
            {
                button6.BackColor = Color.White;
            }
            else
            {
                button6.BackColor = Color.Black;
            }

            if (button15_Color_White)
            {
                button15.BackColor = Color.White;
            }
            else
            {
                button15.BackColor = Color.Black;
            }

            if (button10_Color_White)
            {
                button10.BackColor = Color.White;
            }
            else
            {
                button10.BackColor = Color.Black;
            }

            if (button1_Color_White)
            {
                button1.BackColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.Black;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10_Color_White = !button10_Color_White;
            button6_Color_White = !button6_Color_White;
            button14_Color_White = !button14_Color_White;
            button2_Color_White = !button2_Color_White;
            button9_Color_White = !button9_Color_White;

            if (button10_Color_White)
            {
                button10.BackColor = Color.White;
            }
            else
            {
                button10.BackColor = Color.Black;
            }

            if (button6_Color_White)
            {
                button6.BackColor = Color.White;
            }
            else
            {
                button6.BackColor = Color.Black;
            }

            if (button14_Color_White)
            {
                button14.BackColor = Color.White;
            }
            else
            {
                button14.BackColor = Color.Black;
            }

            if (button2_Color_White)
            {
                button2.BackColor = Color.White;
            }
            else
            {
                button2.BackColor = Color.Black;
            }

            if (button9_Color_White)
            {
                button9.BackColor = Color.White;
            }
            else
            {
                button9.BackColor = Color.Black;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8_Color_White = !button8_Color_White;
            button10_Color_White = !button10_Color_White;
            button13_Color_Black = !button13_Color_Black;
            button3_Color_White = !button3_Color_White;
            button9_Color_White = !button9_Color_White;

            if (button8_Color_White)
            {
                button8.BackColor = Color.White;
            }
            else
            {
                button8.BackColor = Color.Black;
            }

            if (button10_Color_White)
            {
                button10.BackColor = Color.White;
            }
            else
            {
                button10.BackColor = Color.Black;
            }

            if (button13_Color_Black)
            {
                button13.BackColor = Color.Black;
            }
            else
            {
                button13.BackColor = Color.White;
            }

            if (button3_Color_White)
            {
                button3.BackColor = Color.White;
            }
            else
            {
                button3.BackColor = Color.Black;
            }

            if (button9_Color_White)
            {
                button9.BackColor = Color.White;
            }
            else
            {
                button9.BackColor = Color.Black;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7_Color_White = !button7_Color_White;
            button9_Color_White = !button9_Color_White;
            button12_Color_White = !button12_Color_White;
            button4_Color_White = !button4_Color_White;
            button8_Color_White = !button8_Color_White;

            if (button7_Color_White)
            {
                button7.BackColor = Color.White;
            }
            else
            {
                button7.BackColor = Color.Black;
            }

            if (button9_Color_White)
            {
                button9.BackColor = Color.White;
            }
            else
            {
                button9.BackColor = Color.Black;
            }

            if (button12_Color_White)
            {
                button12.BackColor = Color.White;
            }
            else
            {
                button12.BackColor = Color.Black;
            }

            if (button4_Color_White)
            {
                button4.BackColor = Color.White;
            }
            else
            {
                button4.BackColor = Color.Black;
            }

            if (button8_Color_White)
            {
                button8.BackColor = Color.White;
            }
            else
            {
                button8.BackColor = Color.Black;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7_Color_White = !button7_Color_White;
            button8_Color_White = !button8_Color_White;
            button11_Color_White = !button11_Color_White;
            button5_Color_White = !button5_Color_White;

            if (button7_Color_White)
            {
                button7.BackColor = Color.White;
            }
            else
            {
                button7.BackColor = Color.Black;
            }

            if (button8_Color_White)
            {
                button8.BackColor = Color.White;
            }
            else
            {
                button8.BackColor = Color.Black;
            }

            if (button11_Color_White)
            {
                button11.BackColor = Color.White;
            }
            else
            {
                button11.BackColor = Color.Black;
            }

            if (button5_Color_White)
            {
                button5.BackColor = Color.White;
            }
            else
            {
                button5.BackColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5_Color_White = !button5_Color_White;
            button7_Color_White = !button7_Color_White;
            button4_Color_White = !button4_Color_White;

            if (button5_Color_White)
            {
                button5.BackColor = Color.White;
            }
            else
            {
                button5.BackColor = Color.Black;
            }

            if (button7_Color_White)
            {
                button7.BackColor = Color.White;
            }
            else
            {
                button7.BackColor = Color.Black;
            }

            if (button4_Color_White)
            {
                button4.BackColor = Color.White;
            }
            else
            {
                button4.BackColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3_Color_White = !button3_Color_White;
            button5_Color_White = !button5_Color_White;
            button8_Color_White = !button8_Color_White;
            button4_Color_White = !button4_Color_White;

            if (button3_Color_White)
            {
                button3.BackColor = Color.White;
            }
            else
            {
                button3.BackColor = Color.Black;
            }

            if (button5_Color_White)
            {
                button5.BackColor = Color.White;
            }
            else
            {
                button5.BackColor = Color.Black;
            }

            if (button8_Color_White)
            {
                button8.BackColor = Color.White;
            }
            else
            {
                button8.BackColor = Color.Black;
            }

            if (button4_Color_White)
            {
                button4.BackColor = Color.White;
            }
            else
            {
                button4.BackColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Color_White = !button2_Color_White;
            button4_Color_White = !button4_Color_White;
            button9_Color_White = !button9_Color_White;
            button3_Color_White = !button3_Color_White;

            if (button2_Color_White)
            {
                button2.BackColor = Color.White;
            }
            else
            {
                button2.BackColor = Color.Black;
            }

            if (button4_Color_White)
            {
                button4.BackColor = Color.White;
            }
            else
            {
                button4.BackColor = Color.Black;
            }

            if (button9_Color_White)
            {
                button9.BackColor = Color.White;
            }
            else
            {
                button9.BackColor = Color.Black;
            }

            if (button3_Color_White)
            {
                button3.BackColor = Color.White;
            }
            else
            {
                button3.BackColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Color_White = !button1_Color_White;
            button3_Color_White = !button3_Color_White;
            button10_Color_White = !button10_Color_White;
            button2_Color_White = !button2_Color_White;

            if (button1_Color_White)
            {
                button1.BackColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.Black;
            }

            if (button3_Color_White)
            {
                button3.BackColor = Color.White;
            }
            else
            {
                button3.BackColor = Color.Black;
            }

            if (button10_Color_White)
            {
                button10.BackColor = Color.White;
            }
            else
            {
                button10.BackColor = Color.Black;
            }

            if (button2_Color_White)
            {
                button2.BackColor = Color.White;
            }
            else
            {
                button2.BackColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Color_White = !button1_Color_White;
            button2_Color_White = !button2_Color_White;
            button6_Color_White = !button6_Color_White;

            if (button1_Color_White)
            {
                button1.BackColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.Black;
            }

            if (button2_Color_White)
            {
                button2.BackColor = Color.White;
            }
            else
            {
                button2.BackColor = Color.Black;
            }

            if (button6_Color_White)
            {
                button6.BackColor = Color.White;
            }
            else
            {
                button6.BackColor = Color.Black;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                Button button = (Button)Controls.Find("button" + (i + 1), true)[0];
                button.BackColor = Color.White;
            }
            button13.BackColor = Color.Black;
            for (int i = 13; i < 25; i++)
            {
                Button button = (Button)Controls.Find("button" + (i + 1), true)[0];
                button.BackColor = Color.White;
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;

        }

        private void button27_Click(object sender, EventArgs e)
        {
            //遍历所有控件
            for (int i = 1; i <= 25; i++)
            {
                string buttonName = "button" + i.ToString();
                //查找控件
                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    button.BackColor = Color.Black;
                }
            }

        }
    }
}
