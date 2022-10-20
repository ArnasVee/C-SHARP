using System;

namespace _2_a_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i=1; i>0; i=i*10)
            //{
            //    Console.WriteLine(i);
            //}
            //int x = 0;
            //while(x<10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;
            //} while (x < 10);


            //int[] skaiciai = new int[2];
            //skaiciai[0] = 3;
            //skaiciai[1] = 5;
            //foreach (var item in new int[5,6])
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("duok skaiciu por favor");
            //int lines = int.Parse(Console.ReadLine());
            //int spaces = lines - 1;
            //int stars = 1;
            //for(int i=0; i<lines; i++)
            //{
            //    for(int y=0; y<spaces; y++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int z=0; z<stars; z++)
            //    {
            //        Console.Write("* ");
            //    }
            //    spaces--;
            //    stars++;
            //    Console.WriteLine();
            //}

            //Uzuodtys:
            //trikampis upside down
            //Rombas
            //fibonacci iki uzduoto skaiciaus (gal net su recursive)

            //Console.WriteLine("Tipo kita uzduotis.....");
            //Console.WriteLine("praleiziam eilute....");
            //Console.WriteLine();


            //Console.WriteLine("duok kita skaiciu por favor");
            //int lines2 = int.Parse(Console.ReadLine());
            //int spaces2 = lines2 - 1;
            //int stars2 = 1;
            //for (int i = 0; i < lines2; i++)
            //{
            //    for (int z = 0; z < stars2; z++)
            //    {
            //        Console.Write("* ");
            //    }
            //    for (int y = 0; y < spaces2; y++)
            //    {
            //        Console.Write(" ");
            //    }

            //    spaces2--;
            //    stars2++;
            //    Console.WriteLine();
            //}

            //MASYVAI
            //int[] skaiciai = new int[5];

            //skaiciai[0] = 15;
            //skaiciai[1] = 26;

            //foreach(int skaitmuo in skaiciai)
            //{
            //    Console.WriteLine(skaitmuo);
            //}


            //SORTINIMO KODAS :

            int[] randomNumbers = new int[] { 5, 2, 9, 8, 1, 10 };
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                for(int x = 0; x <randomNumbers.Length; x++)
                {
                    if (randomNumbers[i] < randomNumbers[x])
                    {
                        int temp = randomNumbers[i];
                        randomNumbers[i] = randomNumbers[x];
                        randomNumbers[x] = temp;
                    }
                }
            }
            for (int i=0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }
            
            //task: printinti tik lyginius skaicius
        }
    }
}
