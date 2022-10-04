namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputValue;
            string InputValue2;
            int InputID;
            //skapar klassen med värden vi vill ha
            Person per = new Person("Anders"," Gunnarsson");
            Person per2 = new Person();
            // basisk skapande "För att ha klassen i aktivt minne"


            Console.WriteLine("Bas klassens 'Default'");
            per.PrintName();
            Console.WriteLine("Bas klassens värden vi gett");
            per2.PrintName();

            //basiks skapande av Ärvd klass
            Console.WriteLine("ärvda klassens bas värden");
            Student stud = new Student();
            Console.WriteLine("ärvda klassens bas värden");

            Console.WriteLine("FirstName");
            InputValue = Console.ReadLine();
            Console.WriteLine("LastName");
            InputValue2 = Console.ReadLine();
            Console.WriteLine("Enter ID");
            InputID = int.Parse(Console.ReadLine());

            Student stud2 = new Student(InputValue,InputValue2,InputID);

            stud2.PrintName();
            //override på printname för att skriva ut mer info


            Teacher teach = new Teacher();
            teach.PrintName();
            teach.TeacherID = 500;
            Console.WriteLine();
        }
    }
}


