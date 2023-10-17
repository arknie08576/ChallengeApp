using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Average { get; private set; }
        public int Count { get; private set; }
        public float Sum { get; private set; }
        public char AverageLetter { get; private set; }

        public Statistics()
        {
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Average = 0;
            this.Count = 0;
            this.Sum = 0;
            this.AverageLetter = 'E';

        }

        public void AddGrade(float grade)
        {
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
            this.Count++;
            this.Sum += grade;
            this.Average = this.Sum / this.Count;

            switch (this.Average)
            {

                case var average when average >= 80:
                    this.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    this.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    this.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    this.AverageLetter = 'D';
                    break;
                case var average when average >= 00:
                    this.AverageLetter = 'E';
                    break;

            }
        }
    }
}
