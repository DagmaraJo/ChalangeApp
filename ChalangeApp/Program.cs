using ChalangeApp;

Employee emp1 = new Employee ("Jan", "Kowalski", "39");
Employee emp2 = new Employee ("Ewa", "Lorek","28");
Employee emp3 = new Employee ("Piotr", "Banach", "34");
List<Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3
};

emp1.AddGrade(3);
emp1.AddGrade(2);
emp1.AddGrade(4);
emp1.AddGrade(3);
emp1.AddGrade(6);

emp2.AddGrade(2);
emp2.AddGrade(4);
emp2.AddGrade(5);
emp2.AddGrade(6);
emp2.AddGrade(7);

emp3.AddGrade(0);
emp3.AddGrade(0);
emp3.AddGrade(1);
emp3.AddGrade(2);
emp3.AddGrade(2);

//Employee bestEmp = null;
//float bestResult = -1;
//foreach ( var emp in employees)
//{
    //if (emp.Result >= bestResult)
    //{
        //bestResult = emp.Result;
       // bestEmp = (Employee)emp;
    //}
//}
//if (bestEmp != null)
{
    //Console.WriteLine($"Employee of the week : {bestEmp.Name} {bestEmp.Surname} ({bestEmp.Age})");
    //Console.WriteLine($"BEST_RESULT_:_{bestResult}_scores");
}

var employee5 = new Employee("Jan", "Dobosz", "39");
employee5.AddGrade(2);
employee5.AddGrade(2);
employee5.AddGrade(6);
var statistics = employee5.GetStatistics();
Console.WriteLine($"Average :  {statistics.Average:N2}");
Console.WriteLine($"Min:  {statistics.Min}");
Console.WriteLine($"Max :  {statistics.Max}");