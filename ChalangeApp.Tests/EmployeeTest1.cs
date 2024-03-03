namespace ChalangeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectFiveGrades_ShouldReturnCorrectSum()
        {
            var emp3 = new Employee("Piotr", "Banach", "34");
            emp3.AddGrade(0);
            emp3.AddGrade(0);
            emp3.AddGrade(1);
            emp3.AddGrade(2);
            emp3.AddGrade(2);

            var result = emp3.Grades.Sum();

            Assert.AreEqual(5, result);
        }
        [Test]
        public void WhenEmployeeCollectNegativePoints_ShouldReturnCorrectSum()
        {
            var emp3 = new Employee("Piotr", "Banach", "34");
            emp3.AddGrade(0);
            emp3.AddGrade(0);
            emp3.AddGrade(1);
            emp3.AddGrade(2);
            emp3.AddGrade(2);

            var result = emp3.Grades.Sum();

            Assert.AreEqual(5, result);
        }
        [Test]
        public void WhenEmployeeCollectZeroPoints_ShouldReturnCorrectSum()
        {
            var emp3 = new Employee("Piotr", "Banach", "34");
            emp3.AddGrade(0);
            emp3.AddGrade(0);
            emp3.AddGrade(1);
            emp3.AddGrade(2);
            emp3.AddGrade(2);

            var result = emp3.Grades.Sum();

            Assert.AreEqual(5, result);

        }
    }

}