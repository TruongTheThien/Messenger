using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Messenger
{
    internal class Messages
    {
        public String sender {  get; set; }
        public String receiver { get; set; }
        public String message { get; set; }
        public bool IsForServer { get; set; }
        public Messages(String sender,String receiver,String message) 
        {
            this.sender = sender;
            this.receiver = receiver;
            this.message = message;
        }
        [JsonConstructor]
        public Messages() { }
    }
}
