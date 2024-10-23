using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    internal class BufferFile
    {
        public String sender {  get; set; }
        public String receiver { get; set; }
        public  byte[] buffer { get; set; }
        public String extension { get; set; }
        public BufferFile(String sender, String receiver, byte[] buffer,string extension)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.buffer = buffer;
            this.extension = extension;
        }
    }
}
