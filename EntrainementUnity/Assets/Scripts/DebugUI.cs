using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI interactionText;
    [SerializeField] private static TextMeshProUGUI interaction;

    // Start is called before the first frame update
    void Awake()
    {
        interaction = interactionText;
        HideInteractionUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void ShowInteractionUI()
    {
        interaction.text = "?";
    }
    public static void HideInteractionUI()
    {
        interaction.text = "";
    }
}
