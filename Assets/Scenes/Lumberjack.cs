using UnityEngine;

public class Lumberjack : Worker
{
    void Start()
    {
        ressourceManager = FindObjectOfType<RessourceManager>();
        SetRessourceManager(ressourceManager);
    }

    public override void Work()
    {
        base.Work();  // Consommer de la nourriture
        ressourceManager.AddWood(_production);  // Ajouter du bois en fonction de la production du Lumberjack
    }
}
