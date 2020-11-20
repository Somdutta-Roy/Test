using System;

namespace ConsoleApp4
{
    public class Program
    {
         
        static void Main(string[] args)
        {

            Identity[] array = new Identity[2];
            array[0] = new Adult("Som", "Roy");
                  array[1]= new Child("Ria", "Dey");

            foreach (Identity item in array)
            {
                Console.WriteLine(item.GetName());
            }
            
        }
    }

    public interface Identity
    {
        public  string GetName();
    }
        public class Adult:Identity
        {
       
        public string Firstname { get; }
        public string Lastname { get; }
        public Adult(string Fname, string Lname)
              {
                Firstname = Fname;
                Lastname = Lname;
              }

        public string GetName()
        {
            string name = Firstname + Lastname;
            return name;
        }
    }
        public class Child : Identity
        {
            public string Firstname { get; }
            public string Lastname { get;  }
            public Child(string Firstname, string Lastname)
            {
               this.Firstname = Firstname;
               this.Lastname = Lastname;
            }

        public  string GetName()
        {
            string name = Firstname + Lastname;
            return name;
        }

    }
    }

