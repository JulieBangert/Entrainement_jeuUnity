using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public static TextMeshProUGUI score; // déclare variable Text que j'appelle score. cette variable = objet qui a des propriétés, fonctions, variable


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        
    }

    public static void AugmenterLeScore()
    {
        scoreValue +=1 ;
        score.text = "Score: " + scoreValue; //text est de type string et existe dans l'objet 'Text"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
