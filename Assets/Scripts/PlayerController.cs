using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private Vector3 oldmouse;
    private Vector3 newmouse;
    public float rotationspeed;
    public float mousedeltax;
    private bool isrotating;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        
        float deltax = Input.GetAxis("Horizontal") * speed;
        float deltaz = Input.GetAxis("Vertical") * speed;
        
        gameObject.transform.Translate(new Vector3(deltax,0,deltaz));
        
        
        newmouse = Input.mousePosition;
        
        if (Input.GetMouseButtonDown(1)) { 
            isrotating = true;
            Cursor.visible = false;
            
        }

        if (Input.GetMouseButtonUp(1))
        {
            Mouse.current.WarpCursorPosition(new Vector2(Screen.width/2,Screen.height/2));
            isrotating = false;
            Cursor.visible = true;


        }

        if (isrotating)
        {
            
            mousedeltax = newmouse.x - oldmouse.x;
            gameObject.transform.Rotate(0,mousedeltax * rotationspeed,0);
        }
        
        oldmouse = newmouse;
    }

    private void FixedUpdate()
    {
       
    }
}
