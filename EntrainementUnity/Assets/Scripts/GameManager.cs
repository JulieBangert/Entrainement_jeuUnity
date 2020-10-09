using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    public bool isJeuEnCours = true;

    public int taupeMaxPourDefaite = 5;

    public int compteurTaupePerdu = 0;

    public void gestionTaupePerdu()
    {
        compteurTaupePerdu++;

        Debug.LogWarning("moins 1");

        if(compteurTaupePerdu >= taupeMaxPourDefaite)
        {      
            gestionJeuPerdu();
        }
    }

    private void gestionJeuPerdu()
    {
        if (isJeuEnCours == true)
        {
            isJeuEnCours = false;

            Debug.Log("GAME OVER !");

            //Jouer un son
            GetComponent<AudioSource>().Play();
        }
        //Mettre un texte "Perdu"
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
}
