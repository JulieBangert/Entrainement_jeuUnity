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

        if(compteurTaupePerdu >= taupeMaxPourDefaite)
        {      
            gestionJeuPerdu();
        }
    }

    private void gestionJeuPerdu()
    {
        isJeuEnCours = false;
        Debug.Log("GAME OVER !");

        //Jouer un son

        //Mettre un texte "Perdu"

        GetComponent<AudioSource>().Play();
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
