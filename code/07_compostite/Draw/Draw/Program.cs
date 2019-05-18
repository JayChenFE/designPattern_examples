using System;
using System.Collections;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Graphics
    {
        protected string Name;

        protected Graphics(string name)
        {
            this.Name = name;
        }
        public abstract void Draw();
    }

    public class Picture : Graphics
    {
        public Picture(string name) : base(name)
        {
        }

        public override void Draw()
        {
            //
        }

        public ArrayList GetChilds()
        {
            //返回所有的子对象
            return null;
        }
    }

    public class Line : Graphics
    {
        public Line(string name) : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine($"Draw a{Name}");
        }
    }

    public class Circle : Graphics
    {
        public Circle(string name) : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine($"Draw a{Name}");
        }
    }

    public class Rectangle : Graphics
    {
        public Rectangle(string name) : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine($"Draw a{Name}");
        }
    }

}
