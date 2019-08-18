using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
namespace циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                int n = 0;
                while (n < 2)
                {
                    Turtle.Move(20);
                    Turtle.TurnRight();
                    n++;
                }
                int m = 0;
                while (m < 2)
                {
                    Turtle.Move(20);
                    Turtle.TurnLeft();
                    m++;
                }
                i++;
            }
        }
    }
}
