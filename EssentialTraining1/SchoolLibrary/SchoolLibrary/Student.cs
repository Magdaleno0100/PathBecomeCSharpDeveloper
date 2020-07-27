using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels
        {
            Freshman,
            Sophomore,
            Junior,
            Senior
        }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            //It´s for test
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message si private and confidencial");
            return sb.ToString();

        }
    }
}
