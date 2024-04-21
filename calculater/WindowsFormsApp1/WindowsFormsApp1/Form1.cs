using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        string opration = "";
        int result_value = 0;
        bool is_operation = false;

        public form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" || is_operation)
            { textBox1.Clear(); }

            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
            is_operation = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void op_button(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            opration = btn.Text;

            result_value = int.Parse(textBox1.Text);
            textBox3.Text = result_value + opration;
            is_operation = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (opration)
            {
                case "+":
                    textBox1.Text = (result_value + int.Parse(textBox1.Text)).ToString();
                    break;


                case "-":
                    textBox1.Text = (result_value - int.Parse(textBox1.Text)).ToString();
                    break;



                case "×":
                    textBox1.Text = (result_value * int.Parse(textBox1.Text)).ToString();
                    break;


                case "÷":
                    textBox1.Text = (result_value / int.Parse(textBox1.Text)).ToString();
                    break;

               
            }
                 
        }
    }
}
