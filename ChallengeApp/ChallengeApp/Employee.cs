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
                Console.WriteLine("Nieprawidłowa ocena");
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
                switch (score)
                {
                    case "a":
                    case "A":
                        AddPoints(100f);
                        break;
                    case "b":
                    case "B":
                        AddPoints(80f);
                        break;
                    case "c":
                    case "C":
                        AddPoints(60f);
                        break;
                    case "d":
                    case "D":
                        AddPoints(40f);
                        break;
                    case "e":
                    case "E":
                        AddPoints(20f);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa ocena");
                        break;





                }
            }
        }


        public void Print()
        {
            Console.WriteLine(Name + " " + Surname + ", wiek " + Age);
            Console.WriteLine("Min ocena: " + this.GetStatistics().Min);
            Console.WriteLine("Max ocena: " + this.GetStatistics().Max);
            Console.WriteLine("Przeciętna ocena: " + this.GetStatistics().Average + " czyli literowo " + this.GetStatistics().AverageLetter);
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

            switch (stats.Average)
            {

                case var average when average >= 80:
                    stats.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    stats.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    stats.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    stats.AverageLetter = 'D';
                    break;
                case var average when average >= 00:
                    stats.AverageLetter = 'E';
                    break;

            }

            if (points.Count == 0)
            {
                stats.Min = 0;
                stats.Max = 0;
                stats.Average = 0;
                stats.AverageLetter = 'E';
            }

            return stats;
        }


    }
}
