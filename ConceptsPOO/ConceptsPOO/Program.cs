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

Console.WriteLine(employee1);

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

Console.WriteLine(employee2);