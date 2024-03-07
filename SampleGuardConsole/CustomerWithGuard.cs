using Ardalis.GuardClauses;

namespace SampleGuardConsole
{
     public class CustomerWithGuard
    {
        public CustomerWithGuard(string fName, string lName, string email, int age, Address mailAddress, CustomerType customerType)
        {
            FirstName = Guard.Against.NullOrWhiteSpace(fName);
            LastName = Guard.Against.NullOrWhiteSpace(lName, nameof(lName), "Last Name cannot be null or empty");
            Email = Guard.Against.NullOrWhiteSpace(email);
            Age = Guard.Against.NegativeOrZero(age);
            MailingAddress = Guard.Against.Null(mailAddress, nameof(mailAddress), "Mailing address cannot be null");
            //Custom Guard
            CustomerType = Guard.Against.None(customerType);
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public Address MailingAddress { get; set; }

        public CustomerType CustomerType { get; set; }
    }
}
