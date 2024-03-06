namespace ChalangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldRetuenDifferentObjects()
        {
            var emp1 = GetEmployee("Jan", "Kowalski", "39");
            var emp5 = GetEmployee("Jan", "Dobosz", "39");


            Assert.AreNotEqual(emp1, emp5);
        }
        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee(name, surname, age);
        }

        [Test]
        public void GetStringNamesShouldRetuenEqual()
        {
            // arange
            string name1 = "Jan";
            string name2 = "Jan";
            // act

            // assert
            Assert.AreEqual(name1, name2);
        }
        
        [Test]
        public void GetEmployeeShouldRetuenTheSameAges()
        {
            var employee1 = GetEmployee("Jan", "Kowalski", "39");
            var employee5 = GetEmployee("Jan", "Dobosz", "39");


            Assert.AreEqual(employee1.Age, employee5.Age);
        }

        [Test]
        public void WhenCompareTheSameValue_ThenReturnEqual()
        {
            int number1 = 378;
            int number2 = 378;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareAverageGrades()
        {
            float grades1 = 3.78f;
            float grades2 = 3.57f;

            Assert.AreNotEqual(grades1, grades2);
        }
    }
}
