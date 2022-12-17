using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLib.Commands
{
    internal class CommandDirectoryInfo : ICommands
    {
        public string ComandInfo()
        {
            return "информация о папке";
        }
        private Dictionary<string, string> _comands = new Dictionary<string, string>()
        {
            {"DirectoryInfo",    "DirectoryInfo" },
            {"DI",               "DirectoryInfo" },
            {"di",               "DirectoryInfo" },
            {"directoryinfo",    "DirectoryInfo" }
        };
        public Dictionary<string, string> ComandName()
        {
            return _comands;
        }
        public string Execute(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(args[1]);

            string str = $"информация о файле:\n имя: {directoryInfo.Name}" +
               $"|" +
               $"|создан: {directoryInfo.CreationTime}" +
               $"|атрибуты: {directoryInfo.Attributes}" +
               $"\n полный путь: {directoryInfo.FullName}";

            return str;
        }
    }
}
