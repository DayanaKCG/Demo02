using MyLibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";
Manager Pedro = new Manager();
Pedro.Name = "Pedro";
Developer Miguel = new Developer();
Console.WriteLine($"Dias : {Miguel.GetPaymentDays()}");

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Miguel);
WriteEmployeeInfo(Pedro);
void WriteEmployeeInfo(Employee employee)
{
	Console.WriteLine($"{employee.Name}:{employee.CalculateMonthlyPayment()} ");
	Console.WriteLine($"Days : {employee.GetPaymentDays()}");
}

