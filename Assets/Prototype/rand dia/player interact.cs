using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerinteract : MonoBehaviour
{
    public random dialogueManager; 


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartRandomNPCDialogue();
        }
    }

    public void StartRandomNPCDialogue()
    {
        if (dialogueManager != null)
        {
            dialogueManager.StartRandomDialogue();
        }
        else
        {
            Debug.LogWarning("not attached :(");
        }
    }
}
