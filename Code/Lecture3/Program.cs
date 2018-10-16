using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lecture3.ExampleClasses;

namespace Lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple function example - look through code:");
            DateExample();
            Console.WriteLine();

            Console.WriteLine("Inheritence & interface - look through code:");
            InheritenceExample();
            InterfaceDemo();
            Console.WriteLine();

            Console.WriteLine("Generics demo:");
            GenericsDemo();
            Console.Read();
            Console.WriteLine();

            Console.WriteLine("Anonymous functions demo - look through code");
            AnonymousFunctionsDemo();
            Console.Read();
        }

        static void DateExample()
        {
            var dateFromDefaultConstructor = new Date();
            var dateFromHelperFunction = Date.CreateDate(10, 10, 2018);
            var dateFromCopyConsturctor = new Date(dateFromHelperFunction);

            //Getter
            var dayOfMonth  = dateFromCopyConsturctor.GetDayOfMonth();
            //Setter
            dateFromCopyConsturctor.SetDayOfMonth(dayOfMonth + 1);

            var yearFromAutoProperty = dateFromCopyConsturctor.Year;
        }

        static void AnonymousFunctionsDemo()
        {
            //Syntax for anonymous function (also called lambda expression)
            Func<double, double> normalDensity = (x) => Math.Exp(-x * x / 2.0) / Math.Sqrt(2 * Math.PI);
            double integral = IntegrateCompTrapezium(normalDensity, -10, 10, 10000);
            Console.WriteLine("Integral = {0}", integral);
            //Method with a matching signature (Func<double, double>) can also be used:
            double integral2 = IntegrateCompTrapezium(NormalDensityMethod, -10, 10, 10000);
            Console.WriteLine("Integral = {0}", integral2);
        }

        static double NormalDensityMethod(double x)
        {
            return Math.Exp(-x * x / 2.0) / Math.Sqrt(2 * Math.PI);
        }

        static double IntegrateCompTrapezium(Func<double, double> f, double a, double b, int N)
        {
            double h = (b - a) / N;
            double integral = 0;
            for (int i = 0; i < N; i++)
            {
                double x0 = a + i * h, x1 = a + (i + 1) * h;
                integral += (0.5 * (f(x0) + f(x1))) * h;
            }
            return integral;
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T tmp = rhs;
            rhs = lhs;
            lhs = tmp;
        }
        public static void GenericsDemo()
        {
            string left = "left", right = "right";
            Console.WriteLine("lhs={0}, rhs={1}", left, right);
            Swap<string>(ref left, ref right);
            Console.WriteLine("lhs={0}, rhs={1}", left, right);
            int lhs = -10, rhs = 10;
            Console.WriteLine("lhs={0}, rhs={1}", lhs, rhs);
            Swap<int>(ref lhs, ref rhs);
            Console.WriteLine("lhs={0}, rhs={1}", lhs, rhs);
            double l = -10.1, r = 10.1;
            Console.WriteLine("lhs={0}, rhs={1}", l, r);
            Swap<double>(ref l, ref r);
            Console.WriteLine("lhs={0}, rhs={1}", l, r);
        }

        static void InheritenceExample()
        {
            //Person person = new Person("John", "Smith");
            Person student = new Student("John", "Smith", 1234);
            UniversityStaff uniStaff = new UniversityStaff("John", "Smith", "john.smith@domain.com");
            Lecturer lectuer = new Lecturer("John", "Smith", "john.smith@domain.com", 1);
            UniversityStaff uniStaff2 = lectuer as UniversityStaff;
        }

        static void InterfaceDemo()
        {
            Person student = new Student("Jenny", "Smith", 1235);
            UniversityStaff uniStaff = new UniversityStaff("John", "Smith", "john.smith@domain.com");
            Lecturer lectuer = new Lecturer("Adam", "Doe", "adam.doe@domain.com", 2);

            PersonDetailsProvider.PrintDetail(student);
            PersonDetailsProvider.PrintDetail(uniStaff);
            PersonDetailsProvider.PrintDetail(lectuer);
            Console.WriteLine();
        }
    }
}   
