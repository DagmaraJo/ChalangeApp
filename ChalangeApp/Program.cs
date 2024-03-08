using ChalangeApp;

var employee5 = new Employee("Jan", "Dobosz", "39");
employee5.AddGrade("2000");
employee5.AddGrade(3.14f);
employee5.AddGrade(-8);
employee5.AddGrade(35.5555555555559);
employee5.AddGrade(374920700936);
employee5.AddGrade('d');

var statistics1 = employee5.GetStatisticsWithForeach();
var statistics2 = employee5.GetStatisticsWithFor();
var statistics3 = employee5.GetStatisticsWithDoWhile();
var statistics4 = employee5.GetStatisticsWithWhile();

//Console.WriteLine($"Average :  {statistics.Average:N2}");
//Console.WriteLine($"Min:  {statistics.Min:N2}");
//Console.WriteLine($"Max :  {statistics.Max:N2}");

Console.WriteLine($"  Min_{statistics1.Min:N2} Average_{statistics1.Average:N2} Max_{statistics1.Max:N2} withForeach");
Console.WriteLine($"  Min_{statistics2.Min:N2} Average_{statistics2.Average:N2} Max_{statistics2.Max:N2} withFor");
Console.WriteLine($"  Min_{statistics3.Min:N2} Average_{statistics3.Average:N2} Max_{statistics3.Max:N2} withDoWhile");
Console.WriteLine($"  Min_{statistics4.Min:N2} Average_{statistics4.Average:N2} Max_{statistics4.Max:N2} withWhile");