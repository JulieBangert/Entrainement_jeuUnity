using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ReturnToFunFair()
    {
        if (Application.CanStreamedLevelBeLoaded("FunFair"))
        {
            SceneManager.LoadScene("FunFair");
        }
        else
        {
            Debug.Log("Scene Not Found!");
        }
    }

    public void ChangeCurrentScene(string sceneName)
    {
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            // enregistrer la dernière position du joueur dans la scène
            if(GameObject.Find("Player").GetComponent<HandlePlayerSpawn>())
            {
                GameObject.Find("Player").GetComponent<HandlePlayerSpawn>().RegisterLastPlayerPosition();
            }

            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.Log("Scene Not Found!");
        }
    }
}
