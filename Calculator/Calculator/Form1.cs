using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            displayBox.Enter += (s, e) => { displayBox.Parent.Focus(); };

        }

        private void updateValue(double n)
        {
            var val = Program.acc.getValue() * 10 + n;
            Program.acc.setValue(val);
            this.displayBox.Text = val.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            updateValue(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateValue(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateValue(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateValue(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateValue(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateValue(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateValue(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateValue(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateValue(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updateValue(9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            Program.op.setOperation('+');

            var v = Program.acc.getValue();
            Program.acc2.setValue(v);
            Program.acc.setValue(0);
            updateValue(0);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Program.op.setOperation('-');

            var v = Program.acc.getValue();
            Program.acc2.setValue(v);
            Program.acc.setValue(0);
            updateValue(0);
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            Program.op.setOperation('*');

            var v = Program.acc.getValue();
            Program.acc2.setValue(v);
            Program.acc.setValue(0);
            updateValue(0);
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            Program.op.setOperation('/');

            var v = Program.acc.getValue();
            Program.acc2.setValue(v);
            Program.acc.setValue(0);
            updateValue(0);
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            var v1 = Program.acc.getValue();
            var v2 = Program.acc2.getValue();
            var result = Program.op.perform(v1, v2);
            Program.acc.setValue(0);
            updateValue(result);
        }

        private void button_plusMinus_Click(object sender, EventArgs e)
        {
            var v1 = Program.acc.getValue();
            v1 = -v1;
            Program.acc.setValue(0);
            updateValue(v1);
        }

        private void button_root_Click(object sender, EventArgs e)
        {
            var v = Program.acc.getValue();
            if (v < 0)
                return;
            v = Math.Sqrt(v);
            Program.acc.setValue(0);
            updateValue(v);
        }

        private void button_inverse_Click(object sender, EventArgs e)
        {
            var v = Program.acc.getValue();
            v = 1 / v;
            Program.acc.setValue(0);
            updateValue(v);
        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
