using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    public float jumpheight = 3f;

    public CharacterController cc;

    public float gravity = -9.81f;

    Vector3 Velocity;

    public float GroundDistance;

    public bool isgrounded = false;

    void Start()
    {
        GroundDistance = GetComponent<CharacterController>().bounds.extents.y; //referens till charactercontroller. -Ludvig

    }

    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal"); //l�gger till knapparna A och D f�r horizontal r�relse. -Ludvig
        float zMovement = Input.GetAxis("Vertical");  //l�gger till W och S som bak�t och fram�t movement. -Ludvig

        Vector3 move = transform.right * xMovement + transform.forward * zMovement;

        cc.Move(move * speed * Time.deltaTime);

       Velocity.y += gravity * Time.deltaTime;

        Velocity.y = Mathf.Clamp(0, -1, -9);// stoppar velocity y fr�n att �verskrida -9 i gravitation. - lUdvig

        cc.Move(Velocity * Time.deltaTime);

        if (!Physics.Raycast(transform.position, Vector3.up, GroundDistance + 0.1f)) //raycast som g�r en groundcheck och kollar om spelaren �r p� marken eller inte. -Ludvig
        {
            isgrounded = true;
        }
        else
        {
            isgrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded) //G�r s� du kan hoppa. -Ludvig
        {
          Velocity  = new Vector3(cc.velocity.x, jumpheight, cc.velocity.z);
        }

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Bacon")
        {
            Score.playscore += 1;
            Destroy(hit.gameObject);    //Om man k�r in i en bacon s� f�rst�rs den och l�gger till po�ng - Leo
        }
    }
}
