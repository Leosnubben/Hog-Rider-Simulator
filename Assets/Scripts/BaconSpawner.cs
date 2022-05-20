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
            Instantiate(BaconVariant, new Vector3(Random.Range(0, 0.5f), 0.5f, Random.Range(0, 20)), BaconVariant.transform.rotation);
        }
    }
}
