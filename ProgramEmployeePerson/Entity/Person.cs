using ProgramEmployeePerson.Interfaces;

namespace ProgramEmployeePerson.Entity
{
    internal class Person : IPrint
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string Name { get; set; }
        private int Age { get; set; }

        public string getName() => this.Name;
        public int getAge() => this.Age;

        public virtual void Print()
        {
            Console.WriteLine($"\n***Persona*** \nNombre: { Name } \nEdad: { Age }");
        }
    }
}
