using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 lastPos;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        lastPos.x = PlayerPrefs.GetFloat("lastPos");
        transform.position = new Vector3(lastPos.x, transform.position.y, transform.position.z);
    }

    public void RegisterLastPlayerPosition()
    {
        lastPos = transform.position;
        PlayerPrefs.SetFloat("lastPos", lastPos.x);
    }

    public float GetLastPlayerPosition()
    {
        return PlayerPrefs.GetFloat("lastPos");
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}