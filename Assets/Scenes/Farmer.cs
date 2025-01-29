using UnityEngine;

public class Farmer : Worker
{
    void Start()
    {
        ressourceManager = FindObjectOfType<RessourceManager>();
        SetRessourceManager(ressourceManager);
    }

    public override void Work()
    {
        base.Work();  // Consommer de la nourriture
        ressourceManager.AddFood(_production);  // Ajouter de la nourriture en fonction de la production du Farmer
    }
}
