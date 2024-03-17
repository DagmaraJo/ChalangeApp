using static ChalangeApp.EmployeeBase;

namespace ChalangeApp
{
    public class Supervisor : IEmployee 
    {
        public List<float> grades = new();

        public Supervisor(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public event GradeAddedDelegate GradeAdded;

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("  invalid grade value !");
            }
        }

        public void AddGrade(double grade)
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
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade(15);
                    break;
                case "+1":
                case "1+":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception(" should use ratings from 1 - 6, adding + or - is also possible");
            }
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (float grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = '5';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = '4';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = '3';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = '2';
                    break;
                default:
                    statistics.AverageLetter = '1';
                    break;
            }

            return statistics;
        }
    }  
}
