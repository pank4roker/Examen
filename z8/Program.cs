using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("gfdg","gfg","gdfgd",20,DateTime.Now);
            user.OutPut();
            Console.ReadLine();
        }
    }
}
