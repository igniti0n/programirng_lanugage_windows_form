using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Language_2_Task_1
{
    public class Lecture
    {
        private string lectureName;
        private double midtermScore;
        private double finalScore;

        public string LectureName { get => lectureName; set => lectureName = value; }
        public double MidtermScore { get => midtermScore; set => midtermScore = value; }
        public double FinalScore { get => finalScore; set => finalScore = value; }


        public double Average
        {
            get
            {
                return ((midtermScore + finalScore) / 2);
            }
        }

       
    }
}
