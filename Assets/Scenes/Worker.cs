using System.Resources;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public int _production; // Production spécifique pour chaque type de travailleur
    protected RessourceManager ressourceManager;

    // Fonction de travail
    public virtual void Work()
    {
        ressourceManager.ConsumeFood(1);  // Consommer 1 nourriture par jour de travail
    }

    // Lier le gestionnaire de ressources
    public void SetRessourceManager(RessourceManager manager)
    {
        ressourceManager = manager;
    }
}
