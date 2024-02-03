
using System.Xml.Linq;

namespace ProgramEmployeePerson.Entity
{
    internal  class Employee : Person
    {
        public Employee(Person person, int salary) : base(person.getName(), person.getAge())
        {
            this.Salary = salary;
        }

        private int Salary { get; set; }

        public override void Print()
        {
            Console.WriteLine($"\n***Empleado*** \nNombre: { getName() } \nEdad: { getAge() } \nSueldo: {Salary}");
        }
    }
}
