using Mutation.Domain.Model;

namespace Mutation.Domain
{
    public class CustomerService
    {
        public double CalculateTax(Customer customer, double billingAmmount)
        {
            double returnValue;
            if (customer.HasIVA)
            {
                returnValue =  billingAmmount*0.21;
            }
            else
            {
                returnValue =  0d;
            }
            return returnValue;
        }
    }
}
