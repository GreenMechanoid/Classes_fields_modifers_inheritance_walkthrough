using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2 // <- länkar filer mellan varandra i C#
{
    class Student : Person
    {

        private int StudentID;
        //alla klasser som Ärver från denna kommer åt Protected och kan manipulera det
        
        public Student() // placeholder tills riktig info hämtas/görs
        {
            this.FirstName = "Kalle";
            this.LastName = "Kula";
            this.StudentID = 0;
        }

        public Student(string fname, string lname,int ID)
            //strikt konstruktor som KRÄVER att informationen finns innan objektet skapas
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.StudentID = ID;
        }


        public override void PrintName() 
        // "överskrider" metoden så vi kan lägga till /
        // tabort saker som ska göras i den
        {
            Console.WriteLine(FirstName+ " " + LastName + " Student ID: "
                + Convert.ToString(StudentID));
        }

    }



}
