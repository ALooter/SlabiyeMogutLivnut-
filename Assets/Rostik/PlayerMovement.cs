﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {   
         if(Input.GetKey("w")){
            rb.rotation = 0;
        }
        if(Input.GetKey("a")){
            rb.rotation = 90;
        }
        if(Input.GetKey("d")){
            rb.rotation = -90;
        }
        if(Input.GetKey("s")){
            rb.rotation = 180;
        }
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        
        cam.transform.position = rb.transform.position + new Vector3(0, 0, -10f);
    }
}