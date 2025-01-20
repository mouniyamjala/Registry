using System.ComponentModel.DataAnnotations;

namespace Registry.Domain
{
    public class UserData
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? TerminateDate { get; set; }
        public string Email { get; set; }
        public string status { get; set; }

    }
}
