using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactor : MonoBehaviour
{
    public UnityEvent myEvent;

    public void Interact()
    {
        if (myEvent.GetPersistentEventCount() > 0)
        {
            myEvent.Invoke();
        }
        else
        {
            Debug.LogWarning("NO EVENT SUBSCRIBE on interactor");
        }
    }
}