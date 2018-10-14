using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3.ExampleClasses
{
    public interface IPerson
    {
        string Name { get; }
        string Surname { get; }
    }

    public class PersonDetailsProvider
    {
        public static void PrintDetail(IPerson person)
        {
            Console.WriteLine(string.Format("{0} {1}", person.Name, person.Surname));
        }
    }
}
