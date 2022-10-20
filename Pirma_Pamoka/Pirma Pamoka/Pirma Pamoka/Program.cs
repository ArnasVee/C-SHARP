using System;

namespace Pirma_Pamoka
{
    class Program
    {
        static void Main(string[] args)

        
        {
            //string mytext = "6";
            //int sesetas = int.Parse(mytext);
            //string mytext2 = "7";
            //int septynetas = int.Parse(mytext2);

            //Console.WriteLine(sesetas * septynetas);



            //Console.WriteLine("Duok skaiciu");
            //string skaicius1 = Console.ReadLine();
            //int sk1 = int.Parse(skaicius1);
            //Console.WriteLine("Duok dar viena");
            //string skaicius2 = Console.ReadLine();
            //int sk2 = int.Parse(skaicius2);
            //Console.WriteLine(sk1 + sk2);

            //string pirms = Console.ReadLine();
            //string antrs = Console.ReadLine();
            //string calc = Console.ReadLine();
            //int test1 = int.Parse(pirms);
            //int test2 = int.Parse(antrs);

            //if (calc == "+")
            //{
            //    Console.WriteLine(test1 + test2);
            //}
            //else if (calc == "*")
            //{

            //}




            //Console.WriteLine("Koks Tavo vardas?");
            //string vardas = Console.ReadLine();

            //if (vardas == "Arnas")
            //{
            //    Console.WriteLine("Ka velnias " + vardas);
            //}
            //else
            //{
            //    Console.WriteLine("Zdare " + vardas);
            //}

            //Console.WriteLine("Sveikas " + vardas);



            //Console.WriteLine("Kokia snd diena?");
            //string SavaitesDiena = Console.ReadLine();
            //switch (SavaitesDiena)
            //{
            //    case "Pirmadienis":
            //        Console.WriteLine("Labai blogai");
            //        break;
            //    case "Antradienis":
            //        Console.WriteLine("vistiek blogai");
            //        break;
            //    case "Penktadienis":
            //    case "Sestadienis":
            //        Console.WriteLine("Baisiai gerai");
            //        break;
            //    default:
            //        Console.WriteLine("Beleka");
            //        break;
            //}

            int rezultats = Sudetis(5, 9);
            SpausdintiAntEkrano(rezultats);
            
        }

        static int Sudetis(int pirms, int antrs)
        {
            return pirms + antrs;
        }

        static int Sudetis(int pirms, int antrs, int trecs)
        {
            return pirms + antrs + trecs;
        }
        static void SpausdintiAntEkrano(object tekstas)
            {
                Console.WriteLine(tekstas);
            }
    }
}

