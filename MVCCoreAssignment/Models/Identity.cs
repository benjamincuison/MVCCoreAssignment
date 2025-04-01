namespace MVCCoreAssignment.Models
{
    public class Identity
    {
        public Identity() { 
            Classes = new List<Course>();
            EmergencyContact = new List<string>();
            this.PersonalInfo = new PersonalInfo();
            this.Id = -1;
            this.Active = false;
            this.AccountBalance = 0;
            this.Role = string.Empty;
            this.Term = string.Empty;
            this.Group = string.Empty;
        }
        public int Id { get; set; } // Student / Faculty ID
        public Models.PersonalInfo PersonalInfo { get; set; } // Encapsulates data about name, email, phone, and address
        public bool Active { get; set; } // Determines if currently working or attending the school
        public double AccountBalance { get; set; } // Shows account balance for use in on campus tranactions
        public string Role { get; set; } // The internal position in the school (student / teacher / other staff)

        public string Term { get; set; } // The Fall / Winter / Summer term most recently attended
        public string Group {  get; set; } //  Which program / department a indentity is a part of
        
        public List<Course> Classes { get; set; } // Enrolled / Teaching classes
        public List<string> EmergencyContact { get; set; }




    }
}
