using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {


        private List<float> points;
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname, int age, char sex)
            : base(name, surname, sex, age)
        {

            points = new List<float>();
        }
        public override void AddPoints(float score)
        {
            if (score >= 0 && score <= 100)
            {
                points.Add(score);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Nieprawidłowa ocena");
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
                        throw new Exception("Nieprawidłowa ocena");

                }
            }
        }

        public override Statistics GetStatistics()
        {
            Statistics stats = new Statistics();

            foreach (var point in points)
            {
                stats.AddGrade(point);

            }

            return stats;
        }


    }
}
