using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horSpeed = 0.2f;
    public float verSpeed = 0.2f;
    float speadX;
    float speadY;
    private float timer = 10f;


    public Rigidbody2D rb;
    public Camera cam;

    public GameObject shootPoint;
    public Rigidbody2D shRb;
    
    Vector2 movement;

    //Transform defaulttransform;

    public Animator animat;

    Vector3 defaultSH = new Vector3 ( 1, 1, 1);
    
    private string w = "w";
    private string s = "s";
    private string a = "a";
    private string d = "d";

    private int[] prevNum = new int[3]; 
    private int tN = 0;

    void Update()
    {   

        //[Animator] changing parameter responsible for animation
        //isMoving
        if (movement.x != 0 || movement.y != 0)
        {
            //animat.SetBool("isMoving", true);
        }
        else
        {
           // animat.SetBool("isMoving", false);
        }
        //isVpered
        if (movement.y > 0)
        {
          //  animat.SetBool("isVpered", true);
        }
        if (movement.y <=0 && movement.x != 0)
        {
          //  animat.SetBool("isVpered", false);
        }
        
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ChangeRandControl();
            timer = 10f;
        }

    }

    void FixedUpdate()
    {
        if(Input.GetKey(w)) {
            speadY = verSpeed;
        }
        else if(Input.GetKey(s)) {
            speadY = -verSpeed;
        }
        else if(Input.GetKey(a)) {
            speadX = -horSpeed;
        }
        else if(Input.GetKey(d)) {
            speadX = horSpeed;
        }
        transform.Translate(speadX, speadY, 0);
        speadX = 0;
        speadY = 0;
 

        if (Input.GetKey("w"))
        {
            
            shRb.rotation = 270;
        }
        if (Input.GetKey("a"))
        {
            shRb.rotation = 0;
            
        }
        if (Input.GetKey("d"))
        {
            shRb.rotation = 180;
            
        }
        if(Input.GetKey("s"))
        {
            shRb.rotation = 90;
            
        } 
        
        shootPoint.transform.localPosition = defaultSH;
        cam.transform.position = rb.transform.position + new Vector3(0, 0, -10f);
    }

    string RandomButtomAdd(){
        string[] keyArr = new string[45];
        keyArr[0] = "z";
        keyArr[1] = "x";
        keyArr[2] = "c";
        keyArr[3] = "v";
        keyArr[4] = "b";
        keyArr[5] = "n";
        keyArr[6] = "m";
        keyArr[7] = ",";
        keyArr[8] = ".";
        keyArr[9] = "/";
        keyArr[10] = "a";
        keyArr[11] = "s";
        keyArr[12] = "d";
        keyArr[13] = "f";
        keyArr[14] = "g";
        keyArr[15] = "h";
        keyArr[16] = "j";
        keyArr[17] = "k";
        keyArr[18] = "l";
        keyArr[19] = ";";
        keyArr[20] = "'";
        keyArr[21] = "q";
        keyArr[22] = "w";
        keyArr[23] = "e";
        keyArr[24] = "r";
        keyArr[25] = "t";
        keyArr[26] = "y";
        keyArr[27] = "u";
        keyArr[28] = "i";
        keyArr[29] = "o";
        keyArr[30] = "p";
        keyArr[31] = "[";
        keyArr[32] = "]";
        keyArr[33] = "1";
        keyArr[34] = "2";
        keyArr[35] = "3";
        keyArr[36] = "4";
        keyArr[37] = "5";
        keyArr[38] = "6";
        keyArr[39] = "7";
        keyArr[40] = "8";
        keyArr[41] = "9";
        keyArr[42] = "0";
        keyArr[43] = "-";
        keyArr[44] = "=";

        bool unik = false;
        int keyNum = 0;
        while(unik == false){
            keyNum = Random.Range( 0, 45 );

            int unikNum = 0;
            for(int i = 0; i < tN; i++)
            {   
                if(prevNum[i] != keyNum) 
                    unikNum ++;
            }

            if(unikNum == tN)
                unik = true;
        }

        return keyArr[keyNum];
    }

    void ChangeRandControl() {
        int num  = Random.Range( 0, 5 );
        switch (num)
        {
            case 1: {
                w = RandomButtomAdd();
                break;
            }
            case 2: {
                w = RandomButtomAdd();
                w = RandomButtomAdd();
                break;
            }
            case 3: {
                w = RandomButtomAdd();
                s = RandomButtomAdd();
                a = RandomButtomAdd();
                break;
            }
            case 4: {
                w = RandomButtomAdd();
                s = RandomButtomAdd();
                a = RandomButtomAdd();
                d = RandomButtomAdd();
                break;
            }
        }
    }    
    
}
