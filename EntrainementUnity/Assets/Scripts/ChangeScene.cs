using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private Animator transition;

    public void ReturnToFunFair()
    {
        ChangeCurrentScene("FunFair");
    }

    public void ChangeCurrentScene(string sceneName)
    {
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            if(GameObject.Find("Player"))
            {
                //stopper le player
                GameObject.Find("Player").GetComponent<PlayerController>().StopMoving();

                //record sa position
                if (GameObject.Find("Player").GetComponent<HandlePlayerSpawn>())
                {
                    GameObject.Find("Player").GetComponent<HandlePlayerSpawn>().RegisterLastPlayerPosition();
                }
            }

            StartCoroutine(Transition(sceneName));
        }
        else
        {
            Debug.Log("Scene Not Found!");

        }
    }

    IEnumerator Transition(string sceneName)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(sceneName);
    }
}

