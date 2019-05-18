using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
                {
                    new BrainyStudent(),
                    new InferiorStudent()
                    //...
                };

            //// 出成绩了
            //foreach (var student in students)
            //{
            //    if (student is BrainyStudents)
            //    {
            //        Console.WriteLine("出成绩了,开心");
            //    }
            //    else
            //    {
            //        Console.WriteLine("出成绩了,不开心");
            //    }
            //}

            //// 放假了
            //foreach (var student in students)
            //{
            //    if (student is BrainyStudents)
            //    {
            //        Console.WriteLine("放假了不能学习,不开心");
            //    }
            //    else
            //    {
            //        Console.WriteLine("放假了不用学习,开心");
            //    }
            //}

            foreach (var student in students)
            {
                student.ReleaseScore();
                student.Vacation();
            }
        }
    }

    /// <summary>
    /// 抽象学生类
    /// </summary>
    public abstract class Student
    {
        /// <summary>
        /// 放假方法
        /// </summary>
        public abstract void Vacation();

        /// <summary>
        /// 出成绩方法
        /// </summary>
        public abstract void ReleaseScore();
    }

    /// <summary>
    /// 学霸
    /// </summary>
    public class BrainyStudent : Student
    {
        public override void Vacation()
        {
            Console.WriteLine("放假了不能学习，不开心");
        }

        public override void ReleaseScore()
        {
            Console.WriteLine("出成绩了，开心");
        }
    }

    /// <summary>
    /// 学渣
    /// </summary>
    public class InferiorStudent : Student
    {
        public override void Vacation()
        {
            Console.WriteLine("放假了不用学习,开心");
        }

        public override void ReleaseScore()
        {
            Console.WriteLine("出成绩了,不开心");
        }
    }
}
