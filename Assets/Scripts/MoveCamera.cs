using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float MouseSens = 20f;

    float xRotation = 0f;

    public Transform PlayerBody;

     void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //l�ser kameran i mitten av spelet -Ludvig 
    }

    void Update() {
        float MouseX = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime; // g�r s� du kan flytta musen horizontelt. -Ludvig
        float MouseY = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime; // g�r s� du kan flytta musen verticalt. -Ludvig

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // clampar rotation s� din sens inte blir f�r h�g. -Ludvig

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 

        PlayerBody.Rotate(Vector3.up * MouseX); //roterar kroppen med kameran. -Ludvig
    }
}
