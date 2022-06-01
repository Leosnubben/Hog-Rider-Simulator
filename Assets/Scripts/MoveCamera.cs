using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float MouseSens = 20f;

    float xRotation = 0f;

    public Transform PlayerBody;

     void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //låser kameran i mitten av spelet -Ludvig 
    }

    void Update() {
        float MouseX = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime; // gör så du kan flytta musen horizontelt. -Ludvig
        float MouseY = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime; // gör så du kan flytta musen verticalt. -Ludvig

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // clampar rotation så din sens inte blir för hög. -Ludvig

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 

        PlayerBody.Rotate(Vector3.up * MouseX); //roterar kroppen med kameran. -Ludvig
    }
}
