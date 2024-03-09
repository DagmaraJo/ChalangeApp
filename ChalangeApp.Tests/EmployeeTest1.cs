namespace ChalangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            var employee5 = new Employee("Jan", "Dobosz", "39");
            employee5.AddGrade(4);
            employee5.AddGrade(5);
            employee5.AddGrade(7);

            var statistics = employee5.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            var employee5 = new Employee("Jan", "Dobosz", "39");
            employee5.AddGrade(4);
            employee5.AddGrade(5);
            employee5.AddGrade(7);

            var statistics = employee5.GetStatistics();

            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var employee5 = new Employee("Jan", "Dobosz", "39");
            employee5.AddGrade(4);
            employee5.AddGrade(5);
            employee5.AddGrade(7);

            var statistics = employee5.GetStatistics();

            Assert.AreEqual(Math.Round(5.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenEmployeeColectCharGrades_ShouldReturnCorrectAverage()
        {
            var employee = new Employee();
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');
            employee.AddGrade('d');
            employee.AddGrade('e');


            var statistics = employee.GetStatistics();

            Assert.AreEqual(60, statistics.Average);
        }

        [Test]
        public void WhenEmployeeColectCharGrades_ShouldReturnCorrectMax()
        {
            var employee = new Employee();
            employee.AddGrade('G');
            employee.AddGrade('D');
            employee.AddGrade('C');
            employee.AddGrade('B');
            employee.AddGrade('E');


            var statistics = employee.GetStatistics();

            Assert.AreEqual(80, statistics.Max);
        }


        [Test]
        public void WhenEmployeeColectStringGrades_ShouldReturnCorrectMin()
        {
            var employee = new Employee();
            employee.AddGrade("five");
            employee.AddGrade("76");
            employee.AddGrade("e");
            employee.AddGrade("B");
            employee.AddGrade("25");


            var statistics = employee.GetStatistics();

            Assert.AreEqual(20, statistics.Min);
        }



        [Test]
        public void WhenEmployeeColectMixedGrades_ShouldReturnCorrectMin()
        {
            var employee = new Employee();
            employee.AddGrade('d');
            employee.AddGrade('C');
            employee.AddGrade(50);
            employee.AddGrade(75);
            employee.AddGrade("E");


            var statistics = employee.GetStatistics();

            Assert.AreEqual(20, statistics.Min);
        }
    }
}