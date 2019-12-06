using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMdiatr_01.Domain.Customer.Entity;

namespace TesteMdiatr_01.Infra
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<CustomerEntity> Customers { get; }

        public CustomerRepository()
        {
            Customers = new List<CustomerEntity> {
                new CustomerEntity(1, "cusotmer1@gmail.com", "first customer1", "last customer 1", "123456789"),
                new CustomerEntity(2, "cusotmer2@gmail.com", "first customer2", "last customer 2", "234567891")
            };
        }

        public async Task Save(CustomerEntity customer)
        {
            int pk = Customers.OrderBy(x => x.Id).Last().Id + 1;
            await Task.Run(() => Customers.Add(customer));
        }

        public async Task<IEnumerable<CustomerEntity>> GetAll()
        {
            return await Task.FromResult(Customers);
        }

        public async Task Update(int id, CustomerEntity customer)
        {
            int index = Customers.FindIndex(m => m.Id == id);
            if (index >= 0)
                await Task.Run(() => Customers[index] = customer);
        }

        public async Task Delete(int id)
        {
            int index = Customers.FindIndex(m => m.Id == id);
            await Task.Run(() => Customers.RemoveAt(index));
        }

        public async Task<CustomerEntity> GetById(int id)
        {
            var result = Customers.Where(p => p.Id == id).FirstOrDefault();
            return await Task.FromResult(result);
        }
    }
}
