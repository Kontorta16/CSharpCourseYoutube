﻿using System;
using System.Linq;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //ExceptionHandlerMethod();

            Func<int, int, int> sum = Sum;

            //Console.WriteLine(sum(5,6));

            //Func<int> getRandomNumber = delegate ()
            //{
            //    Random random = new Random();
            //    return random.Next(1, 10);
            //};

            Func<int> getRandomNumber = () => new Random().Next(1, 10);

            Console.WriteLine(getRandomNumber());

        }


        public static int Sum(int x, int y)
        {
            return x + y;
        }





        private static void ExceptionHandlerMethod()
        {
            ExceptionHandler(() => { CheckStudent(); });
        }

        private static void ExceptionHandler(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (System.Exception exception)
            {
                throw new System.Exception(exception.Message);
            }
        }

        private static void CheckStudent()
        {
            string[] students1 = { "Ali", "Emircan" };

            if (students1.Contains("Mehmet"))
            {
                Console.WriteLine("İçeriyor");
            }
            else
            {
                throw new RecordNotFoundException("Kayıt yok");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students1 = { "Ali", "Emircan" };
                students1[2] = "Veli";
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Sıfıra Bölünme Hatası");
            }
            catch (System.Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
