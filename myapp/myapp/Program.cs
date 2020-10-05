using System;
using System.Collections.Generic;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ville> listeville = new List<ville>();

            Console.WriteLine("Bienvenue dans mon appli de gestion de ville");
            Console.WriteLine("Que voulez vu faire?");

            while (true)
            {
                string choix_util = Menu_util();

                if (choix_util == "1")
                {
                    ville v = createville();
                    listeville.Add(v);
                }
                else if (choix_util == "2")
                {
                    affiche(listeville);
                }
                else if (choix_util == "3")
                {
                    Affiche2(listeville);
                }
                else if (choix_util == "q")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Je n'ai pas compris");
                }
            }
            Console.ReadKey();
        }
        public static string Menu_util()
        {
            string choix_util;
            Console.WriteLine("1.Creer une nouvelle ville");
            Console.WriteLine("2.Afficher l'esemble des villes");
            Console.WriteLine("3.Afficher le nombre total d'habitant");
            Console.WriteLine("q.Quitter");
            choix_util = Console.ReadLine();

            return choix_util;
        }

        public static ville createville()
        {
            ville v = new ville();


            v.nom = demande_prenom();

            v.cp = demande_entier("Code Postal:");

            v.nbh = demande_entier("Nombre D'habitant:");

            return v;

        }


        public static string demande_prenom()
        {
            Console.WriteLine("Nom:");
            string Prenom = Console.ReadLine();


            while (string.IsNullOrEmpty(Prenom))
            {
                Console.WriteLine("Veuillez saisir quelque chose");
                Prenom = Console.ReadLine();
            }

            return Prenom;
        }

        public static int demande_entier(string message)
        {
            Console.WriteLine(message);
            int valeurconverti;
            string entier;
            entier = Console.ReadLine();

           
            while (!(int.TryParse(entier, out valeurconverti) || valeurconverti < 0))
            {
                Console.WriteLine("Entrez un nombre valide svp");
                entier = Console.ReadLine();
            }

            return valeurconverti;
        }

        public static void affiche(List<ville> listeville)
        {
            foreach (ville v in listeville)
            {
                string message;
                message = creer_message(v);
                Console.WriteLine(message);

            }
        }
        public static string creer_message(ville v)
        {
            string message;
           
                message = "Nom: " + v.nom.ToUpper() + "," + " Code Postal: " + v.cp  + "," + "\n" + "Nombre D'habitant: " + v.nbh + "\n" + "------------------------------------------------";

            return (message);
        }

        //Total d'habitant
        public static void Affiche2(List<ville> listeville)
        {
            int nmb_total = 0;

            foreach (ville v in listeville)
            {
                
                nmb_total = nmb_total + v.nbh;

                
                

            }
            Console.WriteLine("Nombre total d'habitant: " + nmb_total);
        }




    }

    
}
