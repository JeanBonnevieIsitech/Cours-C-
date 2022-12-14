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

/* Une Enumeration permet de définir un ensemble de valeur prédéfini */
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
    /* C'est l'instanciation des tableaux qui est différente */
    
    //Tentez de parcourir des tableaux multidimensionnels avec des boucles for
    

```

(Voir cours/Program.cs) 

# Questions API
### Qu'es qu'un ORM ?
Un orm est un outil de programmation (framework) qui permet de traduire des objet d'un language de programmation dans une base de donnée

Concrètement cela permet de convertir une class en table de manière transparente pour le programmeur
