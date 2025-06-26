using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var ss = Student.DefaultStudents;

            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            foreach (var student in ss)
            {
                DataGridViewRow row = dGV.Rows[0].Clone() as DataGridViewRow;
                row.Cells[0].Value = student.ID;
                row.Cells[1].Value = student.Name;
                row.Cells[2].Value = student.Email;
                row.Cells[3].Value = student.BirthYear;
                row.Cells[4].Value = student.Department;
                row.Cells[5].Value = student.Note;
                dGV.Rows.Add(row);
            }

            comboBox_Condition.SelectedIndex = 3;
            timer1.Start();
        }

        private void comboBox_Condition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox_Field_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBox_Condition.SelectedItem.ToString();

            for (int i = 0; i < dGV.Rows.Count - 1; i++)
            {
                if (selectedItem == "全部")
                {
                    dGV.Rows[i].Visible = true;
                }
                else if (selectedItem == "機械系")
                {
                    if (dGV.Rows[i].Cells["Depart"].Value.ToString() == "機械系")
                    {
                        dGV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dGV.Rows[i].Visible = false;
                    }
                }
                else if (selectedItem == "中文系")
                {
                    if (dGV.Rows[i].Cells["Depart"].Value.ToString() == "中文系")
                    {
                        dGV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dGV.Rows[i].Visible = false;
                    }
                }
                else if (selectedItem == "企管系")
                {
                    if (dGV.Rows[i].Cells["Depart"].Value.ToString() == "企管系")
                    {
                        dGV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dGV.Rows[i].Visible = false;
                    }
                }
            }





            dGV.Columns["StudentID"].Visible = false;
            dGV.Columns["StudentName"].Visible = false;
            dGV.Columns["Email"].Visible = false;
            dGV.Columns["BirthYear"].Visible = false;
            dGV.Columns["Depart"].Visible = false;
            dGV.Columns["Note"].Visible = false;

            int[] checkbox_list = new int[6];
            int counter = 0;

            foreach (var item in checkedListBox_Field.CheckedItems)
            {
                if (item.ToString() == "ID")
                {
                    checkbox_list[counter] = 0;
                    counter++;
                }
                if (item.ToString() == "Name")
                {
                    checkbox_list[counter] = 1;
                    counter++;
                }
                if (item.ToString() == "E-mail")
                {
                    checkbox_list[counter] = 2;
                    counter++;
                }
                if (item.ToString() == "Birth Year")
                {
                    checkbox_list[counter] = 3;
                    counter++;
                }
                if (item.ToString() == "Department")
                {
                    checkbox_list[counter] = 4;
                    counter++;
                }
                if (item.ToString() == "Note")
                {
                    checkbox_list[counter] = 5;
                    counter++;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                if (checkbox_list[i] == 0)
                {
                    dGV.Columns["StudentID"].Visible = true;
                }
                if (checkbox_list[i] == 1)
                {
                    dGV.Columns["StudentName"].Visible = true;
                }
                if (checkbox_list[i] == 2)
                {
                    dGV.Columns["Email"].Visible = true;
                }
                if (checkbox_list[i] == 3)
                {
                    dGV.Columns["BirthYear"].Visible = true;
                }
                if (checkbox_list[i] == 4)
                {
                    dGV.Columns["Depart"].Visible = true;
                }
                if (checkbox_list[i] == 5)
                {
                    dGV.Columns["Note"].Visible = true;
                }
            }
        }
    }
}
