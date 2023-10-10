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
            if (score >= 0 && score <= 100)
            {
                points.Add(score);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }

        public void AddPoints(int score)
        {

            float scoreToFloat = score;
            AddPoints(scoreToFloat);

        }
        public void AddPoints(long score)
        {

            float scoreToFloat = score;
            AddPoints(scoreToFloat);

        }
        public void AddPoints(double score)
        {

            float scoreToFloat = (float)score;
            AddPoints(scoreToFloat);

        }
        public void AddPoints(string score)
        {

            float scoreToFloat = 0.0F;
            if (float.TryParse(score, out scoreToFloat))
            {


                AddPoints(scoreToFloat);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }


        public void Print()
        {
            Console.WriteLine(Name + " " + Surname + ", wiek " + Age);
            Console.WriteLine("Przeciętna ocena: " + this.GetStatistics().Average);
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
        public Statistics GetStatisticsWithForeach()
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
        public Statistics GetStatisticsWithFor()
        {
            Statistics stats = new Statistics();
            stats.Min = float.MaxValue;
            stats.Max = float.MinValue;
            stats.Average = 0;

            for(int i =0;i<points.Count;i++)
            {
                stats.Min = Math.Min(stats.Min, points[i]);
                stats.Max = Math.Max(stats.Max, points[i]);
                stats.Average += points[i];
            }
            stats.Average /= points.Count;
            return stats;
        }

        public Statistics GetStatisticsWithWhile()
        {
            Statistics stats = new Statistics();
            stats.Min = float.MaxValue;
            stats.Max = float.MinValue;
            stats.Average = 0;

            int i = 0;

            while( i < points.Count)
            {
                stats.Min = Math.Min(stats.Min, points[i]);
                stats.Max = Math.Max(stats.Max, points[i]);
                stats.Average += points[i];
                i++;
            }
            stats.Average /= points.Count;
            return stats;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            Statistics stats = new Statistics();
            stats.Min = float.MaxValue;
            stats.Max = float.MinValue;
            stats.Average = 0;

            int i = 0;

            do
            {
                stats.Min = Math.Min(stats.Min, points[i]);
                stats.Max = Math.Max(stats.Max, points[i]);
                stats.Average += points[i];
                i++;
            } while (i < points.Count);
            stats.Average /= points.Count;
            return stats;
        }

    }
}
