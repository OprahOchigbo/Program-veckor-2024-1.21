using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random: MonoBehaviour
{
    public string[] dialogueLines;
    void Start()
    {
        StartRandomDialogue();
        
    }

    // Update is called once per frame
   public void StartRandomDialogue()
    {
        if(dialogueLines.Length > 0)
        {
            int randomIndex = Random.Range(0, dialogueLines.Length);

            string randomDialogue = dialogueLines[randomIndex];

            Debug.Log("NPC:" + randomDialogue);
        }
        else
        {
            Debug.LogWarning("No dialogue :(");
        }
    }
}
