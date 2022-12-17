using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLib.Commands
{
    internal class CommandList : ICommands
    {
        string _printList = "";
        public string ComandInfo()
        {
            return "cписок папок и файлов";
        }
        private Dictionary<string, string> _comands = new Dictionary<string, string>()
        {
            {"List",    "List"},
            {"list",    "List"},
            {"LS",      "List"},
            {"ls",      "List"}
        };
        public Dictionary<string, string> ComandName()
        {
            return _comands;
        }
        public string Execute(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(args[1]);
            DirectoryInfo[] foldersList = dirInfo.GetDirectories();
            FileInfo[] filesList = dirInfo.GetFiles();
            try
            {
                if (foldersList.Length > 0) _printList += ("        Папки       " + "\n");
                foreach (DirectoryInfo folder in foldersList)
                {
                    string message = folder.Name;
                    _printList += (message + "\n");
                }
                if (filesList.Length > 0) _printList += ("         Файлы        " + "\n");
                foreach (FileInfo file in filesList)
                {
                    string message = file.Name;
                    _printList += (message + "\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _printList;
        }
    }
}
