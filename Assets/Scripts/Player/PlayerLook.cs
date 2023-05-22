using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;
    private float yRotation = 0f;
    public float xSensitivity = 0.3f;
    public float ySensitivity = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x * xSensitivity;
        float mouseY = input.y * ySensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation += mouseX;

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.rotation = Quaternion.Euler(0, yRotation, 0);
        // transform.Rotate(Vector3.up * mouseX * Time.deltaTime * xSensitivity);
    }  
}
