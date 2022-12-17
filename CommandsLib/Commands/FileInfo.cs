using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLib.Commands
{
    internal class CommandFileInfo : ICommands
    {
        public string ComandInfo()
        {
            return "Информация о файле";
        }
        private Dictionary<string, string> _comands = new Dictionary<string, string>()
        {
            {"FileInfo",    "FileInfo" },
            {"FI",          "FileInfo" },
            {"fi",          "FIleInfo" },
            {"fileinfo",    "FileInfo" }
        };
        public Dictionary<string, string> ComandName()
        {
            return _comands;
        }
        public string Execute(string[] args)
        {
            FileInfo fileInfo = new FileInfo(args[1]);

            string str = $"Информация о файле:\n Имя: {fileInfo.Name}" +
               $"| Расширение: {fileInfo.Extension}" +
               $"|Размер файла: {fileInfo.Length} байт" +
               $"|" +
               $"|Создан: {fileInfo.CreationTime}" +
               $"|Атрибуты: {fileInfo.Attributes}" +
               $"\n Полный путь: {fileInfo.FullName}";

            return str;
        }
    }
}
