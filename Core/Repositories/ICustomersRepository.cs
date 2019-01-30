using supermasks.Models;

namespace supermasks.Core.Repositories
{
    public interface ICustomersRepository : IRepository<CustomerMaster>
    {
        CustomerMaster Changepassword(int custid, string npass, string rpass);
        CustomerMaster Activate(string email);

        CustomerMaster GetCustomer(string email);
        CustomerMaster GetCustomer(string email, string pass);

    }
}