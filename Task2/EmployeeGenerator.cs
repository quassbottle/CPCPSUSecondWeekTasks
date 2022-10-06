using System;
using System.Collections.Generic;

namespace Task2;

public class EmployeeGenerator
{
    private Random _rnd;
    private List<Department> _departments;

    private string[] _first = new[]
    {
        "John", "Bob", "Adam", "Brian"
    };

    private string[] _last = new[]
    {
        "Robinson", "Bob", "Rogers", "Griffin"
    };
    
    public EmployeeGenerator(List<Department> departments)
    {
        _rnd = new Random(Environment.TickCount);
        _departments = departments;
    }

    public Employee Generate()
    {
        return new Employee()
        {
            Age = _rnd.Next(18, 30),
            Department = _departments[_rnd.Next(_departments.Count)],
            Name = _first[_rnd.Next(_first.Length)],
            Surname = _last[_rnd.Next(_last.Length)]
        };
    }

    public IEnumerable<Employee> GenerateEmployees(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return Generate();
        }
    }
}