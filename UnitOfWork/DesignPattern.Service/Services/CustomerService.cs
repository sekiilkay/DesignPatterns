using DesignPattern.Core.Entities;
using DesignPattern.Core.Repositories;
using DesignPattern.Core.Services;
using DesignPattern.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Customer entity)
        {
            await _customerRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(Customer entity)
        {
            _customerRepository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task MultiUpdateAsync(List<Customer> entities)
        {
            _customerRepository.MultiUpdate(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(Customer entity)
        {
            _customerRepository.Update(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
