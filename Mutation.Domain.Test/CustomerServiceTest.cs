using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutation.Domain.Model;
using Xunit;

namespace Mutation.Domain.Test
{
    public class CustomerServiceTest
    {
        [Fact]
        public void BasicCustomerServiceTest()
        {
            var custSrv= new CustomerService();
            var qty = custSrv.CalculateTax(new Customer {HasIVA = true}, 10);
            Assert.Equal(qty,2.1);
        }

        [Fact]
        public void BasicCustomerServiceTestMono()
        {
            var custSrv = new CustomerService();
            var qty = custSrv.CalculateTax(new Customer { HasIVA = false }, 10);
            Assert.Equal(qty, 0d);
        }
    }
}
