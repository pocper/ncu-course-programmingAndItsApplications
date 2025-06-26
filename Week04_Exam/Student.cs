using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string BirthYear { get; set; }
        public string Department { get; set; }
        public string Note { get; set; } = "";

        public static List<Student> DefaultStudents = new List<Student>()
        {
            new Student(){ ID="151303001", Name="張三", BirthYear="1999", Department="機械系", Email="[empty]"},
            new Student(){ ID="151303002", Name="李四", BirthYear="2001", Department="機械系", Email="lee4@mymail.com"},
            new Student(){ ID="151303003", Name="劉五", BirthYear="2002", Department="企管系", Email="liuFive@mymail.com"},
            new Student(){ ID="151303004", Name="廖六", BirthYear="2003", Department="機械系", Email="alex@zahoo.com"},
            new Student(){ ID="151303005", Name="林七", BirthYear="2004", Department="中文系", Email="seven11@ncu.tw"},
            new Student(){ ID="151303006", Name="陳八", BirthYear="2005", Department="中文系", Email="my88@zahoo.com"},
            new Student(){ ID="151303007", Name="王九", BirthYear="2006", Department="中文系", Email="nightFox@mymail.com"},
            new Student(){ ID="151303008", Name="蔡十", BirthYear="2001", Department="企管系", Email="tenten@ncu.tw"},
            new Student(){ ID="151303009", Name="曾土", BirthYear="2002", Department="企管系", Email="eve@cc.nnnu.tw"},
            new Student(){ ID="151303010", Name="刑一", BirthYear="2003", Department="企管系", Email="one@ncu.tw"},
            new Student(){ ID="151303011", Name="施二", BirthYear="2004", Department="機械系", Email="two2two@lownet.net"},
            new Student(){ ID="151303012", Name="大衛", BirthYear="2005", Department="中文系", Email="dawei@lownet.net"},
        };
    }


}
