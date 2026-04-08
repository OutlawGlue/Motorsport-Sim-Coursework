using MotorsportSim.General;
using System.Collections.Generic;
using System.IO;

namespace MotorsportSim.Menus
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
                MsgBox.ShowInfo("User File Not Found", "New user data file created.");
            }
            string[] lines = File.ReadAllLines(FILEPATH);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
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
                MsgBox.ShowError("Sign In Failed", "Invalid credentials");
                return false;
            }

            string storedHash = userDict[username].Password;

            if (!PasswordHasher.VerifyPassword(password, storedHash))
            {
                MsgBox.ShowError("Sign In Failed", "Invalid credentials");
                return false;
            }

            MsgBox.ShowInfo("Success", "Signed in");
            return true;
        }

        //Used when creating account:
        public bool CreateAccount(string username, string password, string confirmPassword)
        {
            if (!(username.Length >= 5 && username.Length <= 15))
            {
                MsgBox.ShowError("Invalid Username",
                    "Usernames must be between 5 and 15 characters");
                return false;
            }

            if (!(password.Length >= 8 && password.Length <= 30))
            {
                MsgBox.ShowError("Invalid Password",
                    "Passwords must be between 8 and 30 characters");
                return false;
            }

            if (password != confirmPassword)
            {
                MsgBox.ShowError("Invalid Password",
                    "Passwords do not match");
                return false;
            }

            if (userDict.ContainsKey(username))
            {
                MsgBox.ShowError("Username Unavailable",
                    "This username is already in use");
                return false;
            }

            //Prevent csv errors:
            if (username.Contains(","))
            {
                MsgBox.ShowError("Invalid Username", "Username cannot contain commas");
                return false;
            }

            CreateUser(username, password);

            MsgBox.ShowInfo("Success", "Account successfully created");
            return true;
        }

        private void CreateUser(string username, string password)
        {
            string hashedPassword = PasswordHasher.HashPassword(password);

            User newUser = new User(username, hashedPassword);
            userDict.Add(username, newUser);

            using (StreamWriter sw = File.AppendText(FILEPATH))
            {
                sw.WriteLine($"{username},{hashedPassword}");
            }
        }
    }
}