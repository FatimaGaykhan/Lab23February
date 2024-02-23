

using System.Threading.Channels;

namespace LabTasks23February
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;

        public Person(string name,string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public int HappyBirthday()
        {
            this.age += 1;
            return age;
        }
        
        public void GetInfo()
        {
            Console.WriteLine(this.name+" "+this.surname+" "+this.age);
        }



    }
}
