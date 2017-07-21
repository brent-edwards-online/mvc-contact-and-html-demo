using System.Threading.Tasks;


namespace ContactMVC.Services
{
    public interface IEmailService
    {
        bool EmailMessage(string toAddress, string subject, string message);
    }
} 
