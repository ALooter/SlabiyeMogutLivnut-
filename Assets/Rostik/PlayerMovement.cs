using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;

    public GameObject shootPoint;
    public Rigidbody2D shRb;
    
    Vector2 movement;
    Transform defaulttransform;
    public Animator animat;

    Vector3 defaultSH;

    private void Start()
    {
        defaultSH = shootPoint.transform.localPosition;
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
            this.transform.rotation = Quaternion.Euler(0, 0, 270);
            shRb.rotation = 270;
        }
        if (Input.GetKey("a"))
        {
            shRb.rotation = 0;
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            shRb.rotation = 180;
            this.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if(Input.GetKey("s"))
        {
            shRb.rotation = 90;
            this.transform.rotation = Quaternion.Euler(0, 0, 90);
        } 
        
        shootPoint.transform.localPosition = defaultSH;
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
        cam.transform.position = rb.transform.position + new Vector3(0, 0, -10f);
    }
}
