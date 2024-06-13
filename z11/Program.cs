using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker documentWorker;

            Console.WriteLine("Введите ключ доступа: ");
            string key = Console.ReadLine();

            if (key == "pro")
            {
                documentWorker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                documentWorker = new ExpertDocumentWorker();
            }
            else
            {
                documentWorker = new DocumentWorker();
            }

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();

            Console.ReadLine();
        }
    }
}
