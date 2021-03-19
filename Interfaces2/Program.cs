using System;

namespace Interfaces2
{
    class Program
    {
        //interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    //class PersonManager
    //{
    //    //implemented operatiom
    //    public void Add()
    //    {
    //        Console.Writeline("Eklendi");
    //    }
    //}

    interface IPersonManager
    {
        //unimplemented operarion
        void Add();
        void Update();
        
    }

    //inherits - class ---------- implements - interface

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        

}
