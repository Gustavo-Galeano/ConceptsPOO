// See https://aka.ms/new-console-template for more information
using ConceptsPOO;
using System.Data;

Console.WriteLine("POO Concepts!");
Console.WriteLine("=============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName= "Test",
    LastName= "Test Last name",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 2500000.25M
};

//Console.WriteLine(employee1);

Employee employee2 = new ComissionEmployee()
{
    Id = 1010,
    FirstName = "Gustavo",
    LastName = "Galeano",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};

//Console.WriteLine(employee2);


Employee employee3 = new HourlyEmployee()
{
    Id = 3399,
    FirstName = "Jose",
    LastName = "Leguizamon",
    BirthDate = new Date(1998, 5, 23),
    HiringDate = new Date(2022, 4, 15),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.55F
};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 3350,
    FirstName = "Laura",
    LastName = "Leguizamon",
    BirthDate = new Date(1998, 5, 23),
    HiringDate = new Date(2022, 4, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F
};

//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1,
    employee2,
    employee3,
    employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("             ===============");

Console.WriteLine($"TOTAL        {$"{payroll:C2}", 15}");

Invoice invoice1 = new Invoice()
{
    Description = "IPhone 12",
    Id = 1,
    Price = 5300000M,
    Quatity = 6

};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premiun",
    Id = 2,
    Price = 32000M,
    Quatity = 17.5F

};

Console.WriteLine(invoice1);

Console.WriteLine(invoice2);
