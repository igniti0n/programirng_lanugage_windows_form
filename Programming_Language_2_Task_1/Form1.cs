using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programming_Language_2_Task_1
{
    public partial class Form1 : Form
    {
        List<Student> newList = new List<Student>();


        public Form1()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";


            area.DataSource = Enum.GetValues(typeof(Area));


        }

        bool isStudentInformationString(String text)

        {
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("All values must be selected!");
                return false;
            }

            foreach (char letter in text)
            {
                if (!char.IsLetter(letter))
                {
                    MessageBox.Show("Some text information are not in valid format!");
                    return false;
                }
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number;

            try
            {

                number = int.Parse(itsNumber.Text);
            }
            catch
            {
                MessageBox.Show("Student number is not valid!");
                return;
            }

            if (isStudentInformationString(firstName.Text) &&
                isStudentInformationString(lastName.Text))
            {

                Student newStudent = new Student(firstName.Text, lastName.Text, number);

                newStudent.DateOfBirth = dateTimePicker1.Value;
                newStudent.DateOfRegister = dateTimePicker2.Value;
                newStudent.StudentClass = Convert.ToInt32(classNumber.Value);

                newStudent.Gender = male.Checked ? Gender.Male : Gender.Female;

                switch (area.SelectedItem.ToString())
                {
                    case "Formal":
                        newStudent.Area = Area.Formal;
                        break;
                    case "Informal":
                        newStudent.Area = Area.Informal;
                        break;
                    default:
                        newStudent.Area = Area.Nonformal;
                        break;
                }

                newList.Add(newStudent);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstName.Text = "";
            lastName.Text = "";
            itsNumber.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            classNumber.Value = 0;
            male.Checked = false;
            female.Checked = false;
            area.SelectedIndex = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (Student student in newList)
            {
                if (!studentList.Items.Contains(student.ToString()))
                {
                    studentList.Items.Add(student.ToString());
                }

            }

        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentList.SelectedItem == null)
            {
                return;
            }
            string currentItem = studentList.SelectedItem.ToString();
            foreach (Student a in newList)
            {
                if (a.ToString() == currentItem)
                {
                    setInputDataForSelectedStudent(a);

                }
            }


        }

        private void setInputDataForSelectedStudent(Student a)
        {
            firstName.Text = a.Name;
            lastName.Text = a.Surename;
            itsNumber.Text = Convert.ToString(a.StudentNumber);
            dateTimePicker1.Value = a.DateOfBirth;
            dateTimePicker2.Value = a.DateOfRegister;
            classNumber.Value = a.StudentClass;
            male.Checked = a.Gender == Gender.Male;
            female.Checked = a.Gender == Gender.Female;

            switch (a.Area)
            {
                case Area.Formal:
                    area.SelectedIndex = 0;
                    break;
                case Area.Informal:
                    area.SelectedIndex = 1;
                    break;
                default:
                    area.SelectedIndex = 2;
                    break;
            }

            int age = 0;
            age = DateTime.Now.Year - a.DateOfBirth.Year;
            studentAge.Text = Convert.ToString(age);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lessons = File.ReadAllLines("Lessons.txt");

            foreach (var line in lessons)
            {
                string[] lesson = line.Split(',');

                lessonsDropDown.Items.Add(lesson[0]);
                searchLessons.Items.Add(lesson[0]);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentList.SelectedItem == null)
            {
                MessageBox.Show("No student selected!");
                return;
            }
            if (lessonsDropDown.SelectedItem == null)
            {
                MessageBox.Show("No lessons selected!");
                return;
            }
            string currentStudent = studentList.SelectedItem.ToString();
            string selectedLesson = lessonsDropDown.SelectedItem.ToString();
            foreach (Student student in newList)
            {
                addLectureToStudent(currentStudent, selectedLesson, student);
            }

        }

        private static void addLectureToStudent(string currentStudent, string selectedLesson, Student a)
        {
            if (a.ToString() == currentStudent)
            {
                bool containsCourse = a.LectureList.Any(item => item.LectureName == selectedLesson);
                if (!containsCourse)
                {
                    a.AddLecture(selectedLesson);

                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (studentList.SelectedItem == null)
            {
                MessageBox.Show("Select student");
            }
            else
            {
                string currentStudent = studentList.SelectedItem.ToString();

                foreach (Student a in newList)
                {
                    if (a.ToString() == currentStudent)
                    {
                        Form2 form2 = new Form2(a);



                        form2.Show();
                    }
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            foreach (Student student in newList)
            {
                if (nameSearch.Text.Contains(student.ToString()))
                {
                    studentList.Items.Add(student.ToString());
                }
            }
            MessageBox.Show("The transaction has completed sucesfully");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            string selectedLesson = searchLessons.SelectedItem.ToString();

            foreach (Student student in newList)
            {

                foreach (Lecture x in student.LectureList)
                {
                    if (x.LectureName == selectedLesson)
                    {
                        studentList.Items.Add(student.ToString());
                    }
                }
            }
            MessageBox.Show("The transaction has completed sucesfully");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            int selectedClass = Convert.ToInt32(studentClass.Value);
            foreach (Student student in newList)
            {
                if (student.StudentClass == selectedClass)
                {
                    studentList.Items.Add(student.ToString());
                }
            }
            MessageBox.Show("The transaction has completed sucesfully");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            studentList.Items.Clear();
            Gender gender = maleSearch.Checked ? Gender.Male : Gender.Female;

            foreach (Student student in newList)
            {
                if (student.Gender == gender)
                {
                    studentList.Items.Add(student.ToString());
                }
            }
            MessageBox.Show("The transaction has completed sucesfully");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
