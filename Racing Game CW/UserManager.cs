using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Racing_Game_CW
{
    internal class UserManager
    {
        private const string FILEPATH = "users.txt";
        Dictionary<string, User> userDict = new Dictionary<string, User>();

        public UserManager()
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            if (!File.Exists(FILEPATH))
            {
                File.Create(FILEPATH).Close();
                Message.ShowInfo("User File Not Found", "New user data file created.");
            }
            var lines = File.ReadAllLines(FILEPATH);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2)
                {
                    User user = new User(parts[0], parts[1]);
                    userDict[parts[0]] = user;
                }
            }
        }

        //Used when logging in:
        public bool Login(string username, string password)
        {
            if (!userDict.ContainsKey(username))
            {
                Message.ShowError("Login Failed", "Account does not exist");
                return false;
            }
            else if (userDict[username].Password != password)
            {
                Message.ShowError("Login Failed", "Username and password do not match");
                return false;
            }
            return true;
        }

        //Used when creating account:
        public static bool ValidateUsername(string username)
        {
            if (username.Length >= 5 && username.Length <= 15)
            {
                return true;
            }
            Message.ShowError("Invalid Username",
                "Usernames must be between 5 and 15 characters");
            return false;
        }
        public static bool ValidatePassword(string password)
        {
            if (password.Length >= 8 && password.Length <= 30)
            {
                return true;
            }
            Message.ShowError("Invalid Password",
                "Passwords must be between 8 and 30 characters");
            return false;
        }
    }
}
