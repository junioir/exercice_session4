using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class ClientListManager : MonoBehaviour
{
    public TMP_InputField clientInputField; 
    public Transform clientListContainer;
    public GameObject clientEntryPrefab;

    private void Start()
    {
        clientInputField.onEndEdit.AddListener(AddClient);
    }

    void AddClient(string clientName)
    {
        if (string.IsNullOrWhiteSpace(clientName)) return;

        GameObject newEntry = Instantiate(clientEntryPrefab, clientListContainer);
        newEntry.transform.SetAsFirstSibling(); // Ajoute en haut de la liste

        Image clientImage = newEntry.transform.Find("Customer_Img")?.GetComponent<Image>();
        TMP_Text clientText = newEntry.transform.Find("ClientName")?.GetComponent<TMP_Text>();
        Button deleteButton = newEntry.transform.Find("Button")?.GetComponent<Button>();

        if (clientImage == null) Debug.LogError("Customer_Img non trouv� !");
        if (clientText == null) Debug.LogError("ClientName non trouv� !");
        if (deleteButton == null) Debug.LogError("button non trouv� !");



        clientImage.color = new Color(Random.value, Random.value, Random.value); // Couleur al�atoire
        clientText.text = clientName;

        deleteButton.onClick.AddListener(() => Destroy(newEntry));

        clientInputField.text = "";
    }
}
