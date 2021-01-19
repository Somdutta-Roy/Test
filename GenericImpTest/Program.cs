using System;
using System.Collections.Generic;

namespace GenericImpTest
{
    public class EmpList<T>
    {
        private List<T> checkPoint;

        public EmpList()
        {
            this.checkPoint = new List<T>();
        }

        public void AddEmp(T newEmp)
        {
            checkPoint.Add(newEmp);
        }


        public void ProcessList()
        {

            checkPoint.Sort(delegate (T x, T y)
            {
            if (x.ToString() == null && y.ToString() == null)
            {
                return 0;
            }

            else  return x.ToString().CompareTo(y.ToString());
             });
            

        }
    }



    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;

        }
        public override string ToString()
        {
            return FirstName + LastName;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Som", "Roy");
            Employee e2 = new Employee("Lory", "Lerman");
            Employee e3 = new Employee("James", "Marcus");
            Employee e4 = new Employee("Tony", "stark");

            EmpList<Employee> employeeNodes = new EmpList<Employee>();
            employeeNodes.AddEmp(e1);
            employeeNodes.AddEmp(e2);
            employeeNodes.AddEmp(e3);
            employeeNodes.AddEmp(e4);


            employeeNodes.ProcessList();

        }
    }
}

