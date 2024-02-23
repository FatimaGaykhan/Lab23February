//void GetCountOfNumber(int num)
//{
//    int count=0;
//    int newNum = 0;


//    while (newNum<=0)
//    {
//        newNum = num % 10;


//        if (newNum!=0)
//        {
//            num%
//        }
//    }

//}
//GetCountOfNumber(153);

using LabTasks23February;

Person person = new Person("Fatima", "Gaykhanova", 22);
Console.WriteLine(person.HappyBirthday());
person.GetInfo();
Author author = new Author("Fatima","GAykhanova",22,"Baku",5);
Console.WriteLine( author.age);

Book book1 = new Book("Leyli ve Mecnun", 300, "Nizami Gencevi");
Book book2 = new Book("Xosrov Shirin", 200, "Nizami Gencevi");
Book book3 = new Book("7gozel", 500, "Nizami Gencevi");
Book book4 = new Book("Sirler Xezinesi", 300, "Nizami Gencevi");

Book[] books = { book1, book2, book3, book4 };

author.books = books;

foreach (Book book in author.books)
{
    book.GetInfo();
}

