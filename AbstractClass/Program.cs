using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Shape
    {
        public int r, l, b, a;
        public abstract void accept();
        public abstract void area();
        public void display()
        {
            Console.WriteLine("Hello Shape!!!");
        }

        public abstract void closing();

    }

    class Rectangle : Shape
    {
        public override void accept()
        {
            Console.WriteLine("Enter lenght and breadth");
            l = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public override void area()
        {
            a = l * b;
            Console.WriteLine("The area of the rectangle is {0}", a);
        }

        public override void closing() { }

    }


    class Square : Shape
    {
        public override void accept()
        {
            Console.WriteLine("Enter the side for square");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(l);
        }

        public override void area()
        {
            a = l * l;
            Console.WriteLine("Area of the Square {0}", a);
        }

        public override void closing()
        {
            Console.WriteLine("Created Square");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Demo!");
            Rectangle rect = new Rectangle();
            rect.display();
            rect.accept();
            rect.area();

            Console.WriteLine("Working with Square");
            Square sq = new Square();
            sq.accept();
            sq.area();
            sq.closing();
            Console.ReadKey();
        }

    }
}


