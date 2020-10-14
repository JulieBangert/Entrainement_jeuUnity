using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractions : MonoBehaviour
{
    private Interactor interaction;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(interaction)
            {
                //empecher le joueur de se déplacer
                //GetComponent<PlayerController>().StopMoving();

                interaction.Interact();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            if (other.gameObject.GetComponent<Interactor>())
            {
                interaction = other.gameObject.GetComponent<Interactor>();

                // UI
                DebugUI.ShowInteractionUI();
            }
            else
            {
                Debug.LogWarning("Il n'y a pas d'interactor sur le gameobject");
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            if (other.gameObject.GetComponent<Interactor>())
            {
                interaction = null;

                // UI
                DebugUI.HideInteractionUI();
            }
        }
    }
}
