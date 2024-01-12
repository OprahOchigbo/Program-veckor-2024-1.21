using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playermovement : MonoBehaviour
{
    public float movespeed = 5f;

    private Rigidbody2D rb;

    public Animator anim;

    public float x, y;
    private bool walk;

    private Vector2 dir;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

 
    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");
       y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            anim.SetFloat("x", x);
            anim.SetFloat("y", y);
            walk = true;
            anim.SetBool("speed", walk);
                
                
            
        }
        else
        {
            if (walk)
            {
                walk = false;
                anim.SetBool("speed", walk);
                StopMoving();
            }
        }

        dir = new Vector2(x, y).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = dir * movespeed * Time.deltaTime;
    }
    private void StopMoving()
    {
        rb.velocity = Vector2.zero;
    }


}
