using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Enemy : MonoBehaviour
{
   
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 5f;
    public Animator animator;
    public GameObject deadsound;
    public GameObject AllCounting;
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
    }

   
    private void FixedUpdate()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        movement.x = direction.x;
        movement.y = direction.y;
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Enemycounter EC = GetComponent<Enemycounter>();
        float OrangeKilled = AllCounting.GetComponent<Enemycounter>().Wave1OrangeKilled;
        if (collision.gameObject.tag == "Bullet")
        {
            if (health > 1)
            {

                health -= 1;
            }
            else if (health <= 1)
            {
                Destroy(gameObject);
                OrangeKilled += 1;
                Instantiate(deadsound, transform.position, Quaternion.identity);

            }
        }


    }



}

