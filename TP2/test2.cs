using System; 
using System.Collections.Generic; 
  
public class WayToLearnX { 
  
    // Méthode principale
    public static void Main() 
    {
        // Créer une liste 
        List<string> langages = new List<string>();
        // Ajouter des éléments à la liste 

        


        // Console.WriteLine("Saisie d'une liste ");
        // langages.Add(Console.ReadLine());
        langages.Add("Java");
        langages.Add("Python");
        langages.Add("C#");
        langages.Add("C++");
  
        Console.WriteLine("Nombre d'éléments : {0}", langages.Count);
  
        // Afficher les éléments de la liste
        Console.WriteLine("La liste des langages : "); 
        foreach (string langage in langages) {
            Console.Write(langage + " ");
        }
    } 
}