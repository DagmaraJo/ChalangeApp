using ChalangeApp;

var employee5 = new Employee("Jan", "Dobosz", "39");
employee5.AddGrade("2000");
employee5.AddGrade('d');
employee5.AddGrade(35.5555555555559);
employee5.AddGrade(374920700936);
employee5.AddGrade(-8);

var statistics = employee5.GetStatistics();

Console.WriteLine($"Average :  {statistics.Average:N2}");
Console.WriteLine($"Min:  {statistics.Min:N2}");
Console.WriteLine($"Max :  {statistics.Max:N2}");