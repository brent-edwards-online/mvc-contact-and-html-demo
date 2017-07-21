using ContactMVC.Entities;

namespace ContactMVC.Services
{
    public interface IMessageFormatter
    {
        string FormatMessage(BasicEntity entry);
    }
}
