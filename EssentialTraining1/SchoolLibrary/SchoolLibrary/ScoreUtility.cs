using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ScoreUtility
    {
        public static IScored BestOfTwo(IScored Assignment1, IScored Assigment2)
        {
            var score1 = Assignment1.Score / Assignment1.MaximumScore;
            var score2 = Assigment2.Score / Assigment2.MaximumScore;

            //if (score1 > score2)
            //{
            //    return Assignment1;
            //}
            //else
            //{
            //    return Assigment2;
            //}

            return score1 > score2 ? Assignment1 : Assigment2;

        }
    }
}
