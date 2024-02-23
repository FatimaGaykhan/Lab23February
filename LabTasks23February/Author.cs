

namespace LabTasks23February
{
    internal class Author : Person
    {

        public string adress;
        public int experience;
        public Book[] books; 

       
        public Author(string name,string surname, int age, string address , int experience):base(name, surname, age)
        {
          
            this.adress = address;
            this.experience = experience;
        }


    }
}
