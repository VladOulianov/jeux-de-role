using System;


namespace jeux_de_role
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            Monstre monstre = new Monstre("loup enragé");
            bool victoire = true;
            bool suivant = false;

            while (!monstre.EstMort())
            {
                // tour du monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                if (monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }

                // tour du Perso
                Console.ForegroundColor = ConsoleColor.Green;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);
            }
            if (victoire)
            {
                monPerso.gagnerExperience(5);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine(monPerso.Caracteristiques());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                while (!suivant)
                {
                    Console.WriteLine("Salle suivante ? (O/N)");
                    string saisie = Console.ReadLine().ToUpper();
                    if (saisie == "O")
                    {
                        suivant = true;
                        Jouer(monPerso);
                    }
                    else if (saisie == "N")
                    {
                        Environment.Exit(0);
                    }

                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("Vous etes MORT...");
                Console.ReadKey();
            }
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Le jeu");
            Console.WriteLine();
            Console.WriteLine("Choisis ta classe : ");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Sorcier");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();
            Console.WriteLine();


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis de jouer le Guerrier Gabur !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Gabur"));
                    break;

                case "2":
                    Console.WriteLine("Vous avez choisis de jouer la Sorciere Milouna !");
                    Console.WriteLine();
                    Jouer(new Sorcier("Milouna"));
                    break;

                case "3":
                    Console.WriteLine("Vous avez choisis de jouer l'Archer Triton !");
                    Console.WriteLine();
                    Jouer(new Archer("Triton"));
                    break;

                case "4":
                    break;

            }
        }
    }
}
