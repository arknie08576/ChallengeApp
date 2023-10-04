using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        string name { get; set; }
        string surname { get; set; }
        int age { get; set; }

        public List<int> points { get; private set; }

        public int Result { get { return points.Sum(); } }

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            points = new List<int>();
        }
        public void AddPoints(int score)
        {
            points.Add(score);
        }
        public void Print()
        {
            Console.WriteLine(name + " " + surname + ", wiek " + age);
            Console.WriteLine("Wynik " + Result);
        }
    }
}
