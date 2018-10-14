using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3.ExampleClasses
{
    public abstract class Person : IPerson
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Person(string name, string surname)
        {
            //Name = name;
            Surname = surname;
        }
    }

    //DRY: Don't repeat yourself
    public class Student : Person
    {
        public int MatriculationNumber { get; private set; }

        public Student(string name, string surname, int matriculationNumber) : base(name, surname)
        {
            MatriculationNumber = matriculationNumber;
        }
    }

    public class UniversityStaff : Person
    {
        public string EmailAddress { get; private set; }

        public UniversityStaff(string name, string surname, string emailAddress) : base(name, surname)
        {
            EmailAddress = emailAddress;
        }
    }

    public class Lecturer : UniversityStaff
    {
        public int RoomNumber { get; private set; }

        public Lecturer(string name, string surname, string emailAddress, int roomNumber) : base(name, surname, emailAddress)
        {
            RoomNumber = roomNumber;
        }
    }
}
