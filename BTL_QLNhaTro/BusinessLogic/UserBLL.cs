using BTL_QLNhaTro.DataAccess;
using BTL_QLNhaTro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNhaTro.BusinessLogic
{
    internal class UserBLL
    {
        private readonly UserDAL _userDAL;

        public UserBLL(string connectionString)
        {
            _userDAL = new UserDAL(connectionString);
        }

        public bool ValidateOldPassword(int userId, string oldPassword)
        {
            return _userDAL.CheckOldPassword(userId, oldPassword);
        }

        public bool ChangePassword(int userId, string oldPassword, string newPassword)
        {
            if (!_userDAL.CheckOldPassword(userId, oldPassword))
            {
                return false;
            }

            int rowsAffected = _userDAL.UpdatePassword(userId, newPassword);
            return rowsAffected > 0;
        }

        public bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        public bool IsPhoneValid(string phone)
        {
            string pattern = @"^\d{10}$"; // Assuming 10 digits for a phone number
            return System.Text.RegularExpressions.Regex.IsMatch(phone, pattern);
        }

        public bool CheckIfEmailExists(string email)
        {
            return _userDAL.CheckEmailExists(email);
        }

        public bool CheckIfPhoneExists(string phone)
        {
            return _userDAL.CheckPhoneExists(phone);
        }

        public bool RegisterUser(Customer user)
        {
            return _userDAL.RegisterUser(user);
        }
        public User ValidateLogin(string username, string password)
        {
            return _userDAL.GetUserByUsernameAndPassword(username, password);
        }
        public string queryGetInfoUserBuildingOwner(int userId)
        {
            return _userDAL.getInfoUserBuildingOwner(userId);
        }
        public string queryGetInfoUserCustomer(int userId)
        {
            return _userDAL.getInfoUserCustomer(userId);
        }
        public void updateInfoUser(string roleUpdate, string email, string phoneNumber, string fullName, string dob, int gender, int userID)
        {
            _userDAL.updateInfoUser(roleUpdate, email, phoneNumber, fullName,dob, gender, userID);
        }
        public int addCustomer(string fullName, int role, string dob, string email, string phoneNumber, string password, int roomId) => _userDAL.addCustomer(fullName, role, dob, email, phoneNumber, password, roomId);
    }
}
