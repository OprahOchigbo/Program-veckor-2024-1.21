using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public GameObject BlingObject;


    [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log(message: "Opening chest!");
        return true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BlingObject.SetActive(true);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        BlingObject.SetActive(false);
    }
}
