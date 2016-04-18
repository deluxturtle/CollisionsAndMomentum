using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollisionsAndMomentum
{
    /// <summary>
    /// @Author: Andrew Seba
    /// @Description:
    /// Modeling the reflection of an object off a plane surface.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Lab lab = new Lab();

            do
            {
                Console.Clear();
                Console.WriteLine("1: Reflection");
                Console.WriteLine("2: Collision");

                switch ((int)Convert.ToInt16(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        lab.DoReflection();
                        break;
                    case 2:
                        Console.Clear();
                        lab.DoCollision();
                        break;
                }
            } while (true);
            



        }
    }
}
