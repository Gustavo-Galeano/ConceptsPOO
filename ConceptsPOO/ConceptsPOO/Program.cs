// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts!");
Console.WriteLine("=============");


//Date date1  = new Date(2023, 2, 11);

try
{
	Console.WriteLine(new Date(2012, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}


