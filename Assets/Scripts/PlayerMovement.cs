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
        float xMovement = Input.GetAxis("Horizontal"); //lägger till knapparna A och D för horizontal rörelse. -Ludvig
        float zMovement = Input.GetAxis("Vertical");  //lägger till W och S som bakåt och framåt movement. -Ludvig

        Vector3 move = transform.right * xMovement + transform.forward * zMovement;

        cc.Move(move * speed * Time.deltaTime);

       Velocity.y += gravity * Time.deltaTime;

        Velocity.y = Mathf.Clamp(0, -1, -9);// stoppar velocity y från att överskrida -9 i gravitation. - lUdvig

        cc.Move(Velocity * Time.deltaTime);

        if (!Physics.Raycast(transform.position, Vector3.up, GroundDistance + 0.1f)) //raycast som gör en groundcheck och kollar om spelaren är på marken eller inte. -Ludvig
        {
            isgrounded = true;
        }
        else
        {
            isgrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded) //Gör så du kan hoppa. -Ludvig
        {
          Velocity  = new Vector3(cc.velocity.x, jumpheight, cc.velocity.z);
        }

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Bacon")
        {
            Score.playscore += 1;
            Destroy(hit.gameObject);    //Om man kör in i en bacon så förstörs den och lägger till poäng - Leo
        }
    }
}
