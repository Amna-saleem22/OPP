using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Shape
    {
       
        public abstract void Draw();

        
        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape;

            shape = new Circle();
            shape.Display(); 
            shape.Draw();    

            shape = new Rectangle();
            shape.Display(); 
            shape.Draw();
        }
    }
}
