namespace ChalangeApp
{
    public class Employee
    {
        public List<int> Grades = new List<int> ();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; set; }
       

        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public int Result
        {
            get
            {
                return this.Grades.Sum();
            }
        }
        public void AddGrade (int grade)
        {
            this.Grades.Add(grade);
        }
    }
}
