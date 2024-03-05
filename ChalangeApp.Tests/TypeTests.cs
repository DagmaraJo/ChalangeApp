namespace ChalangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetUserShouldRetuenDifferentObjects()
        {
            var user1 = GetUser("Jan");
            var user5 = GetUser("Jan");


            Assert.AreNotEqual(user1, user5);
        }
        private User GetUser(string name)
        {
            return new User(name);
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

        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee( name, surname, age);
        }

        [Test]
        public void WhenCompareTheSameValue_ThenReturnEqual()
        {
            int number1 = 378;
            int number2 = 378;

            Assert.AreEqual(number1, number2);
        }

    }
}
