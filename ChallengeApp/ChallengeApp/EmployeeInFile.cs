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
        public override event GradeAddedDelegate GradeAdded;
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
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }

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

            if (File.Exists(filename))
            {
                using (var reader = File.OpenText(filename))
                {

                    var line = reader.ReadLine();
                    while (line != null)
                    {

                        float point = float.Parse(line);
                        stats.AddGrade(point);

                        line = reader.ReadLine();
                    }

                }
            }
            return stats;
        }


    }
}
