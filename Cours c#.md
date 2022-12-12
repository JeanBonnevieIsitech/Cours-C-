### Questions RPI

```C#
// Décrire le fonctionnement des enums en C#
enum LesJoursDeLaSemaine{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
}

LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;

/* Les enums permettent de définir un ensemble de valeur prédéfini */
```

#### Les Tableaux

```C#
    int[] Tableau; // declaration
    Tab = new int[10]; // Initialisation

    int[] Tableau = new int[] {34, 45, 1, 34, 43 }; //
```

#### Les tableaux multidimensionnels

```C#
    int [,] Tableau = new int[1, 2];
    int [,,] Tableau = new int[1, 2, 3];


    int[][] Tableau = new int[3][];
    Tableau[0] = new int[] {45, 2};
    Tableau[1] = new int[] {34, 34, 4, 67};

    //Expliquez la différence entre ces syntaxes
    /* Ce sont l'instanciation des tableaux qui sont différentes */
    
    //Tentez de parcourir des tableaux multidimensionnels avec des boucles for
    /*
                foreach (int i in montablo) 
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i<montablo.Length; i++)
            {
                Console.WriteLine(montablo[i]);
            }*/
```
