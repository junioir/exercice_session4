using UnityEngine;

public class Miner : Worker
{
    void Start()
    {
        ressourceManager = FindObjectOfType<RessourceManager>();
        SetRessourceManager(ressourceManager);
    }

    public override void Work()
    {
        base.Work();  // Consommer de la nourriture
        ressourceManager.AddOre(_production);  // Ajouter du minerai en fonction de la production du Miner
    }
}
