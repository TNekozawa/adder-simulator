using Core;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Dictionary<int, TextBox>? TextBoxDic;

        public Form1()
        {
            InitializeComponent();
            CreateTextBox();
            InitializeTextBox();
        }
        private void CreateTextBox()
        {
            TextBoxDic = new Dictionary<int, TextBox>
            {
                { 1, textBox1 },
                { 2, textBox2 },
                { 3, textBox3 }
            };
        }

        private void InitializeTextBox()
        {
            if (TextBoxDic == null)
            {
                return;
            }
            else
            {
                foreach (var box in TextBoxDic.Values)
                {
                    box.Text = "";
                }
                richTextBox1.Text = "";
            }
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            InitializeTextBox();
        }

        private void RunCalculator(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            Tuple<string, string> tuple = Processor.RunCalculator(input1, input2);
            textBox3.Text = tuple.Item1;
            richTextBox1.Text = tuple.Item2;
        }
    }
}
