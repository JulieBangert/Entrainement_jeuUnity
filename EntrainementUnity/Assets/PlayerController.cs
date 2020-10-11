using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool playerCanMove;
    [SerializeField] private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        playerCanMove = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerCanMove)
        {
            if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1)
            {
                Vector3 dir = new Vector2(Input.GetAxis("Horizontal"), 0);
                transform.position += dir * speed * Time.deltaTime;
            }
        }
    }
}
