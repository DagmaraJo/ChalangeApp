using ChalangeApp;

Console.WriteLine("Witamy w programie do oceny Pracowników");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("   podaj kolejną ocenę Pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);

}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}:N2");
Console.WriteLine($"    Min: {statistics.Min}:N2");
Console.WriteLine($"    Max: {statistics.Max}:N2");
