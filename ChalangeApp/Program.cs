using ChalangeApp;

Console.WriteLine("Witamy w programie do oceny Pracowników");
Console.WriteLine("---------------------------------------");
Console.WriteLine();
Console.WriteLine("Wprowadż imię i nazwisko Pracownika");

var employee = new EmployeeInFile("Jan", "Majewski");
Console.WriteLine("   podaj ocenę Pracownika");
employee.AddGrade(0.8f);
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
Console.WriteLine($"OVERALL LETTER GRADE: {statistics.AverageLetter:N2}");
Console.WriteLine($"  {statistics.AverageLetter:N2}");
Console.WriteLine($"    Min: {statistics.Min:N2}");
Console.WriteLine($"    Max: {statistics.Max:N2}");
Console.WriteLine($"Average: {statistics.Average:N2}");
