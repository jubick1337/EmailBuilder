using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailBuilder
{
    class StateBuilder
    {
        public MailBuilder AddReceiver(string receiver)
        {
            return new MailBuilder(receiver);
        }

        public class MailBuilder
        {
            string Receiver { get; set; }
            public MailBuilder(string receiver)
            {
                Receiver = receiver;
            }

            public FinalMailBuilder AddBody(String body)
            {
                return new FinalMailBuilder(Receiver, body);
            }
        }
    }

    class FinalMailBuilder
    {
        string Receiver { get; set; }
        string Body { get; set; }
        string Header { get; set; }

        public FinalMailBuilder(string receiver, string body)
        {
            Receiver = receiver;
            Body = body;
        }

        public FinalMailBuilder AddTheme(string header)
        {
            Header = header;
            return this;
        }
        public FinalMailBuilder AddNewRecivier(string recivier)
        {
            Receiver += " " + recivier;
            return this;
        }
        public string Build()
        {
            return Receiver + " " + Header + " " + Body + "\n";
        }
    }
}
