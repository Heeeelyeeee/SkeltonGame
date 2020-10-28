using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FirePointBehaviour : MonoBehaviour
{
    //public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;
    public Transform Main;
    public Transform firePoint;
    
    //Vector2 movement;
    Vector2 mousePos;
    void Update()
    {

        //Input 
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
    
    void FixedUpdate()
    {
        //Movment
        firePoint.position = Main.position;

        Vector2 LookDir = mousePos-rb.position;
        float angle = Mathf.Atan2(LookDir.y,LookDir.x)*Mathf.Rad2Deg-90f;
        rb.rotation = angle;
        
    }
}