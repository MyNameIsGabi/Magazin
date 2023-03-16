using System;

namespace GestiuneMagazin
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazin magazin = new Magazin();
            int choice;

            do
            {
                Console.WriteLine("1. Adauga aliment");
                Console.WriteLine("2. Modifica aliment");
                Console.WriteLine("3. Sterge aliment");
                Console.WriteLine("4. Afiseaza aliment");
                Console.WriteLine("5. Cauta aliment");
                Console.WriteLine("6. Iesire");

                Console.Write("Alege optiunea: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        magazin.AdaugaAliment();
                        break;
                    case 2:
                        magazin.ModificaAliment();
                        break;
                    case 3:
                        magazin.StergeAliment();
                        break;
                    case 4:
                        magazin.AfiseazaAliment();
                        break;
                    case 5:
                        magazin.CautaAliment();
                        break;
                    case 6:
                        Console.WriteLine("Iesire din program...");
                        break;
                    default:
                        Console.WriteLine("Optiune invalida, incearca din nou.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 6);
        }
    }
}
