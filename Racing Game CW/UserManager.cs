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
        private Dictionary<string, User> userDict = new Dictionary<string, User>();

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

        //Used when signing in:
        public bool SignIn(string username, string password)
        {
            if (!userDict.ContainsKey(username))
            {
                Message.ShowError("Sign In Failed", "Account does not exist");
                return false;
            }
            else if (userDict[username].Password != password)
            {
                Message.ShowError("Sign In Failed", "Username and password do not match");
                return false;
            }
            Message.ShowInfo("Success", "Signed in");
            return true;
        }

        //Used when creating account:
        public bool CreateAccount(string username, string password, string confirmPassword)
        {
            if (!(username.Length >= 5 && username.Length <= 15))
            {
                Message.ShowError("Invalid Username",
                    "Usernames must be between 5 and 15 characters");
                return false;
            }
            else if (!(password.Length >= 8 && password.Length <= 30))
            {
                Message.ShowError("Invalid Password",
                    "Passwords must be between 8 and 30 characters");
                return false;
            }
            else if (password != confirmPassword)
            {
                Message.ShowError("Invalid Password",
                    "Passwords do not match");
                return false;
            }
            else if (userDict.ContainsKey(username))
            {
                Message.ShowError("Username Unavailable",
                    "This username is already in use");
            }
            CreateUser(username, password);
            Message.ShowInfo("Success", "Account successfully created");
            return true;
        }

        private void CreateUser(string username, string password)
        {
            User newUser = new User(username, password);
            userDict.Add(username, newUser);

            using (StreamWriter sw = File.AppendText(FILEPATH))
            {
                sw.WriteLine($"{username},{password}");
            }
        }
    }
}