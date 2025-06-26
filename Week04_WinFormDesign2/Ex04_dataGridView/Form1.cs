using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex04_dataGridView
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>()
        {
            new Student(){Name ="John", Height = 180, Weight = 60, Age = 18},
            new Student(){Name = "May", Height = 170, Weight = 55, Age = 28},
            new Student(){Name = "Amanda", Height = 172, Weight = 55, Age = 91},
            new Student(){Name = "Carol", Height = 151, Weight = 45, Age = 8},
            new Student(){Name = "Dora", Height = 145, Weight = 41, Age = 12},
            new Student(){Name = "Gina", Height = 162, Weight = 39, Age = 32},
            new Student(){Name = "Adam", Height = 198, Weight = 87, Age = 65},
            new Student(){Name = "Bob", Height = 195, Weight = 76, Age = 47},
            new Student(){Name = "Clay", Height = 170, Weight = 59, Age = 23},
            new Student(){Name = "Vincent", Height = 165, Weight = 61, Age = 34}
        };

        public Form1()
        {
            InitializeComponent();

            foreach (var Item in students)
            {
                dGV.Rows.Add(Item.Name, Item.Height, Item.Weight, Item.Age);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            students.Clear();
            for (int i = 0; i < dGV.Rows.Count - 1; i++)
            {
                Student newStudent = new Student();
                newStudent.Name = dGV.Rows[i].Cells["ColumnName"].Value as string;
                newStudent.Height = int.Parse(dGV.Rows[i].Cells[1].Value.ToString());
                newStudent.Weight = int.Parse(dGV.Rows[i].Cells["ColumnWeight"].Value.ToString());
                students.Add(newStudent);
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            dGV.Rows.Clear();
            foreach (var Item in students)
            {
                dGV.Rows.Add(Item.Name, Item.Height, Item.Weight, Item.Age);
            }
        }
    }
}
