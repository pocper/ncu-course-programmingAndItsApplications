using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo si = new StudentInfo("111111111", "AAA", "BBBBBB", new DateTime(1979, 10, 17));
            Console.WriteLine(string.Format("{2} {1} was born on {3}, and his/her id is {0}", si.ID, si.FamilyName, si.GivenName, si.Birthday));
            Console.WriteLine(StudentInfo.GetToday());
            double days = si.GetDaysFromBirth();
            Console.WriteLine(days.ToString() + " days from birthday.");
            si.ID = "999999999";
            si.FamilyName = "CCC";
            si.GivenName = "DDDDD";
            si.Birthday = new DateTime(2021, 6, 21);
            Console.WriteLine(string.Format("{2} {1} was born on {3}, and his/her id is {0}", si.ID, si.FamilyName, si.GivenName, si.Birthday));
        }
    }
}
