using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    
    Vector2 movement;
    Transform defaulttransform;
    public Animator animat;

    Transform shootpoint;

    private void Start()
    {
        defaulttransform = this.transform;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        //changing parameter responsible for animation
        if (movement.x != 0 || movement.y != 0)
        {
            animat.SetBool("isMoving", true);
        }
        else
        {
            animat.SetBool("isMoving", false);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.rotation = 270;
        }
        if (Input.GetKey("a"))
        {
            rb.rotation = 0;
        }
        if (Input.GetKey("d")){
            rb.rotation = 180;
        }
        if(Input.GetKey("s")){
            rb.rotation = 90;
        } 
        
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        //shootpoint.rotation = this.transform.rotation;
        cam.transform.position = rb.transform.position + new Vector3(0, 0, -10f);
    }
}
