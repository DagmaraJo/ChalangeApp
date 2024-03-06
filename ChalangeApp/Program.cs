using ChalangeApp;

var employee5 = new Employee("Jan", "Dobosz", "39");
employee5.AddGrade(4);
employee5.AddGrade(5);
employee5.AddGrade(7);
var statistics = employee5.GetStatistics();
Console.WriteLine($"Average :  {statistics.Average:N2}");
Console.WriteLine($"Min:  {statistics.Min}");
Console.WriteLine($"Max :  {statistics.Max}");