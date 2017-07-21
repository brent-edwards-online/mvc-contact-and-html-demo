using BasicMVC.Entities;

namespace BasicMVC.Services
{
    public interface IMessageFormatter
    {
        string FormatMessage(BasicEntity entry);
    }
}
