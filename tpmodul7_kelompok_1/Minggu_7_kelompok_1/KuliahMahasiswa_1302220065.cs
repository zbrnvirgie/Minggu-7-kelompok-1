using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPMOD07
{
    internal class KuliahMahasiswa_1302220065
    {
        public List<detail_course> courses;
        public List<detail_course> courses_my_course;
        //public detail_course[] courses = new detail_course[50];

        public void addCourse(string code, string nama)
        {
            detail_course course = new detail_course();
            course.code = code;
            course.name = nama;
            courses.Add(course);
        }

        public void addMyCourse()
        {
          
         
        }

        public void changeToMyCourse(KuliahMahasiswa_1302220065 c) {
            this.courses_my_course = c.GetCourses();
        }

        public void PrintCourses()
        {
            int i = 0;
            Console.WriteLine("");
            foreach (var x in this.courses)
            {
             
                Console.WriteLine(x.code + "-" + x.name);
            }
        }


        public List<detail_course> GetCourses()
        {
            return courses_my_course;
        }
    }

    internal class  detail_course
    {
        public string code;
        public string name;
        
    }
}
