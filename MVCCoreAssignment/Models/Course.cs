namespace MVCCoreAssignment.Models
{
    public class Course
    {
        public Course( string code, string name, string teacher, string dept) { 
            this.CourseCode = code;
            this.CourseName = name;
            this.CourseTeacher = teacher;
            this.CourseDepartment = dept;

        }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseTeacher {  get; set; }
        public string CourseDepartment { get; set; }
        
    }
}
