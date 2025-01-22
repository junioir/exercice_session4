using System.Collections.Generic;
using UnityEngine;

public class Panier : MonoBehaviour
{
    [SerializeField] private List<Fruit> fruitsDansLePanier;  // Liste de fruits dans le panier

    // Ajouter un fruit au panier
    public void AjouterFruit(Fruit fruit)
    {
        fruitsDansLePanier.Add(fruit);
        fruit.transform.SetParent(transform);  // Placer le fruit dans le panier
    }
}
