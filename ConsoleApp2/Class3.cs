using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //exempel på hur Arv i Arv fungerar.
    //Teacher får från student (ID hantering) som får från Person (namn)
    class Teacher : Student
    {
        // Teacher ID is StudentID but remade to teacher
        public int TeacherID   // property
        {
            get { return TeacherID; }
            set { TeacherID = value; }
        }
        //Protected = Kan hittas från Ärvda klasser (Student)
        //Private = hittas och ändras ENDAST i denna klass
        public Teacher()
        {
            this.FirstName = "Johan";
            this.LastName = "Karlsson";
            this.TeacherID = 55;
               
            
        }
        

        public override void PrintName()
        // "överskrider" metoden så vi kan lägga till /
        // tabort saker som ska göras i den
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " Teacher ID: "
                + Convert.ToString(this.TeacherID));
        }
    }
}
