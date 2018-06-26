using System;

namespace BridgePattern
{
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"MSMQ Sender: \n{subject} \n{body}");
        }
    }
}
