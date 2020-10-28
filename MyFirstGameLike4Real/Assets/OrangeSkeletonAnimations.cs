using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeSkeletonAnimations : MonoBehaviour
{
   public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;

    void Update()
    {

       
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    
    void FixedUpdate()
    {
        //Movment
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
