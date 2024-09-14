using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form(2, 4);
            double s=f.Surface();
            Console.WriteLine(s);
        }
    }
    class Form
    {
        double width, height;
        public Form(double a, double b)
        {
            width = a; height = b;
        }
        public double Width
        {
            get { return width; }
            set { if (value >= 0) width = value; }
        }
        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 0) height = value;
            }
        }
            public virtual double Surface()
            {
            return Width*Height;
             }

    
    }
    class Triangle:Form
    { 
        public Triangle(double _a,double b) : base(_a, b) { }
        public override double Surface()
        {
            return Width * Height / 2;
        }
    }
    class Paralelogram : Form
    {
        double alfa;
        public Paralelogram(double w,double h,double al):base(w, h){Alfa=al* Math.PI/180; }
        public double Alfa
        {
            get { return alfa; }
            set { if (value > 0) alfa = value; }
        }
        public override double Surface()
        {
            return base.Surface()*Math.Sin(Alfa);
        }
    }

}
