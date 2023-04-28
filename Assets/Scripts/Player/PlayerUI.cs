using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI itemsText;
    private int itemsCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdatePrompt(string promptMessage)
    {
        promptText.text = promptMessage;
    }

    public void UpdateItems()
    {
        itemsCollected++;
        string text = itemsCollected + "/6";
        itemsText.text = text;
    }
}
