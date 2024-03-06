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
            if(grade >=0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            } 
        }
        public void AddGrade(long grade) //  ponad 9 cyfr
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)  // np 3.14
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }

            var value = float.Parse(grade);
        }

        public void AddGrade(char grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        //public void AddGrade2(string grade)
        //{
        //    float.TryParse(grade, out float result);
        //    var value = float.Parse(grade);
        //    this.AddGrade(value);
        //}


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

            statistics.Average /= this.grades.Count;
            
            return statistics;
        }
    }
}