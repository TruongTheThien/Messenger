using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Communicator
{
    public class danhsach
    {
        private static danhsach instance;
        private List<Account> ListAccountUser;

        public List<Account> ListAccountUser { get => listAccountUser; set => listAccountUser = value; }

        public static danhsach Instance
        {
            get
            {
                if (instance == null)
                    instance = new danhsach();
                return instance;
            }
            set => instance = value;
        }

        public danhsach()
        {
            ListAccountUser = new List<Account>();
            ListAccountUser.Add(new Account("Thien", "123"));
            ListAccountUser.Add(new Account("Thanh", "123"));
            ListAccountUser.Add(new Account("Khang", "123"));
            ListAccountUser.Add(new Account("Bao", "123"));
        }
    }
}
