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
        GroundDistance = GetComponent<CharacterController>().bounds.extents.y;

    }

    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal"); //l�gger till knapparna A och D f�r horizontal r�relse. -Ludvig
        float zMovement = Input.GetAxis("Vertical");  //l�gger till W och S som bak�t och fram�t movement. -Ludvig

        Vector3 move = transform.right * xMovement + transform.forward * zMovement;

        cc.Move(move * speed * Time.deltaTime);

        Velocity.y += gravity * Time.deltaTime;

        cc.Move(Velocity * Time.deltaTime);

        if (!Physics.Raycast(transform.position, -Vector3.up, GroundDistance + 0.1f)) //raycast som g�r en groundcheck och kollar om spelaren �r p� marken eller inte. -Ludvig
        {
            isgrounded = false;
        }
        else
        {
            isgrounded = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded) //G�r s� du kan hoppa. -Ludvig
        {
          Velocity  = new Vector3(cc.velocity.x, jumpheight, cc.velocity.z);
        }

    }
}
