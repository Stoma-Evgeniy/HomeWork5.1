using System;

namespace HomeWork5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Каждый охотник желает знать где сидит фазан";
            int result = 0;
            char[] glasnie = { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < glasnie.Length; j++)
                {
                    if (glasnie[j] == str[i])
                    {
                        result++;
                    }
                }
            }
                                  
            Console.WriteLine(result);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'а')
                {
                    Console.Write('А'); ;
                }
                else
                {
                    Console.Write(str[i]);
                }
            }

            
        }
    }
}
