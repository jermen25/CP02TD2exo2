using System;

namespace CP02TD2exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int nbStagiaire = 3;
            int taille, poids, maxTaille = 0, maxPoids = 0;

            Console.WriteLine("Saisie des données");
            for(int i=1; i <= nbStagiaire; i++)
            {   //saisie de la taille et du poids
                Console.WriteLine("Stagiaire n° " + i);
                Console.Write("taille (cm) : ");
                taille = int.Parse(Console.ReadLine());
                Console.Write("poids (kg) : ");
                poids = int.Parse(Console.ReadLine());

                //recherche des maxima
                if (maxTaille < taille)
                {
                    maxTaille = taille;
                }

                if (maxPoids < poids)
                {
                    maxPoids = poids;
                }
                Console.WriteLine(" le poids maximum est de " + maxPoids + " et la taille maximum est de " + maxTaille + " cm");

            }
        }
    }
}
