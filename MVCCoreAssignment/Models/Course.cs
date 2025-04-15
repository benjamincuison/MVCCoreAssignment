using System.Runtime.Serialization;
using System.Xml.Linq;

namespace MVCCoreAssignment.Models
{
    [Serializable]
    public class Course
    {
        public Course()
        {
            this.CourseCode = "";
            this.CourseName = "";
            this.CourseTeacher = "";
            this.CourseDepartment = "";
        }
        public Course( string code, string name, string teacher, string dept) { 
            this.CourseCode = code;
            this.CourseName = name;
            this.CourseTeacher = teacher;
            this.CourseDepartment = dept;

        }

        [DataMember]
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseTeacher {  get; set; }
        public string CourseDepartment { get; set; }
        
    }
}
