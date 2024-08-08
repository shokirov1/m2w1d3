using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d3.Task3
{
    public class Task3
    {
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        public void CheckSeason(Season season)
        {
            try
            {
                switch (season)
                {
                    case Season.Winter:
                        Console.WriteLine($"Вы выбрали : {season}");
                        break;
                    case Season.Spring:
                        Console.WriteLine($"Вы выбрали : {season}");
                        break;
                    case Season.Summer:
                        Console.WriteLine($"Вы выбрали : {season}");
                        break;
                    case Season.Autumn:
                        Console.WriteLine($"Вы выбрали : {season}");
                        break;
                    default:
                        Console.WriteLine($"Ошибка: {season} не является допустимым сезоном. Попробуйте еще раз");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
