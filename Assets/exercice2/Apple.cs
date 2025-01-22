using UnityEngine;

public class Apple : Fruit
{
    public override void TasteSweet()
    {
        Debug.Log("Yummy");
    }

    public override void TasteBitter()
    {
        Debug.Log("Yuck");
    }

    // Fonction pour émettre un bruit de croquant
    public void EmitCrunchNoise()
    {
        Debug.Log("CRUNCH");
    }

    public override float GetEaten()
    {
        EmitCrunchNoise();  // Bruit de croquant
        TasteSweet();  // Goût sucré pour la pomme
        return base.GetEaten();  // Retourne la vitamine C de la pomme
    }
}
