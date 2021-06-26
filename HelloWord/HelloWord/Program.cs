using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            decimal y = 1.33m; //utilizado para cálculos financeiros (Moeda)
            double z = 1.33; //utilizado para cálculos científicos e medições
            float f = 1.33f; //engines de jogos como Unity devido a performance
            int j = x + 2;

            //strings
            string s = "Olá";
            s += " Mundo!!";
            //arrays
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            int result = 0;
            foreach (int number in a)
            {
                result += number;
            }

            Test t = new Test();
            t.name = "Raqeu";
            string hello = t.SayHello();

            if(t.name == "Luccas")
            {
                Console.WriteLine("Verdadeiro!!!");
            }
            else
            {
                Console.WriteLine("Falso!!!");
            }

            System.Console.WriteLine(hello);
            Console.ReadKey();
        }
    }

    class Test
    {
        public string name;

        public string SayHello()
        {
            return "Ola " + name + " !!!";
        }
    }
}
