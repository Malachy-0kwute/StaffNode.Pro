using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using StaffNode.Pro.Application.Contracts.Persistence;
using StaffNode.Pro.Domain;
using StaffNode.Pro.Persistence.DatabaseContext;

namespace StaffNode.Pro.Persistence.Repos
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly StaffNodeProDatabaseContext _dbContext;

        public EmployeeRepository(StaffNodeProDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(EmployeeDataModel entity)
        {
            var result = 0;
            try
            {
                await _dbContext.Employees.AddAsync(entity);
                result = await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public async Task<int> DeleteAsync(string id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            int result = 0;

            try
            {
                if (employee?.Equals(null) is false)
                {
                    _dbContext.Employees.Remove(employee);
                    result = await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public async Task<IReadOnlyList<EmployeeDataModel>> GetAllAsync()
        {
            var employees = await _dbContext.Employees.AsQueryable().OrderBy(e => e.EmployeeId).Take(10).ToListAsync();

            return employees;
        }

        public async Task<EmployeeDataModel?> GetByIdAsync(string id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);

            return employee;
        }

        public async Task<int> UpdateAsync(EmployeeDataModel entity)
        {
            int result = 0;

            var newEmployeeInfo = await _dbContext.Employees.FindAsync(entity.Id);

            try
            {
                if (newEmployeeInfo?.Equals(null) is false)
                {
                    _dbContext.Employees.Update(entity);
                    result = await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
