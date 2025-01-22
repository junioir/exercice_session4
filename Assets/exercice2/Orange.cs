using UnityEngine;

public class Orange : Fruit
{
    [SerializeField] private bool hasPeel = true;  // Si l'orange a une pelure

    public override void TasteSweet()
    {
        Debug.Log("Yummy");
    }

    public override void TasteBitter()
    {
        Debug.Log("Yuck");
    }

    public void SquirtJuice()
    {
        Debug.Log("What a mess!");
    }

    public override float GetEaten()
    {
        // Si l'orange a une pelure, on affiche le goût amer, sinon le goût sucré
        if (hasPeel)
        {
            TasteBitter();
        }
        else
        {
            TasteSweet();
        }

        SquirtJuice();
        return base.GetEaten();  // Retourne la vitamine C de l'orange
    }
}
