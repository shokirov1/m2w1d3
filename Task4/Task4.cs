using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d3.Task4
{
    public class Task4
    {
        public enum Planet
        {
            Mercury = 1, 
            Venus = 2, 
            Earth = 3, 
            Mars = 4, 
            Jupiter = 5, 
            Saturn = 6, 
            Uranus = 7, 
            Neptune = 8
        }
        public void CheckPlanet(int number)
        {
            Planet planet = (Planet)number;
            try
            {
                switch (planet)
                {
                    case Planet.Mercury:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    case Planet.Venus:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    case Planet.Earth:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    case Planet.Mars:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    case Planet.Jupiter:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    case Planet.Saturn:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    case Planet.Uranus:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    case Planet.Neptune:
                        Console.WriteLine($"Земля {planet} {number}-я планета от Солнца");
                        break;
                    default:
                        Console.WriteLine($"Ошибка: {number} - недопустимое положение планеты");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
