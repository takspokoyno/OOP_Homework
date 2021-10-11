using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_and_Perimeter
{
    abstract class Figure
    {
        internal double Square;
        internal double Perimeter;
        internal abstract double CalculateSquare();
        internal abstract double CalculatePerimeter();
    }
    class Round : Figure
    {
        internal double Radius;
        internal Round(double Radius_)
        {
            Radius = Radius_;
        }
        internal override double CalculateSquare()
        {
            Square = Math.Round(Math.PI * Radius * Radius, 3);
            return Square;
        }
        internal override double CalculatePerimeter()
        {
            Perimeter = Math.Round(Math.PI * Radius * 2, 3);
            return Perimeter;
        }
    }
    class Triangle : Figure
    {
        internal double a;
        internal double b;
        internal double c;
        internal Triangle(double a_, double b_, double c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }
        internal override double CalculatePerimeter()
        {
            Perimeter = a + b + c;
            return Perimeter;
        }
        internal override double CalculateSquare()
        {
            Square = Math.Sqrt(CalculatePerimeter() / 2 * (CalculatePerimeter() / 2 - a) * (CalculatePerimeter() / 2 - b) * (CalculatePerimeter() / 2 - c));
            return Square;
        }
    }
    class Quadrat : Figure
    {
        internal double Side;
        internal Quadrat(double Side_)
        {
            Side = Side_;
        }
        internal override double CalculateSquare()
        {
            Square = Side * Side;
            return Square;
        }
        internal override double CalculatePerimeter()
        {
            Perimeter = Side * 4;
            return Perimeter;
        }
    }
    class Romb : Quadrat
    {
        internal double Angle;
        internal Romb(double Side_, double Angle_) : base(Side_)
        {
            Side = Side_;
            Angle = Angle_;
        }
        internal override double CalculateSquare()
        {
            Square = Side * Side * Math.Sin(Angle/180*Math.PI);
            return Square;
        }
    }
    class Rectangle : Figure
    {
        internal double a;
        internal double b;
        internal Rectangle(double a_, double b_)
        {
            a = a_;
            b = b_;
        }
        internal override double CalculatePerimeter()
        {
            Perimeter = 2 * a + 2 * b;
            return Perimeter;
        }
        internal override double CalculateSquare()
        {
            Square = a * b;
            return Square;
        }
    }

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
