namespace Culinary_Crossroads.Core.Contacts
{
    public interface IAgentService
    {
        public Task<int> GetAgentIdAsync(string userId);
        public Task<bool> ExistByIdAsync(string userId);
        public Task<bool> UserWithPhoneNumberExistAsync(string phoneNumber);

        public Task CreateAsync(string userId, string phoneNumber);
    }
}
