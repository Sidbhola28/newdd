using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasses
{

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi I am {0}, Hello {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var person = Person.Parse("MOsh");
            person.Introduce("john");

            Customer customer = new Customer(1,"john");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
