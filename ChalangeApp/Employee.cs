namespace ChalangeApp
{
    public class Employee
    {
        public List<int> grades = new List<int> ();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        
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
                return this.grades.Sum();
            }
        }
        public void AddGrade (int grade)
        {
            this.grades.Add(grade);
        }
    }
}
