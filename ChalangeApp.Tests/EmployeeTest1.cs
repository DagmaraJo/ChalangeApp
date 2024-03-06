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
        public void WhenGatStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var employee5 = new Employee("Jan", "Dobosz", "39");
            employee5.AddGrade(4);
            employee5.AddGrade(5);
            employee5.AddGrade(7);

            var statistics = employee5.GetStatistics();

            Assert.AreEqual(Math.Round(5.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}


