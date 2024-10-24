using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Person
    {
        private String name;
        private int age;
        private String ic;
        private String email;

        public Person()
        {
        }

        public Person(string name, int age, string ic)
        {
            this.name = name;
            this.age = age;
            this.ic = ic;
        }

        public String Name
        {
            get { return name; }
            set
            {
                if (value.Length <= 20 && value.Length >= 1)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("[Name length must between 1 to 20]");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 100)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("[You can only register when you are above 18 Years Old & below 100 Years Old]");
                }
            }
        }

        public String Ic
        {
            get { return ic; }
            set
            {
                if (value.Length == 12)
                {
                    ic = value;
                }
                else
                {
                    Console.WriteLine("[IC must contains 12 digits]");
                }
            }
        }

        public String toString()
        {
            return "Name: " + name + "\n" +
                   "Age: " + age + "\n" +
                   "IC: " + ic + "\n";
        }
    }

}
