using MongoDB.Bson;
using Microsoft.EntityFrameworkCore;
using StaffNode.Pro.Application.Contracts.Persistence;
using StaffNode.Pro.Domain;
using StaffNode.Pro.Persistence.DatabaseContext;

namespace StaffNode.Pro.Persistence.Repos
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly StaffNodeProDatabaseContext _dbContext;

        public ProfileRepository(StaffNodeProDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(ProfileDataModel entity)
        {
            var result = 0;
            try
            {
                await _dbContext.Profiles.AddAsync(entity);
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
            var profile = await _dbContext.Profiles.FindAsync(id);
            int result = 0;

            try
            {
                if (profile?.Equals(null) is false)
                {
                    _dbContext.Profiles.Remove(profile);
                    result = await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Profile not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public async Task<IReadOnlyList<ProfileDataModel>> GetAllAsync()
        {
            var profiles = await _dbContext.Profiles.AsQueryable().OrderBy(c => c.CreatedDate).Take(10).ToListAsync();

            return profiles;
        }

        public async Task<ProfileDataModel?> GetByIdAsync(string id)
        {
            var profile = await _dbContext.Profiles.FindAsync(id);

            return profile;
        }

        public async Task<int> UpdateAsync(ProfileDataModel entity)
        {
            int result = 0;

            var newProfileInfo = await _dbContext.Contacts.FindAsync(entity.Id);

            try
            {
                if (newProfileInfo?.Equals(null) is false)
                {
                    _dbContext.Profiles.Update(entity);
                    result = await _dbContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Profile not found.");
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
