using ChalangeApp;

Console.WriteLine("Welcome to the company's RATING SYSTEM");
Console.WriteLine("---------------------------------------");
Console.WriteLine();
Console.WriteLine("    provide employee details");
//Console.ReadLine();
var employee = new Supervisor("Jan", "Majewski");
employee.GradeAdded += EmployeeGradeAdded;
Console.ReadLine();
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("the new rating is already in the SYSTEM");
}

//Console.WriteLine("   podaj ocenę Pracownika");
//Console.ReadLine();
//employee.AddGrade(0.8f);
//employee.AddGrade(35);
//employee.AddGrade(3.141592);
//employee.AddGrade('B');
//employee.AddGrade("d");
while (true)
{
    Console.WriteLine("   add another rating");
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
