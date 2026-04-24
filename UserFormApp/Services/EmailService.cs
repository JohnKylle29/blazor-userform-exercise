//2nd i created this
namespace UserFormApp.Services
{
    public class EmailService
    {
        public async Task<bool> IsEmailUnique(string email)
        {
            await Task.Delay(500); 

            // fake duplicate email
            if (email?.ToLower() == "test@gmail.com")
                return false;

            return true;
        }
    }
}