using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLNhaTro.Models
{
    internal class Owner: User
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string fullName { get; set; }
        public DateTime dob { get; set; }
        public int gender { get; set; }
    }
}
