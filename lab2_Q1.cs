using System;

class Employee
{
  
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }

    
    public Employee(string name, string email, decimal salary)
    {
        Name = name;
        Email = email;
        Salary = salary;
    }

    
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Salary: {Salary:C}");
    }


   /*static void Main()
    {
        // Create Employee object
        Employee emp = new Employee("Manisha Lama", "manisha@example.com", 55000);

        // Display employee details
        emp.DisplayEmployeeInfo();
        Console.ReadKey();
    }*/
}