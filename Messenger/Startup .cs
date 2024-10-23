using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    internal class Startup
    {
        public String onlUser {  get; set; }
        public String group { get; set; }
        public Startup(String onlUser,string group) 
        {
            this.onlUser = onlUser;
            this.group = group;
        }
    }
}
