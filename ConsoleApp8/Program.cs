using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 97, 92, 81, 60 };
            /* requete1(scores);
             requete2(scores);*/

            Console.WriteLine("De Quel mot voulez vous savoir la composition?:");
            string valeur = "";
            valeur = Console.ReadLine();
            requete3(valeur);

        }

        static public void requete1(int[] scores)
        {
            var requete = from score in scores
                          where score > 80
                          select score;
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat);
            }
        }

        static public void requete2(int[] scores)
        {
            var requete = from score in scores
                          orderby score ascending
                          select score;
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat);
            }
        }

        static public void requete3(string chaine)
        {

            var requete = from letter in chaine
                          group letter by letter into groupe
                          select new
                          {
                              Lettre = groupe.Key,
                              Nombre = groupe.Count() 
                          };
            foreach (var resultat in requete)
            {
                Console.WriteLine(resultat.Lettre+" : "+resultat.Nombre);
            }

        }


    }
}
