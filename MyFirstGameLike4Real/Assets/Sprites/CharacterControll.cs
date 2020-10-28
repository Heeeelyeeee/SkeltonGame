using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterControll : MonoBehaviour
{
   public float moveSpeed = 5f;
    public Animator animator;
    public Rigidbody2D rb;
    public int health = 3;
    public GameObject getting_hurt;
    public GameObject Dying;
    public GameObject Lose;
    public GameObject Camrea;

    Vector2 movement;
    Vector2 mousePos;
    
    void Update()
    {

        //Input 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    
    void FixedUpdate()
    {
        //Movment
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        
    }
  void OnCollisionEnter2D(Collision2D collision)
         {
             if (collision.gameObject.tag == "Enemy"){
                if (health>1) {
                
                health -= 1;
                Instantiate(getting_hurt, transform.position, Quaternion.identity);
                }
                else if (health == 1) {
                Vector2 camrea = Camrea.transform.position;
                Instantiate(Lose, camrea, Quaternion.identity);
                Instantiate(Dying, transform.position, Quaternion.identity);
                health += -1;


            }
             }
       
        
        }

}