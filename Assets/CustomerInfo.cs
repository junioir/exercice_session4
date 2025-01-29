using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomerInfo : MonoBehaviour
       
{

    public TextMeshProUGUI clientInputField;
    public Image client;
    
    public void updateCustomerInfo(string ru)
    {
        clientInputField.text=ru;

    }
}
