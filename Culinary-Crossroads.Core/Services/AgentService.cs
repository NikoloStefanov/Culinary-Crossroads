using Culinary_Crossroads.Core.Contacts;
using Culinary_Crossroads.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Culinary_Crossroads.Infrastructure.Data.Models;

namespace Culinary_Crossroads.Core.Services
{

    public class AgentService : IAgentService
    {
        private readonly ApplicationDbContext data;
        public AgentService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public async Task CreateAsync(string userId, string phoneNumber)
        {
            var agent = new Culinary_Crossroads.Infrastructure.Data.Models.Agent()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };
            await data.Agents.AddAsync(agent);
            await data.SaveChangesAsync();
        }

        public async Task<bool> ExistByIdAsync(string userId)
        {
            return await data.Agents.AnyAsync(a => a.UserId == userId);
        }

        public async Task<int> GetAgentIdAsync(string userId)
        {
            var agent = await data.Agents.FirstOrDefaultAsync(a => a.UserId == userId);
            return agent?.Id ?? -1;
        }

        public async Task<bool> UserWithPhoneNumberExistAsync(string phoneNumber)
        {
            return await data.Agents.AnyAsync(a => a.PhoneNumber == phoneNumber);
        }

    }
}
