using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    public class Encapsulation
    {
        private string name;
        private int age;


        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(int age) 
        {
            this.age = age;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"name={name}, age={age}");
        }
    }
}
