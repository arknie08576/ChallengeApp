using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public interface IEmployee
    {

        string Name { get;  }
        string Surname { get; }
        void AddPoints(float score);
        void AddPoints(string score);
        void AddPoints(int score);
        void AddPoints(long score);
        void AddPoints(double score);

        Statistics GetStatistics();
    }



}
