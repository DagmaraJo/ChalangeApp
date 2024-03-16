using ChalangeApp;

Console.WriteLine("Witamy w programie do oceny Pracowników");
Console.WriteLine("---------------------------------------");
Console.WriteLine();
//Console.WriteLine("Wprowadż imię i nazwisko Pracownika");
//Console.ReadLine();
var employee = new EmployeeInFile("Jan", "Majewski");
//Console.WriteLine("   podaj ocenę Pracownika");
//Console.ReadLine();
//employee.AddGrade(0.8f);
//employee.AddGrade(35);
//employee.AddGrade(3.141592);
//employee.AddGrade('B');
//employee.AddGrade("d");
while (true)
{
    Console.WriteLine("   podaj kolejną ocenę Pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched; {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"OVERALL LETTER GRADE:");
Console.WriteLine($"  {statistics.AverageLetter}");
Console.WriteLine($"    Min: {statistics.Min:N2}");
Console.WriteLine($"    Max: {statistics.Max:N2}");
Console.WriteLine($"Average: {statistics.Average:N2}");
