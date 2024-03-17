using static ChalangeApp.EmployeeBase;

namespace ChalangeApp
{
    public interface IEmployee 
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        public abstract event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}

