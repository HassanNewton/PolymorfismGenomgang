using System;
using static PolymorfismGenomgang.Program;

namespace PolymorfismGenomgang
{
    public abstract class Employee
    {
        //Egenskap som finns gemensamt i alla subklasser
        public string Name { get; set; }

        //konstruktor
        public Employee(string Name)
        {
            this.Name = Name;
        }

        //Abstrakt metod som MÅSTE implementeras i subklasserna
        public abstract double CalculateSalary();

        static void Main(string[] args)
        {
            Employee e1 = new TimEmployee("Hassan", 100, 200);
            Employee e2 = new FastEmployee("Benjamin", 100000);
            Employee e3 = new ProvisionEmployee("Nän", 200000, 0.1);

            List<Employee> employees = new List<Employee> { e1, e2, e3 };
            
            foreach(Employee e in employees)
            {
                Console.WriteLine($"{e.Name}s lön är {e.CalculateSalary()}");
            }
        }
    }





    public class TimEmployee : Employee
    {
        //Egenskaper
        public double TimLön { get; set; }
        public int Timmar { get; set; }

        //Konstruktor
        public TimEmployee(string Name, double TimLön, int Timmar) : base(Name)
        {
            this.TimLön = TimLön;
            this.Timmar = Timmar;
        }

        //Metoder
        public override double CalculateSalary()
        {
            return TimLön * Timmar;
        }
    }

    public class FastEmployee : Employee
    {
        //Egenskaper
        public double Månadslön { get; set; }

        //Konstruktor
        public FastEmployee(string Name, double Månadslön) : base(Name)
        {
            this.Månadslön = Månadslön;
        }

        //Metod
        public override double CalculateSalary()
        {
            return Månadslön;
        }
    }

    public class ProvisionEmployee : Employee
    {
        //Egenskaper
        public double Försäljning { get; set; }
        public double Provision { get; set; }

        //Konstruktor
        public ProvisionEmployee(string Name, double Försäljning, double Provision) : base(Name)
        {
            this.Försäljning = Försäljning;
            this.Provision = Provision;
        }

        //Metod
        public override double CalculateSalary()
        {
            return Försäljning * Provision;
        }
    }






    

    
}

