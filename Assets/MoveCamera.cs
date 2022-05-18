using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float MouseSens = 100f;

    float xRotation = 0f;

    public Transform PlayerBody;

     void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //låser kameran i mitten av spelet -Ludvig 
    }

    void Update() {
        float MouseX = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        PlayerBody.Rotate(Vector3.up * MouseX);
    }
}
