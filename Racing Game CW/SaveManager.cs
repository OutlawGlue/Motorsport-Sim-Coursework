using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
    }
}