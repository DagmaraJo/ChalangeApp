namespace ChalangeApp
{
    public abstract class Person
    {
        public Person(string name, char sex)
        {
            this.Name = name;
            this.Sex = sex;
        }

        public string Name { get; private set; }

        protected char Sex { get; private set; }
    }
}
