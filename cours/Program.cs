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

            Couleur rouge = Couleur.Rouge;

            if (rouge == Couleur.Rouge)
            {
                Console.WriteLine("La couleur est rouge");
            }


            int[] montablo = new int[] { 14, 18, 39, 45 };

            foreach (int i in montablo) 
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i<montablo.Length; i++)
            {
                Console.WriteLine(montablo[i]);
            }
        }
    }
}
