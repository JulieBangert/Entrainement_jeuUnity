using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactor : MonoBehaviour
{
    public UnityEvent myEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        //Debug.Log("BADABOOM !");

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