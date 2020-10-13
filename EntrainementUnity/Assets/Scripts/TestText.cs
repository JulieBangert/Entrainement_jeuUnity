using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestText : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "blablabla";
        Debug.Log(text.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}