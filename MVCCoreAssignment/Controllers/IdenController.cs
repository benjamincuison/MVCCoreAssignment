using Microsoft.AspNetCore.Mvc;

namespace MVCCoreAssignment.Controllers
{
    public class IdenController : Controller
    {
        public JsonResult GetResponse()
        {
            List<Models.Identity> studentList = new List<Models.Identity>();

            // Student 1
            Models.Identity student = new Models.Identity();
            student.Id = 203;

            student.PersonalInfo.FirstName = "Benjamin";
            student.PersonalInfo.LastName = "Cuison";
            student.PersonalInfo.Address = "4320 Wawa Lane";
            student.PersonalInfo.ContactPhoneNumber = "03948290348";
            student.PersonalInfo.ContactEmail = "bc@email.com";

            student.Group = "Computer Information Systems Dept.";
            student.Role = "Full Time Student";

            student.AccountBalance = 50.93;
            student.Active = true;
            student.Term = "Winter 2025";

            student.Classes.Add(new Models.Course(
                "CIS123",
                "Intro to Computer Science",
                "Professor David",
                "Computer Information Systems"
            ));
            student.Classes.Add(new Models.Course(
                "EN103",
                "Composing Article Class",
                "Professor Linda",
                "English"
            ));

            student.EmergencyContact.Add("123-456-7890");
            student.EmergencyContact.Add("bensmom@gmail.org");
            student.EmergencyContact.Add("222-555-3232");
            student.EmergencyContact.Add("bensdad@gmail.org");
            studentList.Add(student);

            //Student 2

            Models.Identity student2 = new Models.Identity();
            student2.Id = 5;

            student.PersonalInfo.FirstName = "Robert";
            student.PersonalInfo.LastName = "Francois";
            student.PersonalInfo.Address = "3924 Goose Bolevard";
            student.PersonalInfo.ContactPhoneNumber = "332324234";
            student.PersonalInfo.ContactEmail = "RF@email.com";

            student2.Group = "Engineering Dept.";
            student2.Role = "Graduated Student";

            student2.AccountBalance = 1233.93;
            student2.Active = false;
            student2.Term = "Winter 2025";

            student2.Classes.Add(new Models.Course(
                "EGNR 454",
                "Advanced Themodynamics",
                "Professor Einstein",
                "Engineering Dept."
            ));

            student2.EmergencyContact.Add("023-356-8674");
            student2.EmergencyContact.Add("wife@gmail.org");
            
            studentList.Add(student2);

            // Student 3, Default object
            Models.Identity student3 = new Models.Identity();
            student3.PersonalInfo.FirstName = "Default Object";
            studentList.Add(student3 );

            return Json(studentList);

        }
    }
}
