using System;
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstValue, SecondValue;
            string action;

            Console.WriteLine("Введите число 1");
            FirstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            SecondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Выбирите опаерацию: '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch(action)
            {
                case"+":
                Console.WriteLine(FirstValue + SecondValue);
                break;
      
                case"-":
                Console.WriteLine(FirstValue - SecondValue);
                break;
                
               
                case"*":
                Console.WriteLine(FirstValue * SecondValue);
                break;
                
              
                case"/":
                if(SecondValue == 0)
                    {
                        Console.WriteLine("на ноль делить нельза");
                    }
                    else
                    {
                        Console.WriteLine(FirstValue / SecondValue);
                    }
                break;
                default:
                Console.WriteLine("Ошибка! неизвестное действие");
                break;
            }
            Console.ReadLine();
        }
    }
}
