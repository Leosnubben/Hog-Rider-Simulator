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

    private void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            SpawnBacon();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerlimit) //Om det har gått längre tid än timern - Leo
        {
            timer = 0;
            SpawnBacon();
        }
    }

    void SpawnBacon()
    {
        GameObject bacon = Instantiate(BaconVariant, new Vector3(Random.Range(0, 600), 2000, Random.Range(0, 600)), BaconVariant.transform.rotation);
        RaycastHit hit;
        Physics.Raycast(bacon.transform.position, -Vector3.up, out hit);
        if (hit.transform != null)
        {
            bacon.transform.position = new Vector3(bacon.transform.position.x, hit.point.y + 1.5f, bacon.transform.position.z);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
