using System;
using System.Collections.Generic;

namespace Student_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new BrainyStudent(),
                new InferiorStudent()
                //...
            };

            Visitor v = new ReleaseScoreVisitor();
            Visitor v2 = new VacationVisitor();

            foreach (var student in students)
            {
                student.Accept(v);
                student.Accept(v2);
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// 抽象学生类
    /// </summary>
    public abstract class Student
    {
        /// <summary>
        /// 处理Visitor这个抽象事件。
        ///（可能是出成绩、放假等。这里抽象化了，以便随时改)
        /// </summary>
        /// <param name="v"></param>
        public abstract void Accept(Visitor v);
    }

    public abstract class Visitor
    {    // 抽象的访问方式类
        public abstract void VisitBrainyStudent(BrainyStudent brainyStudent);    // 访问学霸
        public abstract void VisitInferiorStudent(InferiorStudent inferiorStudent);    // 访问学渣
    }

    /// <summary>
    /// 学霸
    /// </summary>
    public class BrainyStudent : Student
    {
        /// <summary>
        /// 学霸处理事件
        /// </summary>
        /// <param name="v"></param>
        public override void Accept(Visitor v)
        {
            // 调用对学霸的处理方法
            v.VisitBrainyStudent(this);
        }
    }

    /// <summary>
    /// 学渣
    /// </summary>
    public class InferiorStudent : Student
    {
        /// <summary>
        /// 学渣处理事件
        /// </summary>
        /// <param name="v"></param>
        public override void Accept(Visitor v)
        {
            // 调用对学渣的处理方法
            v.VisitInferiorStudent(this);
        }
    }

    public class ReleaseScoreVisitor : Visitor
    {
        public override void VisitBrainyStudent(BrainyStudent brainyStudent)
        {
            Console.WriteLine("出成绩了，开心");
        }

        public override void VisitInferiorStudent(InferiorStudent inferiorStudent)
        {
            Console.WriteLine("出成绩了，不开心");
        }
    }

    public class VacationVisitor : Visitor
    {
        public override void VisitBrainyStudent(BrainyStudent brainyStudent)
        {
            Console.WriteLine("放假了，不开心");
        }

        public override void VisitInferiorStudent(InferiorStudent inferiorStudent)
        {
            Console.WriteLine("放假了，开心");
        }
    }
}
