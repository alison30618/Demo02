using MyLibrary;
using static MyLibrary.Employee;

Secretary Maria = new Secretary();
Maria.Name = "Maria";
Manager Pedro = new Manager();
Pedro.Name = "Pedro";
Developer Miguel = new Developer();
Miguel.Name = "Miguel";
Console.WriteLine($"Dias: {Miguel.GetPaymentDays()}");

WriteEmployeeinfo(Maria);
WriteEmployeeinfo(Pedro);
WriteEmployeeinfo(Miguel);

void WriteEmployeeinfo(Employee employee)
{
    Console.WriteLine($"{ employee.Name}: {employee.CalculatorMonthlyPayment()}");
    Console.WriteLine($"Days:  {employee.GetPaymentDats()}");
}