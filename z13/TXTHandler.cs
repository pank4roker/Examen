using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace z13
{
    class TXTHandler : AbstractHandler
    {
        /// <summary>
        /// Переопределенный метод открытия 
        /// </summary>
        public override void Open()
        {
            WriteLine("Open document format - TXT ");
        }
        /// <summary>
        /// Переопределенный метод создания
        /// </summary>
        public override void Create()
        {
            WriteLine("Open document format - TXT ");
        }
        /// <summary>
        /// Переопределенный метод изменения
        /// </summary>
        public override void Change()
        {
            WriteLine("Open document format - TXT ");
        }
        /// <summary>
        /// Переопределенный метод сохранения
        /// </summary>
        public override void Save()
        {
            WriteLine("Open document format - TXT ");
        }
    }
}
