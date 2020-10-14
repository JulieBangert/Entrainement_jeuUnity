using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Entree()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().StopMoving();

        //mon intéraction

        GameObject.Find("Player").GetComponent<PlayerController>().StartMoving();
    }

    public void Sortie()
    {
        GameObject.Find("Player").GetComponent<PlayerController>().StartMoving();
    }
}
