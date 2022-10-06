using System.Collections.Generic;
using System.Linq;
using Task2;

var departments = new List<Department>()
{
    new Department()
    {
        Name = "Water",
        Head = "Bob Bob",
        Id = 0
    },
    new Department()
    {
        Name = "Fire",
        Head = "Bob Griffin",
        Id = 1
    }
};

var gen = new EmployeeGenerator(departments);
var employees = gen.GenerateEmployees(10).ToList();

foreach (var e in employees.ToList())
{
    Console.WriteLine($"{e.Name} {e.Surname} - {e.Department.Name}");
}

Console.WriteLine();

var dic = employees.GroupBy(e => e.Department.Name);

foreach (var d in dic)
{
    Console.WriteLine(d.Key);
    foreach (var e in d.ToList())
    {
        Console.WriteLine($"{e.Name} {e.Surname}");
    }
    Console.WriteLine();
}