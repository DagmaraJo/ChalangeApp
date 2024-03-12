﻿namespace ChalangeApp
{
    public class Employee : IEmployee
    {
        public List<float> grades = new();

        public Employee (string name, string surname)
        {
            this.Name = surname;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >=0 && grade <= 100)
            {
                this.grades.Add(grade);
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

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("  only A B C D E are akcept - try again");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultLetter))
            {
                this.AddGrade(resultLetter);
            }
            else
            {
                throw new Exception("   wrong letters - try again");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach( var grade in this.grades)
            {
                if (grade >=0)
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