namespace ChalangeApp
{
    public class Employee
    {
        public List<float> grades = new List<float> ();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach( var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            //statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;         // to samo inny zapis
            return statistics;
        }
    }
}