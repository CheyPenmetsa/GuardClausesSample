namespace SampleGuardConsole
{
    public class Customer
    {
        public Customer(string fName, string lName, string email, int age, Address mailAddress, CustomerType customerType)
        {
            if (string.IsNullOrWhiteSpace(fName))
            {
                throw new ArgumentNullException(nameof(fName));
            }

            if(string.IsNullOrWhiteSpace(lName))
            {
                throw new ArgumentException("Last name cannot be empty", nameof(lName));
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Email cannot be empty", nameof(email));
            }

            if(age <= 0)
            {
                throw new ArgumentException("Age cannot be negative or zero", nameof(age));
            }

            if (mailAddress == null)
            {
                throw new ArgumentNullException(nameof(mailAddress), "Address cannot be null");
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public Address MailingAddress { get; set; }

        public CustomerType CustomerType { get; set; }
    }

    public enum CustomerType
    {
        NewCustomer,

        ReturningCustomer,

        None
    }
}
