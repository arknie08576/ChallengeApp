using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
        private List<float> points;
        public Supervisor(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
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
                throw new Exception("Nieprawidłowa ocena");
            }
        }

        public void AddPoints(string score)
        {

            switch (score)
            {

                case "6":
                    AddPoints(100f);
                    break;

                case "6-" or "-6":
                    AddPoints(95f);
                    break;

                case "5+" or "+5":
                    AddPoints(85f);
                    break;

                case "5":
                    AddPoints(80f);
                    break;

                case "5-" or "-5":
                    AddPoints(75f);
                    break;
                case "4+" or "+4":
                    AddPoints(65f);
                    break;

                case "4":
                    AddPoints(60f);
                    break;

                case "4-" or "-4":
                    AddPoints(55f);
                    break;

                case "3+" or "+3":
                    AddPoints(45f);
                    break;

                case "3":
                    AddPoints(40f);
                    break;
                case "3-" or "-3":
                    AddPoints(35f);
                    break;

                case "2+" or "+2":
                    AddPoints(25f);
                    break;

                case "2":
                    AddPoints(20f);
                    break;

                case "2-" or "-2":
                    AddPoints(15f);
                    break;

                case "1+" or "+1":
                    AddPoints(5f);
                    break;
                case "1":
                    AddPoints(0f);
                    break;
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
                    throw new Exception("Nieprawidłowa ocena");
            }

        }

        public void AddPoints(int score)
        {
            throw new NotImplementedException();
        }

        public void AddPoints(long score)
        {
            throw new NotImplementedException();
        }

        public void AddPoints(double score)
        {
            throw new NotImplementedException();
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
