using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Interactable
{
    [SerializeField] private PlayerUI playerUI;

    // Start is called before the first frame update
    void Start()
    {
        promptMessage = "Podnieœ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        playerUI.UpdateItems();
        Destroy(gameObject);
    }
}
