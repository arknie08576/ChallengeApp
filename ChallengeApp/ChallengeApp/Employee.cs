using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        int Age { get; set; }

        private List<float> points;



        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            points = new List<float>();
        }
        public void AddPoints(float score)
        {
            points.Add(score);
        }
        public void Print()
        {
            Console.WriteLine(Name + " " + Surname + ", wiek " + Age);
            Console.WriteLine("Przeciętna ocena: " + this.GetStatistics().Average );
        }

        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            stats.Min = float.MaxValue;
            stats.Max = float.MinValue;
            stats.Average = 0;

            foreach (var point in points)
            {
                stats.Min = Math.Min(stats.Min, point);
                stats.Max = Math.Max(stats.Max, point);
                stats.Average += point;
            }
            stats.Average /= points.Count;




            return stats;
        }
    }
}
