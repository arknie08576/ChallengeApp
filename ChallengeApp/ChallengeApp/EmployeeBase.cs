using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }

        public EmployeeBase(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }

        public abstract void AddPoints(float score);

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

        public virtual void AddPoints(int score)
        {
            float scoreToFloat = score;
            AddPoints(scoreToFloat);
        }

        public virtual void AddPoints(long score)
        {
            float scoreToFloat = score;
            AddPoints(scoreToFloat);
        }

        public virtual void AddPoints(double score)
        {
            float scoreToFloat = (float)score;
            AddPoints(scoreToFloat);
        }

        public abstract Statistics GetStatistics();

    }
}
