using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test03
{
    class StudentInfo
    {
        public StudentInfo(string ID, string FamilyName, string GivenName, DateTime Birthday)
        {
            id = ID;
            familyName = FamilyName;
            givenName = GivenName;
            birthday = Birthday;

        }

        private string id;
        private string familyName;
        private string givenName;
        private DateTime birthday;

        public static string GetToday()
        {
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd");
            //Console.WriteLine(nowTime);
            return nowTime;
        }

        public double GetDaysFromBirth()
        {
            TimeSpan ts = DateTime.Now - birthday;
            string temp = ts.TotalDays.ToString();
            return Convert.ToDouble(temp);
        }

        public string ID
        {
            set { id = value; }
            get { return id; } 
        }

        public string FamilyName
        {
            set { familyName = value; }
            get { return familyName; }
        }
        public string GivenName
        {
            set { givenName = value; }
            get { return givenName; }
        }
        public DateTime Birthday
        {
            set { birthday = value; }
            get { return birthday; }
        }
    }
}
