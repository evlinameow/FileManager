using CommandsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLib.Commands
{
    public class CommandDeleteFile : ICommands
    {
        public string ComandInfo()
        {
            return "удаление файла";
        }
        private Dictionary<string, string> _comands = new Dictionary<string, string>
        {
            {"DeleteFile",  "DeleteFile" },
            {"deletefile",  "DeleteFile" },
            {"DFL",         "DeleteFile" },
            {"dfl",         "DeleteFile" }
        };
        public Dictionary<string, string> ComandName()
        {
            return _comands;
        }
        public string Execute(string[] args)
        {
            FileInfo fileInfo = new FileInfo(args[1]);
            try
            {
                if (fileInfo.Exists)
                    fileInfo.Delete();
                else
                    return $"файл {fileInfo} не найден";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return $"файл {fileInfo} удален ";
        }
    }
}
