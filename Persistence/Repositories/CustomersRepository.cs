using System;
using System.Linq;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class CustomersRepository : Repository<CustomerMaster>, ICustomersRepository
    {
        public CustomersRepository(fantasyfaceContext context) : base(context)
        {
        }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }

        public CustomerMaster Activate(string email)
        {
            var customer = PssContext.CustomerMaster.SingleOrDefault(x => x.Email == email && x.Status==0);
            if (customer.Equals(null))
                return null;

            customer.Status = 1;
            PssContext.SaveChanges();
            return customer;
        }

        public CustomerMaster GetCustomer(string email, string pass)
        {
            var customer = PssContext.CustomerMaster.SingleOrDefault(x => x.Email == email && x.Password == pass);
            return customer;
        }

        public CustomerMaster GetCustomer(string email)
        {
            var customer = PssContext.CustomerMaster.SingleOrDefault(x => x.Email == email);
            return customer;
        }

        public CustomerMaster Changepassword(int custid, string npass, string rpass)
        {
            var user = PssContext.CustomerMaster.Find(custid);
            if (user == null)
                return null;
            if (npass == rpass)
            {
                user.Password = npass;
                PssContext.SaveChanges();
                return user;
            }

            return null;
        }
    }
    
}