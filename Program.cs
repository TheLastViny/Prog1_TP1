using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Données de travail
            int nombre1 = 0;
            int nombre2 = 0;
            int erreur = 0;
            


            //Mot de bienvenue
            Console.WriteLine("##############################################################");
            Console.WriteLine("### Bienvenue dans le programme pour tester vos additions! ###");
            Console.WriteLine("##############################################################\n\n");

            //Entrée des nombres par l'utilisateur
            Console.Write("Veuillez entrer votre premier nombre : ");
            nombre1 = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Veuillez entrer votre second nombre : ");
            nombre2 = Convert.ToInt32(Console.ReadLine());

            //Boucle pour faires les additons
            

            for (int i = 1; i <= 15; i++)
            
            {
                //L'utilisateur fait la somme des deux nombres et le programme le fait ausi pour pouvoir comparer
                Console.WriteLine("Veuillez faire l'addition de {0} et {1} : " ,nombre1, nombre2);
                int add = Convert.ToInt32(Console.ReadLine());
                int somme = nombre1 + nombre2;
                //Compare le résultat entre l'utilisateur et le programme si les 2 sont égaux ça additionne le nombre 1 au nombre 2 aussi non il ajoute un erreur.
                if (somme == add)
                {
                    nombre1 += nombre2;
                }
                else
                {
                    erreur++;
                }
              
                  }

            Console.WriteLine("Vous avez fait {0} erreur.",erreur);

            Console.ReadKey();
        }
    }
}
