using MotorsportSim.General;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using MotorsportSim.RaceSim;
using System.Drawing;
using MotorsportSim.Menus;

namespace MotorsportSim.Career
{
    public class SaveManager
    {
        private string folderPath;
        private string username;

        public SaveManager(string username) 
        {
            GetUserFolder(username);
        }

        public string Username
        {
            get { return username; }
        }

        private string GetUserFolder(string username)
        {
            folderPath = Path.Combine("Users", username);
            return folderPath;
        }

        public void SaveLocationAvailable(bool createNew)
        {
            if (!Directory.Exists(folderPath))
            {
                if (createNew)
                {
                    try
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    catch
                    {
                        MsgBox.ShowError("Save Folder Error",
                            "A file with the name 'GameSaves' already exists.");
                        return;
                    }

                    MsgBox.ShowInfo("Save Folder Not Found",
                        "New save folder created.");
                    return;
                }

                MsgBox.ShowError("Save Folder Not Found",
                    "Could not find save folder");
            }
        }

        public string[] LoadSaveList()
        {
            SaveLocationAvailable(true); //Create a new directory if needed
            string[] saves = Directory.GetFiles(folderPath);
            return saves;
        }

        public List<BasicTeam> LoadBasicTeamList()
        {
            List<BasicTeam> teams = new List<BasicTeam>();

            using (StreamReader sr = new StreamReader("Teams.txt"))
            {
                int teamIndex = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(',');

                    // Team lines have 4 parts: Name,R,G,B
                    if (parts.Length == 4)
                    {
                        BasicTeam team = new BasicTeam(parts[0], teamIndex);
                        teams.Add(team);
                    }
                }
            }

            return teams;
        }

        public List<Team> LoadTeamList(int teamCount, int managedTeamIndex)
        {
            List<Team> teams = new List<Team>();

            string[] lines = File.ReadAllLines("Teams.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                string[] teamParts = lines[i].Split(',');

                //Read in team line
                if (teamParts.Length == 4)
                {
                    string teamName = teamParts[0];
                    int r = int.Parse(teamParts[1]);
                    int g = int.Parse(teamParts[2]);
                    int b = int.Parse(teamParts[3]);

                    List<Driver> drivers = new List<Driver>();

                    //Read in 2 driver lines
                    for (int j = 1; j <= 2; j++)
                    {
                        string[] driverParts = lines[i + j].Split(',');

                        string driverName = driverParts[0];
                        int driverNumber = int.Parse(driverParts[1]);

                        drivers.Add(new Driver(driverName, driverNumber));
                    }

                    Color teamColour = Color.FromArgb(r, g, b);
                    teams.Add(new Team(teamName, teamColour, drivers));

                    i += 2; // Skip driver lines
                }
            }

            // Now select only required teams
            List<Team> activeTeams = new List<Team>();

            // Add player team first
            //activeTeams.Add(teams[managedTeamIndex]);

            // Add AI teams (simple: first N-1 excluding player)
            for (int i = 0; i < teams.Count && activeTeams.Count < teamCount; i++)
            {
                //if (i != managedTeamIndex)
                //{
                    activeTeams.Add(teams[i]);
                //}
            }

            return activeTeams;
        }

        public void SaveCareer(CareerSave save)
        {
            string fullPath = folderPath + "/" + save.CareerName + ".json";
            string saveJSON = JsonConvert.SerializeObject(save, Formatting.Indented);
            File.WriteAllText(fullPath, saveJSON);
        }

        public CareerSave LoadSave(string saveName)
        {
            string fullPath = folderPath + "/" + saveName + ".json";
            string json = File.ReadAllText(fullPath);
            CareerSave save = JsonConvert.DeserializeObject<CareerSave>(json);

            return save;
        }

        public bool CreateNewSave(string saveName, CareerSave saveData)
        {
            if (!Regex.IsMatch(saveName, @"^[A-Za-z0-9 _-]+$"))
            {
                MsgBox.ShowError("Save Creation Error",
                    "Save name contains invalid characters.\n" +
                    "Only letters, numbers, spaces, underscores and hyphens are allowed.");
                return false;
            }

            string filePath = Path.Combine(folderPath, saveName + ".json");

            if (File.Exists(filePath))
            {
                MsgBox.ShowError("Save Creation Error",
                    "A save file with that name already exists.");
                return false;
            }

            saveData.CareerName = saveName;

            //Don't write all data here
            //string json = JsonConvert.SerializeObject(saveData, Formatting.Indented);

            //File.WriteAllText(filePath, json);

            SaveCareer(saveData); //This should only write some data

            MsgBox.ShowInfo("Save Created",
                "New save file created successfully.");

            return true;
        }
    }
}