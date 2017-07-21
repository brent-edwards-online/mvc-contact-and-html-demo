using System.Threading.Tasks;


namespace BasicMVC.Services
{
    public interface IEmailService
    {
        bool EmailMessage(string toAddress, string subject, string message);
    }
} 
