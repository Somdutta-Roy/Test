using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Obj = new Object[2];
            Obj[0] = new Adult("Som", "Roy");
            Obj[1] = new Child("Ria", " Dey");
            Console.WriteLine(Obj[0].Fir)

            foreach(Object item in Obj)
            {
                Console.WriteLine("Name:" + );
            }

            Console.WriteLine("Hello World!");
        }

        public class Adult
        { 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
         public  Adult(string Firstname,string Lastname)
        {
            Firstname = Firstname;
            Lastname = Lastname;

            }
    }
    public class Child
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
      public  Child(string Firstname, string Lastname)
        {
            Firstname = Firstname;
            Lastname = Lastname;
        }
    }
}
