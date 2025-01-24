using System.Collections.Generic;
using UnityEngine;

public class CompteurDeFruits : MonoBehaviour
{
    public enum Fruit
    {
        Pomme,
        Banane,
        Orange,
        Raisin,
        Mangue,
        Ananas
    }

    [SerializeField] private List<Fruit> listeDeFruits = new List<Fruit>();

    void Start()
    {
        Dictionary<Fruit, int> compteFruits = new Dictionary<Fruit, int>();

        foreach (Fruit fruit in System.Enum.GetValues(typeof(Fruit)))
        {
            compteFruits[fruit] = 0;
        }

        foreach (Fruit fruit in listeDeFruits)
        {
            if (compteFruits.ContainsKey(fruit))
            {
                compteFruits[fruit]++;
            }
        }

        foreach (var entree in compteFruits)
        {
            Debug.Log($"{entree.Key}: {entree.Value}");
        }
    }
}
