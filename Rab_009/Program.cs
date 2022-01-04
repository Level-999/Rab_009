using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rab_009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Смоделируйте работу простого калькулятора.
            //Программа должна запрашивать 2 числа, а затем – код операции
            //(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
            //После этого на консоль выводится ответ.
            //Используйте обработку исключений для защиты от ввода некорректных данных.
            int x=0;
            int y=0;
            int cmd=0;

            try
            {

                Console.WriteLine("Калькулятор");

                Console.Write("Введите целое число Х=");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите целое число Y=");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции:\n      1-сложение \n      2-вычетание \n      3-умножение \n      4-частное");
                Console.WriteLine("Выш выбор");

                cmd = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine("Ошибка ввода. " + ex.Message);
            }


            try
            {

                switch (cmd)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат равен = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат равен = {0}", x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат равен = {0}", x * y);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат равен = {0}", x / y);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Нет операции с указаным номером");
                            break;
                        }

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }






    }




}
