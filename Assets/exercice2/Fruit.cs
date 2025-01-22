using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public abstract class Fruit : MonoBehaviour
{
    [SerializeField] private float vitamineC;  // Contenu en vitamine C du fruit
    [SerializeField] private string fruitName;  // Nom du fruit (Apple, Orange, etc.)

    public float VitamineC => vitamineC;  // Propriété en lecture seule pour la vitamine C
    public string FruitName => fruitName;  // Propriété en lecture seule pour le nom du fruit

    // Fonction qui retourne la vitamine C du fruit
    public virtual float GetEaten()
    {
        return vitamineC;
    }

    // Méthodes abstraites pour afficher le goût
    public abstract void TasteSweet();
    public abstract void TasteBitter();
}


