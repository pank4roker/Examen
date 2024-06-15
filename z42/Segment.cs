using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z42
{
   
        class Segment<T>
        {
            T x1;
            T x2;
            T y1;
            T y2;

            public Segment() { }
            public Segment(T x1, T x2, T y1, T y2)
            {
                X1 = x1;
                X2 = x2;
                Y1 = y1;
                Y2 = y2;
            }

            public T X1 { get => x1; set => x1 = value; }
            public T X2 { get => x2; set => x2 = value; }
            public T Y1 { get => y1; set => y1 = value; }
            public T Y2 { get => y2; set => y2 = value; }
            public void ShowInfo()
            {
                Console.WriteLine($"A: {X1}; {Y1}\nB: {X2}; {Y2}");
            }
            public dynamic LengthOfTheSegment()
            {
                return $"{Math.Sqrt(Math.Pow((dynamic)X2 - (dynamic)X1, 2) + Math.Pow((dynamic)Y2 - (dynamic)Y1, 2)):f2}";
            }
        }
    
}
