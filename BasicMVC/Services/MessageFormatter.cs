using System;
using System.Text;
using BasicMVC.Entities;

namespace BasicMVC.Services
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