 using System;

namespace _7a_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
                      

            Books altoriuSeslis = new Books("156-156-4444");
            altoriuSeslis.Title = "Altoriu Seslis";
            altoriuSeslis.PageCount = 535;
            altoriuSeslis.PublishDate = new DateTime(1995,02,14);
            altoriuSeslis.Author = new Author() { FirstName = "Tomas", LastName = "Pavardenis"};
            altoriuSeslis.Genre = Genre.Thriller;

            Books karasIrTaika = new Books("198-173-2222");
            karasIrTaika.Title = "Karas Ir Taika";
            karasIrTaika.PageCount = 599;
            karasIrTaika.PublishDate = new DateTime(1955, 08, 09);
            karasIrTaika.Author = new Author() { FirstName = "Gorgio", LastName = "Moroder" };
            karasIrTaika.Genre = Genre.Fantasy;



            Library viesojiBiblioteka = new Library(Address.GetCentrineBiblioteka());

            viesojiBiblioteka.Books.Add(altoriuSeslis);
            viesojiBiblioteka.Books.Add(karasIrTaika);

            foreach(var item in viesojiBiblioteka.Books)
            {
                Console.WriteLine(item.Title);
            }

            


            //Books BrisiausGalas = new Book();
            //Books GirlOnTrain = new Book();
            //Books KarasIrTaika = new Book();





        }
    }
}
