using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeRecapTableau2
{
    class Program
    {
        /// <summary>
        /// Supression d'une case d'un vecteur 
        /// </summary>
        /// <param name="vec">vecteur</param>
        /// <param name="valeur">valeur à supprimer du vecteur</param>
        static void supprVec(string [] vec, string valeur)
        {
            // parcours du vecteur pour trouverla valeur
            int k = 0;
            while (k<vec.Length && vec[k] != valeur)
            {
                k++;
            }

            // controler la sortie ( la valeur a-t-elle été trouvée ?)
            if (vec[k] == valeur)
            {
                for (int j = k; j < vec.Length - 1; j++)
                {
                    vec[j] = vec[j + 1];
                }
                vec[vec.Length - 1] = "";
            }
        }
        static void Main(string[] args)
        {
            // saisie nombre de villes
            Console.Write("Le nombre de villes = ");
            int nb = int.Parse(Console.ReadLine());

            // déclaration du vecteur des villes
            string[] villes = new string[nb];

            // saisie des villes
            for (int k = 0; k < nb; k++)
            {
                Console.Write("La ville n°" + (k + 1) + " : ");
                villes[k] = Console.ReadLine();
            }

            // saisie de la ville à supprimer
            Console.Write("La ville à supprimer : ");
            string ville = Console.ReadLine();

            // tentative de la supression de la ville
            supprVec(villes, ville);

            // recalcul de la taille du vecteur
            int newtaille = nb;
            if(villes[villes.Length - 1] == "")
            {
                newtaille = nb - 1;
            }

            // affichage du vecteur final
            for (int k = 0; k < newtaille; k++)
            {
                Console.WriteLine("la ville n°" + (k + 1) + " : " + villes[k]);
            }
            Console.ReadLine();
        }
    }
}
