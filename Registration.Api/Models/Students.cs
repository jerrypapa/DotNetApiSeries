using System.ComponentModel.DataAnnotations;

namespace Registration.Api.Models
{
    public class Students
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Students(string firstName,string lastName,string emailAddress,
            string phoneNumber,DateTime dateOfBirth) 
        { 
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName =!string.IsNullOrWhiteSpace(lastName)?firstName:"";

            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            EmailAddress = emailAddress;
        }
        public static Students AddNewStudent(string firstName, string lastName, string emailAddress,
            string phoneNumber, DateTime dateOfBirth)
        {
            return new Students(firstName, lastName, emailAddress, phoneNumber, dateOfBirth);
        }
    }
}


