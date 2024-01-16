using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTeleporter : MonoBehaviour
{

    public GameObject currentTeleport;


    // Update is called once per frame
    void Update()
    {

       
        if (Input.GetKeyDown(KeyCode.E))
        {
           
            if (currentTeleport != null)
            {
                transform.position = currentTeleport.GetComponent<teleporter>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");

        if (collision.CompareTag("teleporter"))
        {
             Debug.Log("teleport");
            currentTeleport = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("teleporter"))
        {
            if (collision.gameObject == currentTeleport)
            {
                currentTeleport = null;
            }
        }
    }
}
