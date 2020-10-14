using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayerSpawn : MonoBehaviour
{
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

    //NOTE:
    //cette fonction n'est pas call si le jeu est quitté depuis une scène autre que FunFair
    //ce qui fait que le joueur peut garder sa dernière pos si on quite depuis un mini jeu 
    void OnApplicationQuit()
    {
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("lastPos");
    }
}