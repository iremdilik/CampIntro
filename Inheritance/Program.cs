using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                    new Customer{FirstName= "Engin" }, 
                    new Student{FirstName = "Derin" },
                    new Person{FirstName = "Salih" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }

            Console.ReadLine();

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {
        //class customer'a bu person2 ti koymaya çalışsak koyamazdık.
        //sadece bir kere inheritance alabiliriz
        //yani bir interface olsaydı istediğimiz kadar koyabilirdik.
        //inheritance önce yazılır daha sonra kaç tane imterface varsa koyarsın.
        //classların tek başına bir anlamı vardır ama interfacelerin yoktur.
        //interface tercih et, inheritance zorunluluğun yoksa

    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
