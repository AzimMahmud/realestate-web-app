using System.Threading.Tasks;

namespace RealEstateApp.Service
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}
