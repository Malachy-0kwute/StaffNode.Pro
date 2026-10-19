using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using StaffNode.Pro.Application.Contracts.Persistence;
using StaffNode.Pro.Domain;
using StaffNode.Pro.Persistence.DatabaseContext;
using StaffNode.Pro.Persistence.Validation;
using System.Text.Json;

namespace StaffNode.Pro.Persistence.Repos
{
    public class ContactRepository : IContactRepository
    {
        private readonly StaffNodeProDatabaseContext _dbContext;

        public ContactRepository(StaffNodeProDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(ContactDataModel entity)
        {
            var result = 0;

            var validator = new Validator();
            var validationResult = validator.Validate(entity);

            if (validationResult.IsValid.Equals(false))
            {
                var errorMessages = string.Join(", ", validationResult.Errors);
                throw new Exception($"Validation failed: {errorMessages}");
            }

            try
            {
                await _dbContext.Contacts.AddAsync(entity);
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
            var contact = await _dbContext.Contacts.FindAsync(id);
            int result = 0;

            try
            {
                if (contact?.Equals(null) is false)
                {
                    _dbContext.Contacts.Remove(contact);
                    result = await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Contact not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public async Task<IReadOnlyList<ContactDataModel>> GetAllAsync()
        {
            var contacts = await _dbContext.Contacts.AsQueryable().OrderBy(c => c.ZipCode).Take(10).ToListAsync();

            return contacts;
        }

        public async Task<ContactDataModel?> GetByIdAsync(string id)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);

            return contact;
        }

        public async Task<int> UpdateAsync(ContactDataModel entity)
        {
            int result = 0;

            var newContactInfo = await _dbContext.Contacts.FindAsync(entity.Id);

            try
            {
                if (newContactInfo?.Equals(null) is false)
                {
                    _dbContext.Contacts.Update(entity);
                    result = await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Contact not found.");
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
