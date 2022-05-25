using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaconSpawner : MonoBehaviour
{
    public static float timerlimit = 2;
    public GameObject BaconPrefab;
    float timer;  //Fixar timern - Leo
    [SerializeField]
    private GameObject BaconVariant;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerlimit) //Om det har gått längre tid än timern - Leo
        {
            timer = 0;
            GameObject bacon = Instantiate(BaconVariant, new Vector3(Random.Range(0, 20), 2000, Random.Range(0, 20)), BaconVariant.transform.rotation);
            RaycastHit hit;
            Physics.Raycast(bacon.transform.position, -Vector3.up, out hit);
            if (hit.transform != null)
            {
                bacon.transform.position = new Vector3(bacon.transform.position.x, hit.point.y + 1.2f, bacon.transform.position.z);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Score.playscore += 1;
            Destroy(collision.gameObject);
        }
    }
}
