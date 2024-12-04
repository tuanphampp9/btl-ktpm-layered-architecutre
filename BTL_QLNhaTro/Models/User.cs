using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.Models
{
    internal class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Role { get; set; }
        public string Password { get; set; }
    }
}
