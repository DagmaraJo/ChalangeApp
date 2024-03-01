using ChalangeApp;


Employee emp1 = new Employee("Jan", "Kowalski", "39");
Employee emp2 = new Employee("Ewa", "Lorek","28");
Employee emp3 = new Employee("Piotr", "Banach", "34");

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

Employee Best_Emp = null ;


int best_Result = -1;
foreach ( var emp in employees)
{
    if (emp.Result > best_Result)
    {
        best_Result = emp.Result;
        Best_Emp = (Employee)emp;
    }
}
if (Best_Emp != null)
    Console.WriteLine("Employee of the week : " +Best_Emp.Name +" " +Best_Emp.Surname +"    best result :  " +best_Result +" scores");

