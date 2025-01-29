using UnityEngine;

public class RessourceManager : MonoBehaviour
{
    public int food = 100;
    public int wood = 0;
    public int ore = 0;

    // Fonction pour consommer de la nourriture
    public void ConsumeFood(int amount)
    {
        food -= amount;
        if (food < 0) food = 0;  // Empêcher que la nourriture devienne négative
    }

    // Ajouter des ressources spécifiques
    public void AddFood(int amount)
    {
        food += amount;
    }

    public void AddWood(int amount)
    {
        wood += amount;
    }

    public void AddOre(int amount)
    {
        ore += amount;
    }

    // Fonction appelée par le bouton "End work day"
    public void SpendDayOfWork()
    {
        foreach (var worker in GetComponentsInChildren<Worker>())
        {
            worker.Work();
        }

        // Afficher les nouvelles ressources à l'écran
        UpdateUI();
    }

    // Mettre à jour l'UI pour afficher les nouvelles ressources
    private void UpdateUI()
    {
        // Utilise tes éléments d'UI pour afficher les nouvelles ressources (ex. TextMeshPro)
        // Exemple :
        // foodText.text = "Food: " + food.ToString();
        // woodText.text = "Wood: " + wood.ToString();
        // oreText.text = "Ore: " + ore.ToString();
    }
}
