//PIRAMIDE

//Console.WriteLine("duok skaiciu por favor");
//int lines = int.Parse(Console.ReadLine());
//int spaces = lines - 1;
//int stars = 1;
//for (int i = 0; i < lines; i++)
//{
//    for (int y = 0; y < spaces; y++)
//    {
//        Console.Write(" ");
//    }
//    for (int z = 0; z < stars; z++)
//    {
//        Console.Write("* ");
//    }
//    spaces--;
//    stars++;
//    Console.WriteLine();
//}
//--------------------------------------------------------
//APVERSTA PIRAMIDE
//Console.WriteLine("duok skaiciu por favor");
//int lines = int.Parse(Console.ReadLine());
//int spaces = 1;
//int stars = lines;
//for(int i=0; i < lines; i++)
//{
//    for(int y=0; y<stars; y++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//    for(int z=0; z<spaces; z++)
//    {
//        Console.Write(" ");
//    }
//    stars--;
//    spaces++;
//}
//--------------------------------------------------------
//ROMBAS
//Console.WriteLine("duok skaiciu por favor");
//int lines = int.Parse(Console.ReadLine());
//int spaces = lines - 1;
//int stars = 1;
//for (int i = 0; i < lines; i++)
//{
//    for (int y = 0; y < spaces; y++)
//    {
//        Console.Write(" ");
//    }
//    for (int z = 0; z < stars; z++)
//    {
//        Console.Write("* ");
//    }
//    spaces--;
//    stars++;
//    Console.WriteLine();
//}
//int spaces2 = 1;
//int stars2 = lines;
//for (int i = 0; i < lines; i++)
//{
//    for (int y = 0; y < stars2; y++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//    for (int z = 0; z < spaces2; z++)
//    {
//        Console.Write(" ");
//    }
//    stars2--;
//    spaces2++;
//}
//--------------------------------------------------------
//MASYVO SORTINIMAS
//int[] randomNumbers = new int[] { 5, 2, 9, 8, 1, 10 };
//for (int i = 0; i < randomNumbers.Length; i++)
//{
//    for (int x = 0; x < randomNumbers.Length; x++)
//    {
//        if (randomNumbers[i] < randomNumbers[x])
//        {
//            int temp = randomNumbers[i];
//            randomNumbers[i] = randomNumbers[x];
//            randomNumbers[x] = temp;
//        }
//    }
//}
//for (int i = 0; i < randomNumbers.Length; i++)
//{
//    Console.WriteLine(randomNumbers[i]);
//}
//--------------------------------------------------------
//TIK LYGINIU SKAICIU SPAUSDINIMAS
//int[] randomNumbers = new int[] { 5, 2, 9, 8, 1, 10 };
//for (int i = 0; i < randomNumbers.Length; i++)
//{
//    int remainder = randomNumbers[i] % 2;
//    if(remainder == 0)
//    {
//        Console.WriteLine(randomNumbers[i]);
//    }
//}
//--------------------------------------------------------
//FIBONACCI IKI UZDUOTO SKAICIAUS
