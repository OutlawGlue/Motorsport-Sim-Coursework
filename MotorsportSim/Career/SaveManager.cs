using MotorsportSim.General;
using System.IO;
using System.Text.RegularExpressions;

namespace MotorsportSim.Career
{
    internal class SaveManager
    {
        private const string FOLDER = "GameSaves";

        public void SaveLocationAvailable(bool createNew)
        {
            if (!Directory.Exists(FOLDER))
            {
                if (createNew)
                {
                    try
                    {
                        Directory.CreateDirectory(FOLDER);
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
            string[] saves = Directory.GetFiles(FOLDER);
            return saves;
        }

        public bool CreateNewSave(string saveName)
        {
            //Validation:
            if (!Regex.IsMatch(saveName, @"^[A-Za-z0-9 _-]+$"))
            {
                MsgBox.ShowError("Save Creation Error",
                    "Save name contains invalid characters.\n" +
                    "Only letters, numbers, spaces, underscores and hyphens are allowed.");
                return false;
            }

            if (!File.Exists(FOLDER + "/" + saveName))
            {
                File.Create(FOLDER + "/" + saveName + ".txt").Close();
                MsgBox.ShowInfo("Save Created",
                    "New save file created successfully.");
                return true;
            }
            else
            {
                MsgBox.ShowError("Save Creation Error",
                    "A save file with that name already exists.");
                return false;
            }
        }
    }
}