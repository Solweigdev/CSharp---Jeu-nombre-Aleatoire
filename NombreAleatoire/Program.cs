using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Déclaration des constantes
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 10;
            const int NOMBRE_DE_VIES = 3;

            // Déclaration des variables
            int nombreMagique = random.Next(MIN_VALUE, MAX_VALUE);
            int nombreDeVies = 0;
            

            for (nombreDeVies = NOMBRE_DE_VIES; nombreDeVies > 0; nombreDeVies--)
            {
                Console.WriteLine("Devinez un nombre magique (" + nombreDeVies + " vies restant) entre " + MIN_VALUE + " et " + MAX_VALUE);
                String resultat = Console.ReadLine();

                int nombreUtilisateur = 0;
                if (int.TryParse(resultat, out nombreUtilisateur))
                {
                    if (nombreUtilisateur >= MIN_VALUE || nombreUtilisateur <= MAX_VALUE)
                    {
                        // La conversion s'est bien passée

                        if (nombreUtilisateur < nombreMagique)
                        {
                            Console.WriteLine("Le nombre est magique est plus grand !");
                        }
                        else if (nombreUtilisateur > nombreMagique)
                        {
                            Console.WriteLine("Le nombre est magique est plus petit !");
                        }
                        else
                        {
                            Console.WriteLine("BRAVO !");
                            break;
                        }
                    } else
                    {
                        Console.WriteLine("ERREUR: Vous devez entrer un nombre entre " + MIN_VALUE + " et " + MAX_VALUE + ".");
                        nombreDeVies++;
                    }
                    Console.WriteLine("");
                }
                else
                {
                    // Erreur de la conversion
                    Console.WriteLine("ERREUR: Vous devez entrer un nombre.");
                }

            }
            if (nombreDeVies == 0)
            {
                Console.WriteLine("Désolé, vous avez perdu ! Le nombre magique était " + nombreMagique);
            }
            // Pour garder la fenetre ouverte
            Console.ReadLine();
        }
    }
}
