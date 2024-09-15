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
            //virtualfield
            Credit c = new Credit(689);
            decimal cc = c.Sum;
            Console.WriteLine(cc);

        }
    }
    class Form//shakl
    {
        double width, height;//eni ,bo'yi
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
            public virtual double Surface()//yuzasi
            {
            return Width*Height;
             }

    
    }
    class Triangle:Form//uchburchak
    { 
        public Triangle(double _a,double b) : base(_a, b) { }
        public override double Surface()
        {
            return base.Surface() / 2;
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
    //Xususiyatlar qayta aniqlanishi
    class Credit
    {
        protected decimal sum;
        public Credit(decimal s)
        {
            sum = s;
        }
        public virtual decimal Sum
        {
            get { return sum; }
            set { sum = value; }
        }
    }
    class LongCredit : Credit
    {
        public LongCredit(decimal Is):
            base(Is)
        { }
        public override decimal Sum
        {
            get { return sum; }
            set { if (value > 1000) sum = value; }
        }
    }

}
