
using ProgramEmployeePerson.Entity;

Person person = new Person("Jose Miguel", 22);
person.Print();

Employee employee = new Employee(person, 50000);
employee.Print();