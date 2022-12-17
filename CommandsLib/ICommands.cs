using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsLib.Commands
{
    public interface ICommands
    {
        /// <summary>
        /// Метод выполнить
        /// </summary>
        string Execute(string[] args);
        /// <summary>
        /// Описание команд
        /// </summary>
        /// <returns></returns>
        string ComandInfo();
        /// <summary>
        /// Словарь наименований
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> ComandName();
    }
}