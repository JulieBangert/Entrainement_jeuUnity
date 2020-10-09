using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net;
using System.Runtime.InteropServices;
using UnityEngine;

public class TaupeSpawnerScript : MonoBehaviour
{
    public GameObject[] taupe;
    public Transform[] spawnPoint;

    private int rand;
    private int randPosition;
    
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

   

    private void Update()
    {

        if (GameManager.Instance.isJeuEnCours)
        {

            Taupe[] taupes = GameObject.FindObjectsOfType<Taupe>();

            if(taupes.Length == spawnPoint.Length)
            {
                Debug.Log("PLUS DE PLACE !!");
                return;
            }

            if (timeBtwSpawns <= 0)
            {
                rand = UnityEngine.Random.Range(0, taupe.Length);

                bool isPositionLibre = false;

                while(isPositionLibre == false)
                {

                    Debug.Log("Pas de position libre !");

                    randPosition = UnityEngine.Random.Range(0, spawnPoint.Length);

                    //Tu boucles sur toutes les taupes pour vérifier si randPosition est déjà existant dans une des taupes

                    

                    isPositionLibre = true;

                    foreach (Taupe taupe in taupes)
                    {
                        if(taupe.positionActuelle == randPosition)
                        {
                            isPositionLibre = false;
                        }
                    }
                }






                GameObject Taupe = Instantiate(taupe[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
                Taupe.GetComponent<Taupe>().positionActuelle = randPosition;
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }

           
         

        
        
    }
    
}
