using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{

    public GameObject blacksquare;

    private bool isRoomEntered = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isRoomEntered)
        {
            ToggleBlackSquareVisibility();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isRoomEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isRoomEntered = false;
        }
    }

    void ToggleBlackSquareVisibility()
    {
        if (blacksquare != null)
        {
            blacksquare.SetActive(!blacksquare.activeSelf);
        }
    }

}
