using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private List<Fruit> fruits;  // Liste de fruits � manger
    [SerializeField] private float vitamineC = 0f; // Quantit� de vitamine C de l'humain

    [SerializeField] private GameObject panier;  // R�f�rence au panier (UI ou objet 3D dans Unity)

    // Fonction pour manger un fruit
    public void EatAFruit()
    {
        if (fruits.Count > 0)
        {
            Fruit fruitToEat = fruits[0];  // On mange le premier fruit de la liste
            Debug.Log(fruitToEat.FruitName + " a �t� mang�!");
            vitamineC += fruitToEat.GetEaten();  // Ajouter la vitamine C du fruit � l'humain
            Destroy(fruitToEat.gameObject);  // D�truire le fruit (supprimer de la sc�ne)
            fruits.RemoveAt(0);  // Enlever le fruit de la liste
        }
        else
        {
            Debug.Log("Il n'y a plus de fruits � manger.");
        }
    }

    // Affichage de la vitamine C actuelle de l'humain
    public void AfficherVitamineC()
    {
        Debug.Log("L'humain a " + vitamineC + " unit�s de vitamine C.");
    }
}
