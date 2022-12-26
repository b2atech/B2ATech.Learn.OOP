using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2ATech.Learn.OOP.Constrctors
{
    public class Person
    {
        #region Private Properties
        protected int id;
        protected string name;
        protected int age;
        #endregion

        #region Public Properties
        public string Name
        {
            get { return name; }
        }
        #endregion

        #region Constructors
        public Person()
        {
            id = -1;
            name = "No Name";
            age = -1;
        }
        public Person(int id)
        {
            this.id = id;
            name = "No Name";
            age = -1;
        }
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
            age = -1;
        }
        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }


        #endregion

        # region Methods
        public void ShowDetails()
        {
            Console.WriteLine("Showing Person Information");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("| Person Id  \t| " + id + "\t\t|");
            Console.WriteLine("| Person Name  \t| " + name + "\t|");
            Console.WriteLine("| Person Age  \t| " + age + "\t\t|");
        }
        #endregion
    }
}
