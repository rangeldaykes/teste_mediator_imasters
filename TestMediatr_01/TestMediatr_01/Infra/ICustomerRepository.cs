using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMdiatr_01.Domain.Customer.Entity;

namespace TesteMdiatr_01.Infra
{
    public interface ICustomerRepository
    {
        Task Save(CustomerEntity customer);
        Task Update(int id, CustomerEntity customer);
        Task Delete(int id);
        Task<CustomerEntity> GetById(int id);
        Task<IEnumerable<CustomerEntity>> GetAll();
    }
}
