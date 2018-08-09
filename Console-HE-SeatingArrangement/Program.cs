using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_HE_SeatingArrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ops = new List<string>();
            for (int i = 0; i < n; i++)
            {
                int[] ws = new int[] { 1, 6, 7, 12 };
                int[] ms = new int[] { 2, 5, 8, 11 };
                int s = int.Parse(Console.ReadLine());
                int f = s / 12;
                int of = s % 12;
                if (of == 0)
                {
                    f -= 1;
                    of = 12;
                }
                string op = (f * 12 + (13 - of)).ToString() + " ";
                if (ws.Contains(of))
                {
                    op += "WS";
                }
                else if (ms.Contains(of))
                {
                    op += "MS";
                }
                else
                {
                    op += "AS";
                }
                ops.Add(op);
            }
            Console.Write(string.Join("\n", ops));
        }
    }
}
