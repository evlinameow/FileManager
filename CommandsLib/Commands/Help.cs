using CommandsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLib.Commands
{
    internal class ComandHelp : ICommands
    {
        public string ComandInfo()
        {
            return "список команд с описанием";
        }
        private Dictionary<string, string> _comands = new Dictionary<string, string>()
        {
            {"Help",    "Help" },
            {"help",    "Help" },
            {"!Help",   "Help" },
            {"!help",   "Help" },
        };

        public Dictionary<string, string> ComandName()
        {
            return _comands;
        }
        public string Execute(string[] args)
        {
            string messagehelp = $"        основные команды:\n" +
                $"cd <путь> \t\t - перемещение по файловой системе\n" +
                $"List \t\t\t - вывод списка файлов и папок\n" +
                $"DFL <путь> \t\t - удаление файла\n" +
                $"DF <путь> \t\t - удаление папки\n" +
                $"CF <путь> > <путь>\t - копирование файла с заменой\n" +
                $"CFFF <путь> > <путь>\t - копирование файлов из папки в другую папку\n" +
                $"tree \t\t\t - просмотр файловой системы\n" +
                $"fi <путь> \t\t - вывод информации о файле. путь относительный или полный\n" +
                $"di <путь> \t\t - вывод информации о папке. путь относительный или полный\n" +
                $"!clear \t\t\t - очистка консоли\n" +
                $"!help \t\t\t - описание команд\n";
            return messagehelp;
        }
    }
}
