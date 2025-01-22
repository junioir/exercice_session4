using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private List<Fruit> fruits;  // Liste de fruits à manger
    [SerializeField] private float vitamineC = 0f; // Quantité de vitamine C de l'humain

    [SerializeField] private GameObject panier;  // Référence au panier (UI ou objet 3D dans Unity)

    // Fonction pour manger un fruit
    public void EatAFruit()
    {
        if (fruits.Count > 0)
        {
            Fruit fruitToEat = fruits[0];  // On mange le premier fruit de la liste
            Debug.Log(fruitToEat.FruitName + " a été mangé!");
            vitamineC += fruitToEat.GetEaten();  // Ajouter la vitamine C du fruit à l'humain
            Destroy(fruitToEat.gameObject);  // Détruire le fruit (supprimer de la scène)
            fruits.RemoveAt(0);  // Enlever le fruit de la liste
        }
        else
        {
            Debug.Log("Il n'y a plus de fruits à manger.");
        }
    }

    // Affichage de la vitamine C actuelle de l'humain
    public void AfficherVitamineC()
    {
        Debug.Log("L'humain a " + vitamineC + " unités de vitamine C.");
    }
}
