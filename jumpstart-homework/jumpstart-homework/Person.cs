using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpstart_homework
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age) : this(name, age, null) { }
        public string Name
        {
            get
            { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("wrong name");
                else
                    this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentException("wrong   age");
                else
                    this.age = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == null || value.Contains("@"))
                    this.email = value;
                else
                    throw new ArgumentException("wrong email");
            }
        }


        public override string ToString()
        {
            string result =string.Format("Person name: {0},Person  age: {1}", this.Name, this.Age);
            if (this.Email!=null)
                return result+string.Format("Person email:{0}",this.Email);
            else
            return result;
           
        }


    }
}

