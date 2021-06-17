using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programming_Language_2_Task_1
{
    public partial class Form2 : Form
    {

        public Student ivan;
        public Form2(Student studentToGrade) 
        {
            InitializeComponent();
            ivan = studentToGrade;
            Console.WriteLine(ivan.Name);
            fName.Text = studentToGrade.Name;
            lName.Text = studentToGrade.Surename;
            foreach(Lecture a in studentToGrade.LectureList)
            {
                lesson.Items.Add(a.LectureName);
            }
            
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(lesson.SelectedItem == null)
            {
                MessageBox.Show("No lessons selected");
                return;
            }
            string currentLecture = lesson.SelectedItem.ToString();
            foreach (Lecture lecture in ivan.LectureList)
            {
                if (lecture.LectureName == currentLecture)
                {
                    try
                    {
                    lecture.MidtermScore = Convert.ToDouble(midterm.Text);
                    lecture.FinalScore = Convert.ToDouble(final.Text);
                    average.Text = Convert.ToString(lecture.Average);
                        MessageBox.Show("Scores set!");
                    }
                    catch
                    {
                        MessageBox.Show("Invalid input formats!");
                    }
         
                }
            }

        }

        private void lesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentCourse = lesson.SelectedItem.ToString();
            foreach(Lecture a in ivan.LectureList)
            {
                if(a.LectureName == currentCourse)
                {
                    if(Convert.ToString(a.MidtermScore) == "0")
                    {
                        midterm.Text = "-1";
                    }
                    else
                    {
                        midterm.Text = Convert.ToString(a.MidtermScore);
                    }
                    if (Convert.ToString(a.FinalScore) == "0")
                    {
                        final.Text = "-1";
                    }
                    else
                    {
                        final.Text = Convert.ToString(a.FinalScore);
                    }
                    if(midterm.Text == "-1" || final.Text == "-1")
                    {
                        average.Text = "-1";
                        
                    }
                    else
                    {
                        
                        average.Text = Convert.ToString(a.Average);
                    }

                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
