namespace guessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //guessTheNumber

            Random rndNumber = new Random();

            int oneMore = 2;
            int answer = 0;

            for (int i = 1; i >= 0 && oneMore != 0; i++)
            {
                int number = rndNumber.Next(1, 1001);

                Console.WriteLine("Moё чиcлo между 1 и 1000. Вы можете его отгадать?");
                Console.WriteLine("Пожалуйста введите свою первую догадку!");

                for (int q = 1; q >= 0 && answer != number; q++)
                {
                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer < number)
                    {
                        Console.WriteLine("Слишком мало. Попытайтесь снова.");
                    }
                    else if (answer > number)
                    {
                        Console.WriteLine("Слишком много. Попытайтесь снова.");
                    }
                    else
                    {
                        Console.WriteLine("Отлично! Вы отгадали число!");
                    }
                }

                oneMore = 2;

                for (int v = 1; v >= 0 && oneMore != 1; v++)
                {
                    Console.WriteLine("Хотели бы вы сыграть ещё раз?");
                    Console.WriteLine("Введите: 1 - да, 0 - нет");

                    oneMore = Convert.ToInt32(Console.ReadLine());

                    if (oneMore == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}