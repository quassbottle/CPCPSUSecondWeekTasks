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
var employees = gen.GenerateEmployees(10);
var dic = employees.GroupBy(e => e.Department.Name).ToDictionary(e => e.Key, e => e.ToList());
