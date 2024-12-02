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
        public string FullName { get; set; }
        public int Gender { get; set; } // 0 for Female, 1 for Male
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Role { get; set; } // Role (1 for User, 2 for Admin, etc.)
    }
}
