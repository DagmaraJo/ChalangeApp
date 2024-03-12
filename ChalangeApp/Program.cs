using ChalangeApp;

Console.WriteLine("Witamy w programie do oceny Pracowników");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

var supervisor = new Supervisor();

Console.WriteLine("Wprowadż imę i nazwisko Pracownika");
var name = Console.ReadLine();
var surname = Console.ReadLine();
Console.WriteLine("   podaj ocenę Pracownika");
Console.ReadLine();

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
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched; {e.Message}");
    }
}

var statistics = supervisor.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"    Min: {statistics.Min:N2}");
Console.WriteLine($"    Max: {statistics.Max:N2}");
