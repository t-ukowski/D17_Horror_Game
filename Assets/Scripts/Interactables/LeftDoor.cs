using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoor : Interactable
{
    private bool isOpen = false;
    public float speed = 100f;
    private float rotation;
    private float startRotation;
    private float endRotation;
    // Start is called before the first frame update
    void Start()
    {
        promptMessage = "Otwórz";
        startRotation = gameObject.transform.parent.rotation.eulerAngles.y;
        endRotation = startRotation + 90;
        rotation = startRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            rotation += speed * Time.deltaTime;
            rotation = Mathf.Clamp(rotation, startRotation, endRotation);
            gameObject.transform.parent.rotation = Quaternion.Euler(0, rotation, 0);
        }
        else
        {
            rotation -= speed * Time.deltaTime;
            rotation = Mathf.Clamp(rotation, startRotation, endRotation);
            gameObject.transform.parent.rotation = Quaternion.Euler(0, rotation, 0);
        }
    }

    protected override void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            promptMessage = "Zamknij";
        }
        else
        {
            promptMessage = "Otwórz";
        }
    }
}
