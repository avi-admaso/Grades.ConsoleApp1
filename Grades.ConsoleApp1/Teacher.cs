using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.ConsoleApp1
{
    public class Teacher
    {
        public string teacherName;
        public string studentName;
        public int id;
        public int [] grades;
        public Teacher(string teacherName, string studentName, int id, int [] grades)
        {
            this.teacherName = teacherName;
            this.studentName = studentName;
            this.id = id;
            this.grades = grades;
        }
    }
}
