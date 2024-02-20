using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SchoolManagement
    {
        static List<School> list = new List<School>()
        {
            new School() {StuId = 1, StuName = "Kaviya",TeacherName = "Harish", SubName="Science"},
            new School() {StuId = 2, StuName = "Gowtham",TeacherName = "Raveena", SubName="Maths"},
            new School() {StuId = 3, StuName = "Rudhwin",TeacherName = "Suganya", SubName="English"},
            new School() {StuId = 4, StuName = "Sneha",TeacherName = "Sruthi", SubName="Social"},
            new School() {StuId = 5, StuName = "Aboorva",TeacherName = "Deepika", SubName="Hindi"},

        };
        public List<School> AllStulist()
        {
            return list;
        }
        public List<School> SearchStu(int id)
        {
            List<School> searchlist = list.FindAll(s => s.StuId == id);
            return searchlist;
        }
        public virtual bool StudentMarks()
        {
            return false;
        }
    }
}
