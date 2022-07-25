string solution, ValeurUser, NewSolution;
int LettresRestantes = 0;
float NbrErreurs = 0;
bool aTrouver = false;
bool aPerdu = false;

//Création de la liste de solutions possibles
List<string> animaux = new List<string>{"lapin", "loup"};

//Création de la fonction random
Random rnd = new Random();

//Choix de la solution qu'on met dans la string solution
solution = animaux[rnd.Next(animaux.Count)];
LettresRestantes = solution.Count();

Console.WriteLine("Bienvenu dans ce pendu !");
Console.WriteLine("Ton but ici sera de trouver le bon mot ! Bonne chance !");
    Console.WriteLine("Commence par essayer de trouver une lettre présente dans le mot !");

while (!aTrouver && !aPerdu)
{
    ValeurUser = Convert.ToString(Console.ReadLine());
    ValeurUser = ValeurUser.ToLower();
    Console.WriteLine("Ta lettre est donc " + ValeurUser + " !");


    if (solution.Contains(ValeurUser))
    {
        LettresRestantes--;
        Console.WriteLine("Bravo ! La lettre " + ValeurUser + " est dans la solution !");
        NewSolution = solution.Replace(ValeurUser, "");
        Console.WriteLine("Continue comme ça !");
    }

    else
    {       
        Console.WriteLine("Mmmh...Raté ! Réessaie...");
        NbrErreurs++;
        Console.WriteLine("Ton nombre d'erreurs est donc à " + NbrErreurs + "/5");
        Console.WriteLine("Réessaie avec une autre lettre !");
    }

    if(LettresRestantes == 0)
    {
        aTrouver=true;
    }

    if(NbrErreurs == 5)
    {
        aPerdu = true;
    }
}

if(aTrouver == true)
{
    Console.WriteLine("Bravo tu as réussi à trouver le mot " + solution + " ! Relance le script pour rejouer !");
}

if(aPerdu == true)
{
    Console.WriteLine("Tu as perdu ! Le mot était " + solution + "...Réessaie une prochaine fois !");
}