using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Models
{
    internal class Student
    {
        public string Name;
       public string SurName;
        public int age;
        public string address;

        public Student() {
        
        
        }
        public Student(string name, string surName, int age)
        {
            this.Name = name;
            this.SurName = surName;
            this.age = age;
        }
        public Student(string name, string surName, int age, string address):this() 
        {
            this.Name = name;
            this.SurName = surName;
            this.age = age;
            this.address = address;
        }
    }
}
