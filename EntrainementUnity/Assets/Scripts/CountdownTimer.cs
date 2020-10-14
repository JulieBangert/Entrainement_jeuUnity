using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f; // L'heure actuelle
    float startingTime = 60f;

    

    [SerializeField] Text countdownText; // SerializeField est pariel que private mais on peut le voir dans notre editor

    void Start()
    {
        currentTime = startingTime; // Une fois que le jeu commence, on va mettre notre heure actuelle égale à l'heure de départ
    }

    void Update()
    {
        // Chaque seconde, on veut diminuer notre temps actuel d'une seconde
        currentTime -= 1 * Time.deltaTime; // Cela va le faire à chaque image. Ce n'est pas ce qu'on veut donc on utilise "time.deltatime".
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            //GameObject.Find("SceneManager").GetComponent<ChangeScene>().ReturnToFunFair();
        }
    }
}
