using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Racing_Game_CW
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
                        Message.ShowError("Save Folder Error",
                            "A file with the name 'GameSaves' already exists.");
                        return;
                    }

                    Message.ShowInfo("Save Folder Not Found",
                        "New save folder created.");
                    return;
                }

                Message.ShowError("Save Folder Not Found",
                    "Could not find save folder");
            }
        }

        public string[] LoadSaveList()
        {
            string[] saves = Directory.GetFiles(FOLDER);
            return saves; //Add this to the combo box
        }

        public bool CreateNewSave(string saveName)
        {
            //Validation:
            if (!Regex.IsMatch(saveName, @"^[A-Za-z0-9 _-]+$"))
            {
                Message.ShowError("Save Creation Error",
                    "Save name contains invalid characters.\n" +
                    "Only letters, numbers, spaces, underscores and hyphens are allowed.");
                return false;
            }

            if (!File.Exists(FOLDER + "/" + saveName))
            {
                File.Create(FOLDER + "/" + saveName + ".txt").Close();
                Message.ShowInfo("Save Created",
                    "New save file created successfully.");
                return true;
            }
            else
            {
                Message.ShowError("Save Creation Error",
                    "A save file with that name already exists.");
                return false;
            }
        }
    }
}