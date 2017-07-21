using System;
using System.Text;
using ContactMVC.Entities;

namespace ContactMVC.Services
{
    public class MessageFormatter : IMessageFormatter
    {
        public string FormatMessage(BasicEntity entry)
        {
            StringBuilder messageBody = new StringBuilder();
            return messageBody.ToString();
        }
    }
}