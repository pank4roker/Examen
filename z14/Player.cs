using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z14
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание...");
        }

        public void Record()
        {
            Console.WriteLine("Запись..");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза.");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка.");
        }
    }
}
