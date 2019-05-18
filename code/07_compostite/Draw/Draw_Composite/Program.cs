using System;
using System.Collections;

namespace Draw_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public abstract class Graphics
        {
            protected string Name;

            protected Graphics(string name)
            {
                this.Name = name;
            }
            public abstract void Draw();

            public abstract void Add(Graphics g);
            public abstract void Remove(Graphics g);
        }

        public class Picture : Graphics
        {
            protected ArrayList PicList = new ArrayList();

            public Picture(string name) : base(name)
            { }
            public override void Draw()
            {
                Console.WriteLine($"Draw a{Name}");

                foreach (Graphics g in PicList)
                {
                    g.Draw();
                }
            }

            public override void Add(Graphics g)
            {
                PicList.Add(g);
            }
            public override void Remove(Graphics g)
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
                Console.WriteLine($"Draw a{Name}");
            }

            public override void Add(Graphics g)
            {
                //抛出一个我们自定义的异常
            }

            public override void Remove(Graphics g)
            {
                //抛出一个我们自定义的异常
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
            public override void Add(Graphics g)
            { }
            public override void Remove(Graphics g)
            { }
        }

        public class Rectangle : Graphics
        {
            public Rectangle(string name) : base(name)
            { }

            public override void Draw()
            {
                Console.WriteLine($"Draw a{Name}");
            }
            public override void Add(Graphics g)
            { }
            public override void Remove(Graphics g)
            { }
        }


    }
}
