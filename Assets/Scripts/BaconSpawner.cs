using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaconSpawner : MonoBehaviour
{
    public static float timerlimit = 2;  //Limit på 2 sekunder - Leo
    public GameObject BaconPrefab;
    float timer;  //Fixar timern - Leo
    [SerializeField]
    private GameObject BaconVariant;

    private void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            SpawnBacon();   //Spawnar 500 bacon i början av spelet - Leo
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerlimit) //Om det har gått längre tid än timern - Leo
        {
            timer = 0;
            SpawnBacon();  //Resettar timern och spawnar en bacon - Leo
        }
    }

    void SpawnBacon()
    {
        GameObject bacon = Instantiate(BaconVariant, new Vector3(Random.Range(0, 600), 2000, Random.Range(0, 600)), BaconVariant.transform.rotation);   //Spawnar en bacon mellan 0 & 600 x/y, högt upp i luften - Leo
        RaycastHit hit;  
        Physics.Raycast(bacon.transform.position, -Vector3.up, out hit);  //Kör en raycast - Leo
        if (hit.transform != null)
        {
            bacon.transform.position = new Vector3(bacon.transform.position.x, hit.point.y + 1.5f, bacon.transform.position.z);  //Skickar ner baconen i marken och sen skickas baconen upp lite - Leo
        }
        else
        {
            Destroy(gameObject);  //Om det inte finns någon mark sån förstörs baconen - Leo
        }
    }
}
