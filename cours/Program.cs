using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cours
{
    internal class Program
    {
        enum Couleur
        {
            Rouge,
            Vert,
            Bleu
        }


        static void Main(string[] args)
        {
            // Enum
            Couleur rouge = Couleur.Rouge;

            if (rouge == Couleur.Rouge)
            {
                Console.WriteLine("La couleur est rouge");
            }

            // Tableau mono dimension
            int[] montablo = new int[] { 14, 18, 39, 45 };

            foreach (int i in montablo) 
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i<montablo.Length; i++)
            {
                Console.WriteLine(montablo[i]);
            }

            // Tableau multi dimension

            int[][] Tableau = new int[3][];
            Tableau[0] = new int[] { 45, 2 };
            Tableau[1] = new int[] { 34, 34, 4, 67 };

            // parcour des tableaux

            for (int i=0; i < Tableau.Length; i++)
            {
                for (int j=0;j< Tableau[i].Length; j++)
                {
                    Console.WriteLine(Tableau[i][j]);
                }
            }


        }
    }
}
