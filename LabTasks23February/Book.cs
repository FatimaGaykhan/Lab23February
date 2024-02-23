using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTasks23February
{
    internal class Book
    {
        public string name;
        public int pageCount;
        public string authorName;

        public Book(string name,int pageCount,string authorName)
        {
            this.name=name;
            this.pageCount=pageCount;
            this.authorName=authorName;
        }
       public void GetInfo()
        {
            Console.WriteLine(name+" "+pageCount+" "+authorName);
        }
    }
}
