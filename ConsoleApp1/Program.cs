
using System.Runtime.InteropServices;

namespace Out
{

    class Person
    {
        string name;
        int age;
        string gender;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set => age = value;
            get => age;
        }

        public string Gender
        {
            set => gender = value;
            get => gender;
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Michael", 40, "Male");
            Console.WriteLine($"The name of p is {p.Name}");
        }

    }
}
