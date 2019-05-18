using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("app.json", true, true).Build();

            var factoryName = configuration["factoryName"];

            var factory = AbstractFactory.GetInstance(factoryName);


            var bonus = factory.CreateBonus();
            var bonusValue = bonus.Calculate();

            var tax = factory.CreateTax();
            var taxValue = tax.Calculate();

            double salary = Constant.BaseSalary + bonusValue - taxValue;

            Console.WriteLine($"Salary is：{salary}");
        }
    }

    /// <summary>
    /// 抽象Factory类
    /// </summary>
    public abstract class AbstractFactory
    {
        public static AbstractFactory GetInstance(string factoryName)
        {
            AbstractFactory instance = null;

            if (factoryName != "")
            {
                instance = (AbstractFactory)Assembly.GetExecutingAssembly().CreateInstance(factoryName);
            }

            return instance;
        }


        public abstract Tax CreateTax();

        public abstract Bonus CreateBonus();
    }

    /// <summary>
    /// AmericanFactory类
    /// </summary>
    public class AmericanFactory : AbstractFactory
    {
        public override Tax CreateTax()
        {
            return new AmericanTax();
        }

        public override Bonus CreateBonus()
        {
            return new AmericanBonus();
        }
    }

    /// <summary>
    /// ChineseFactory类
    /// </summary>
    public class ChineseFactory : AbstractFactory
    {
        public override Tax CreateTax()
        {
            return new ChineseTax();
        }

        public override Bonus CreateBonus()
        {
            return new ChineseBonus();
        }
    }

    /// <summary>
    /// 奖金抽象类
    /// </summary>
    public abstract class Bonus
    {
        public abstract double Calculate();
    }

    /// <summary>
    /// 个人所得税抽象类
    /// </summary>
    public abstract class Tax
    {
        public abstract double Calculate();
    }

    /// <summary>
    /// 计算中国个人奖金
    /// </summary>
    public class ChineseBonus : Bonus
    {
        public override double Calculate()
        {
            return Constant.BaseSalary * 0.1;
        }
    }

    /// <summary>
    /// 计算中国个人所得税
    /// </summary>
    public class ChineseTax : Tax
    {
        public override double Calculate()
        {
            return (Constant.BaseSalary + (Constant.BaseSalary * 0.1)) * 0.4;
        }
    }

    /// <summary>
    /// 计算美国奖金
    /// </summary>
    public class AmericanBonus : Bonus
    {
        public override double Calculate()
        {
            return Constant.BaseSalary * 0.15;
        }
    }

    /// <summary>
    /// 计算美国个人所得税
    /// </summary>
    public class AmericanTax : Tax
    {
        public override double Calculate()
        {
            return Constant.BaseSalary * 0.05 + (Constant.BaseSalary * 0.15 * 0.25);
        }
    }



    public class Constant
    {
        public static double BaseSalary = 4000;
    }
}
