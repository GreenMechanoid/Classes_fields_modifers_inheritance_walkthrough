using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string FirstName;
        public string LastName;
    public Person() // full default värden på classen
    {
            this.FirstName = "Albert";
            this.LastName = "Andersson";
    }

    public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }



    public virtual void PrintName()
    { //skapar en metod som kan överskridas senare
            Console.WriteLine(FirstName + " " + LastName);
    }


    }
}
