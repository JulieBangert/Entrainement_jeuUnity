using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Vector3 initPos;

    // Start is called before the first frame update
    void Awake()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(target)
        {
            Camera.main.transform.position = new Vector3(target.transform.position.x, initPos.y, initPos.z);
        }
    }
}