using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using TMPro.Examples;
using UnityEngine;

public class Taupe : MonoBehaviour
{
    public bool isTaupeCache = false;

    public int positionActuelle = 0;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        if (isTaupeCache)
        {
            print("Taupe caché !!"); 
        }
        else
        {
            Destroy(gameObject);
            //print("La taupe est KO");
            ScoreScript.AugmenterLeScore();
        }
    }

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        //print("MyCoroutine commence son exécution.");

        yield return new WaitForSeconds(3);

        Destroy(gameObject);
        if(isTaupeCache == false)
        {
            GameManager.Instance.gestionTaupePerdu();
        }
        
        //print("MyCoroutine a terminée son exécution.");
    }
}