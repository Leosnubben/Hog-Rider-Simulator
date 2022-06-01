using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaconMovement : MonoBehaviour
{
    public static float timerlimit = 1;
    float timer;
    [SerializeField]
    float baconSpeed;
    float curve;
    Transform child;

    private void Start()
    {
        child = transform.GetChild(0);
    }

    void Update()
    {
        timer += Time.deltaTime;
        curve = Mathf.Sin(timer * baconSpeed) * 1;
        child.localPosition = new Vector3(0, curve, 0);
        child.Rotate(Vector3.forward, 0.2f);
    }
}
