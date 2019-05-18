using System;
using System.Collections;

namespace Draw_Composite_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Picture root = new Picture("Root");

            root.Add(new Line("Line"));
            root.Add(new Circle("Circle"));
            root.Add(new Rectangle("Rectangle"));

            root.Draw();
            Console.ReadLine();
        }
    }

    public abstract class Graphics
    {
        protected string Name;

        protected Graphics(string name)
        {
            Name = name;
        }
        public abstract void Draw();
    }

    public class Picture : Graphics
    {
        protected ArrayList PicList = new ArrayList();

        public Picture(string name) : base(name)
        { }
        public override void Draw()
        {
            Console.WriteLine($"Draw a {Name}");

            foreach (Graphics g in PicList)
            {
                g.Draw();
            }
        }

        public void Add(Graphics g)
        {
            PicList.Add(g);
        }
        public void Remove(Graphics g)
        {
            PicList.Remove(g);
        }
    }

    public class Line : Graphics
    {
        public Line(string name) : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine($"Draw a {Name}");
        }
    }

    public class Circle : Graphics
    {
        public Circle(string name)
            : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine($"Draw a {Name}");
        }
    }

    public class Rectangle : Graphics
    {
        public Rectangle(string name) : base(name)
        { }

        public override void Draw()
        {
            Console.WriteLine($"Draw a {Name}");
        }
    }
}
