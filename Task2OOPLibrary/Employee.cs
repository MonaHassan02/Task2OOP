
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2OOPLibrary
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public enum Gender
    {
        M,
        F
    }

    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel Level { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public Gender Gender { get; set; }

        
        public Employee(int id, string name, SecurityLevel level, decimal salary, HireDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            Level = level;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format(
                "ID: {0}, Name: {1}, Gender: {2}, Level: {3}, Salary: {4}, Hire Date: {5}",
                Id, 
                Name, 
                Gender,
                Level,
                string.Format("{0:C}", Salary),
                HireDate
            );
        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1; 
            return HireDate.CompareTo(other.HireDate);
        }
    }
}
