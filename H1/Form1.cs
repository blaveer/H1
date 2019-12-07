using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H1
{
    public partial class Form1 : Form
    {

        private static bool sci=false;
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("运算记录", -2, HorizontalAlignment.Center);
            sci = false;
        }

        /**运行函数*/
        private void button17_Click(object sender, EventArgs e) 
        {
            string s = this.textBox1.Text;
            if (!s.Trim().Equals(""))
            {
                //关于这个东西的使用，Sci是计算的函数，函数的返回值是运算是否成功的标志
                //其中返回0是成功。返回1是存在非法字符，返回2是存在不合理的运算符
                //如果返回0了，那么在其中的resultD变量中存储着正确的运算结果
                int result = Scientific.Scientific.Sci(s.Trim());
                if (result == 0)
                {
                    this.textBox1.Text = Scientific.Scientific.resultD.ToString();
                    this.textBox1.Focus();
                    this.textBox1.Select(textBox1.Text.Length, 0);
                    upDateListView(s.Trim());
                }
                else if(result==1)
                {
                    MessageBox.Show("表达式中存在不合法字符");
                }
                else if (result == 2)
                {
                    MessageBox.Show("表达式中存在不合理运算符或者数字");
                }
                else if (result == 3)
                {
                    MessageBox.Show("表达式中的小数点使用不正确");
                }
            }
            sci = true;
        }

        #region 数字
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "7";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "7";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "8";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "8";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "9";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "9";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "4";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "4";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "5";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "5";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "6";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "6";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "1";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "1";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "2";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "2";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "3";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "3";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "0";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "0";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }
        #endregion

        #region 小数点
        private void button19_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = ".";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + ".";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }
        #endregion

        #region 括号
        private void button1_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "(";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "(";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = ")";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + ")";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        #endregion

        #region 运算符
        private void button3_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "/";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "/";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "*";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "*";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "-";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "-";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "+";
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "+";
            }
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox1.Focus();
            this.textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button21_Click(object sender, EventArgs e)   //后退一个
        {
            String input = textBox1.Text.ToString().Trim();
            if (input.Length == 0)
            {
                return;
            }
            if (input.Length > 0)
            {
                this.textBox1.Text = this.textBox1.Text.Substring(0, this.textBox1.Text.Length - 1);
                this.textBox1.Focus();
                this.textBox1.Select(textBox1.Text.Length, 0);
            }
        }
        
        /**对于数字键盘的响应**/
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (sci)
            {
                sci = false;
                this.textBox1.Text = "";
            }
            else if (keyData == Keys.Enter)
            {
                button17_Click(null,null);
            }
            else if (keyData == Keys.Back)
            {
                button21_Click(null, null);
            }

            else if (keyData == Keys.NumPad0)
            {
                button18_Click(null, null);
            }
            else if (keyData == Keys.NumPad1)
            {
                button14_Click(null, null);
            }
            else if (keyData == Keys.NumPad2)
            {
                button15_Click(null, null);
            }
            else if (keyData == Keys.NumPad3)
            {
                button16_Click(null, null);
            }
            else if (keyData == Keys.NumPad4)
            {
                button10_Click(null, null);
            }
            else if (keyData == Keys.NumPad5)
            {
                button11_Click(null, null);
            }
            else if (keyData == Keys.NumPad6)
            {
                button12_Click(null, null);
            }
            else if (keyData == Keys.NumPad7)
            {
                button6_Click(null, null);
            }
            else if (keyData == Keys.NumPad8)
            {
                button7_Click(null, null);
            }
            else if (keyData == Keys.NumPad9)
            {
                button8_Click(null, null);
            }
            else if (keyData == Keys.Subtract)
            {
                button9_Click(null, null);
            }
            else if (keyData == Keys.Add)
            {
                button13_Click(null, null);
            }
            else if (keyData == Keys.Divide)
            {
                button3_Click(null, null);
            }
            else if (keyData == Keys.Multiply)
            {
                button4_Click(null, null);
            }
            else if (keyData == Keys.Decimal)
            {
                button19_Click(null, null);
            }
            else if (keyData == Keys.D9)
            {
                button1_Click(null, null);
            }
            else if (keyData == Keys.D0)
            {
                button5_Click(null, null);
            }
            return true;
        }

        /**更新右边的运算记录*/
        private void upDateListView(string s)
        {
            this.listView1.BeginUpdate();
            ListViewItem list = new ListViewItem();
            list.Checked = true;
            //list.SubItems.Add(s + "=" + Scientific.Scientific.resultD.ToString());
            list.Text = s + "=" + Scientific.Scientific.resultD.ToString();
            this.listView1.Items.Add(list);

            //this.listView1.Items[this.listView1.Items.Count - 1] = HorizontalAlignment.Center;
            this.listView1.EndUpdate();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }


        /**清空列表**/
        private void button20_Click_1(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Shift && (e.KeyCode == Keys.OemOpenBrackets))
            //{
            //    button1_Click(null, null);
            //}
        }
    }
}
