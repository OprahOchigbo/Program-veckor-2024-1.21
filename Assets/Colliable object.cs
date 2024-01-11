using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliableObject : MonoBehaviour
{
   
    private Collider2D Collider1;
    private ContactFilter2D 
    private void Start()
    {
        Collider1 = GetComponent<Collider2D>();
    }


    private void Update()
    {
        Collider1.OverlapCollider()
    }
}
