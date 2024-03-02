using ChalangeApp;
Employee emp1 = new ("Jan", "Kowalski", "39");
Employee emp2 = new ("Ewa", "Lorek","28");
Employee emp3 = new ("Piotr", "Banach", "34");
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
Employee bestEmp = null ;
int bestResult = -1;

foreach ( var emp in employees)
{
    if (emp.Result >= bestResult)
    {
        bestResult = emp.Result;
        bestEmp = (Employee)emp;
    }
}
if (bestEmp != null)
{
    Console.WriteLine($"Employee of the week : {bestEmp.Name} {bestEmp.Surname}   BEST RESULT : {bestResult} scores");
}