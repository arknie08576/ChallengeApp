using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        private const string filename = "grades.txt";


        public EmployeeInFile(string name, string surname, int age, char sex)
            : base(name, surname, sex, age)
        {

        }
        public override void AddPoints(float score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(filename))
                {

                    writer.WriteLine(score);


                }
            }
            else
            {
                throw new Exception("Nieprawidłowa ocena");
            }
        }









        public override Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            stats.Min = float.MaxValue;
            stats.Max = float.MinValue;
            stats.Average = 0;
            if (File.Exists(filename))
            {
                using (var reader = File.OpenText(filename))
                {
                    int i = 0;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        i++;
                        float point = float.Parse(line);
                        stats.Min = Math.Min(stats.Min, point);
                        stats.Max = Math.Max(stats.Max, point);
                        stats.Average += point;


                        line = reader.ReadLine();
                    }
                    if (i > 0)
                    {

                        stats.Average /= i;
                    }
                    else
                    {
                        stats.Min = 0;
                        stats.Max = 0;
                        stats.Average = 0;
                        stats.AverageLetter = 'E';
                    }
                }
            }


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
            return stats;
        }


    }
}
