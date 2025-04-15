using System.Runtime.Serialization;

namespace MVCCoreAssignment.Models
{
    [Serializable]
    public class PersonalInfo
    {
        
        public PersonalInfo ()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Address = "";
            this.ContactEmail = "";
            this.ContactPhoneNumber = "";
        }
        [DataMember]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
    }
}
