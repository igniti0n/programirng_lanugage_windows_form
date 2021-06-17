using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Language_2_Task_1
{
    public enum Gender : byte
    {
        Male,
        Female
    }
    public enum Area : byte
    {
        Formal,
        Informal,
        Nonformal,
    }
    public class Student
    {
        private string name;
        private string surename;
        private int studentNumber;
        private DateTime dateOfBirth;
        private DateTime dateOfRegister;
        private int studentClass;
        private Gender gender;
        private Area area;
        private List<Lecture> lectureList;


        public Student(string name, string surname, int number)
        {
            this.name = name;
            this.surename = surname;
            this.studentNumber = number;
            this.lectureList = new List<Lecture>();
        }


        public override string ToString()
        {
            return name + " " + surename;
        }

        public void AddLecture(string lectureName)
        {
            Lecture newCourse = new Lecture();
            newCourse.LectureName = lectureName;
            lectureList.Add(newCourse);
        }


        public enum MaritalStatus : byte
        {
            Single,
            Married,
            Divorced,
        }


        public string Name { get => name; set => name = value; }
        public string Surename { get => surename; set => surename = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime DateOfRegister { get => dateOfRegister; set => dateOfRegister = value; }
        public int StudentClass { get => studentClass; set => studentClass = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public Area Area { get => area; set => area = value; }

        public List<Lecture> LectureList { get => lectureList; set => lectureList = value; }
        public int Age
        {
            get =>  DateTime.Today.Year - dateOfBirth.Year;

        }
       
    }
}
