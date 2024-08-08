using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d3.Task2
{
    public class Task2
    {
        public enum CarModel
        {
            Sedan=1,
            BMW=2,
            Coupe=3,
            Convertible=4
        }
        public void CarCheck(int number)
        {
            CarModel model = (CarModel)number;
            try
            {
                switch (model)
                {
                    case CarModel.Sedan:
                        Console.WriteLine($"Вы выбрали {model}, отлично подходит для бездорожья и семейных поездок");
                        break;
                    case CarModel.BMW:
                        Console.WriteLine($"Вы выбрали {model}, отлично подходит для бездорожья и семейных поездок");
                        break;
                    case CarModel.Coupe:
                        Console.WriteLine($"Вы выбрали {model}, отлично подходит для бездорожья и семейных поездок");
                        break;
                    case CarModel.Convertible:
                        Console.WriteLine($"Вы выбрали {model}, отлично подходит для бездорожья и семейных поездок");
                        break;
                    default:
                        Console.WriteLine($"Error check");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
