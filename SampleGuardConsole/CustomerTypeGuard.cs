using Ardalis.GuardClauses;

namespace SampleGuardConsole
{
    public static class CustomerTypeGuard
    {
        public static CustomerType None(this IGuardClause clause, CustomerType customerType)
        {
            if(customerType == CustomerType.None)
            {
                throw new ArgumentException("Customer type cannot be none");
            }

            return customerType;
        }
    }
}
