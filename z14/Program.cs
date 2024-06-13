using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z14
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            // Проигрывание
            player.Play();
            player.Pause();
            player.Stop();

            // Запись
            player.Record();
            player.Pause();
            player.Stop();
            Console.ReadKey();
        }
    }
}
