using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Segment<int> segment = new Segment<int>(1, 2, 4, -5);
            segment.ShowInfo();
            Console.WriteLine(segment.LengthOfTheSegment());
            Segment<long> segment1 = new Segment<long>(1, 2, 4, -5);
            segment1.ShowInfo();
            Console.WriteLine(segment1.LengthOfTheSegment());
            Segment<double> segment2 = new Segment<double>(4.4, 5.5, -2.2, -3.5);
            segment2.ShowInfo();
            Console.WriteLine(segment2.LengthOfTheSegment());
            Console.ReadLine();
        }
    }
}
