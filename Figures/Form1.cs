using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_and_Perimeter
{
    public partial class Form1 : Form
    {
        private Round round;
        private Triangle triangle;
        private Quadrat quadrat;
        private Romb romb;
        private Rectangle rectangle;
        private bool check_round = false;
        private bool check_triangle = false;
        private bool check_square = false;
        private bool check_romb = false;
        private bool check_rectangle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            round = new Round(Convert.ToDouble(textBox1.Text));
            check_round = true;
            check_triangle = false;
            check_square = false;
            check_romb = false;
            check_rectangle = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox4.Text);
            if (a + b >= c && a + c >= b && b + c >= a)
            {
                triangle = new Triangle(a, b, c);
                check_round = false;
                check_triangle = true;
                check_square = false;
                check_romb = false;
                check_rectangle = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            quadrat = new Quadrat(Convert.ToDouble(textBox5.Text));
            check_round = false;
            check_triangle = false;
            check_square = true;
            check_romb = false;
            check_rectangle = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double side = Convert.ToDouble(textBox6.Text);
            double angle = Convert.ToDouble(textBox7.Text);
            romb = new Romb(side, angle);
            check_round = false;
            check_triangle = false;
            check_square = false;
            check_romb = true;
            check_rectangle = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox8.Text);
            double b = Convert.ToDouble(textBox9.Text);
            rectangle = new Rectangle(a, b);
            check_round = false;
            check_triangle = false;
            check_square = false;
            check_romb = false;
            check_rectangle = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check_round == true && check_triangle == false && check_square == false && check_romb == false && check_rectangle == false)
                label6.Text = Convert.ToString(round.CalculateSquare());
            else if (check_round == false && check_triangle == true && check_square == false && check_romb == false && check_rectangle == false)
                label6.Text = Convert.ToString(triangle.CalculateSquare());
            else if (check_round == false && check_triangle == false && check_square == true && check_romb == false && check_rectangle == false)
                label6.Text = Convert.ToString(quadrat.CalculateSquare());
            else if (check_round == false && check_triangle == false && check_square == false && check_romb == true && check_rectangle == false)
                label6.Text = Convert.ToString(romb.CalculateSquare());
            else if (check_round == false && check_triangle == false && check_square == false && check_romb == false && check_rectangle == true)
                label6.Text = Convert.ToString(rectangle.CalculateSquare());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check_round == true && check_triangle == false && check_square == false && check_romb == false && check_rectangle == false)
                label7.Text = Convert.ToString(round.CalculatePerimeter());
            else if (check_round == false && check_triangle == true && check_square == false && check_romb == false && check_rectangle == false)
                label7.Text = Convert.ToString(triangle.CalculatePerimeter());
            else if (check_round == false && check_triangle == false && check_square == true && check_romb == false && check_rectangle == false)
                label7.Text = Convert.ToString(quadrat.CalculatePerimeter());
            else if (check_round == false && check_triangle == false && check_square == false && check_romb == true && check_rectangle == false)
                label7.Text = Convert.ToString(romb.CalculatePerimeter());
            else if (check_round == false && check_triangle == false && check_square == false && check_romb == false && check_rectangle == true)
                label7.Text = Convert.ToString(rectangle.CalculatePerimeter());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
