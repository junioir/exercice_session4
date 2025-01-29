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

        Image clientImage = newEntry.GetComponentInChildren<Image>();
        TMP_Text clientText = newEntry.GetComponentInChildren<TMP_Text>();
        Button deleteButton = newEntry.GetComponentInChildren<Button>();

       //  Debug.LogError("Customer_Img non trouv� !"+clientImage);
      //   Debug.LogError("ClientName non trouv� !"+clientText);
       //  Debug.LogError("button non trouv� !"+deleteButton);


        clientImage.color = new Color(Random.value, Random.value, Random.value); // Couleur al�atoire
        clientText.text = clientName;

        deleteButton.onClick.AddListener(() => Destroy(newEntry));

        clientInputField.text = "";
    }
}
