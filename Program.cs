using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 0.2, q = 0.7;
            double[,] two = new double[,] { {(1 - p), p }, {q, (1 - q) } };
            double[,] three = new double[,] { { 0.9, 0.075, 0.025 }, { 0.15, 0.8, 0.05 }, { 0.25, 0.25, 0.5 } };
            double[,] five = new double[,] { { 0.2, 0.2, 0.2, 0.2, 0.2},
                                                { 0.05, 0.15, 0.25, 0.35, 0.2},
                                                { 0.13, 0.27, 0.48, 0.01, 0.11},
                                                { 0.42, 0.08, 0.25, 0, 0.25},
                                                { 0.14, 0.16, 0.3, 0.25, 0.15} };
            double[,] four = new double[,] { { 0.25, 0.25, 0.25, 0.25 },
                                                { 0.25, 0.25, 0.25, 0.25},
                                                { 0.25, 0.25, 0.25, 0.25},
                                                { 0.25, 0.25, 0.25, 0.25} };
            double[,] second = new double[,] { { (1 - p), q }, { p, (1 - q) } };

            Markov(two, 2);
            Markov(three, 3);
            Markov(five, 5);
            Markov(four, 4);
            Markov(second, 2);
        }

        //modified/enhanced code for part c

        public static void Markov(double[,] chain, int n)
        {
            double sum = 0;
            bool row = true, column = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += chain[i, j];
                }
                if (sum != 1)
                {
                    row = false;
                }
                sum = 0;
            }
            if (row)
                Console.WriteLine("This " + n + "x" + n + " matrix does follow Markov's row chain.\n");
            else
                Console.WriteLine("This " + n + "x" + n + " matrix does not follow Markov's row chain.\n");

            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    sum += chain[l, k];
                }
                if (sum != 1)
                {
                    Console.WriteLine("This " + n + "x" + n + " matrix does not follow Markov's column chain.\n");
                    column = false;
                    return;
                }
                sum = 0;
            }
            if (column)
                Console.WriteLine("This " + n + "x" + n + " matrix does follow Markov's column chain.\n");
            return;
        }

        // code from part a

        //public static void Markov(double[,]chain, int n)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            sum += chain[i, j];
        //        }
        //        if (sum != 1)
        //        {
        //            Console.WriteLine("This " + n + "x" + n + " matrix does not follow Markov's chain.\n");
        //            return;
        //        }
        //        sum = 0;
        //    }
        //    Console.WriteLine("This " + n + "x" + n + " matrix does follow Markov's chain.\n");
        //    return;
        //}
    }
}
