namespace ChalangeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; }
        public string Surame { get; private set; }

        protected char Sex { get; set; } 
    }
}
