using System;

namespace BridgePattern
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email Sender: \n{subject} \n{body}");
        }
    }
}
