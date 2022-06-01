using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int playscore;
    public Text scoretext;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Bacon " + (playscore).ToString();  //Den skriver bacon och sen den poängen man har - Leo
    }
}
