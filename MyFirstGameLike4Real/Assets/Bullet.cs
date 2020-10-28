using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private int hitnub = 0;
    public string TagToIgnore = "Player";
        
        void OnCollisionEnter2D(Collision2D collision)
         {
             if (collision.gameObject.tag == TagToIgnore){
                 Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
             }
             else{
                  Destroy(gameObject);
             }
       
        
        }

    // Start is called before the first frame update

  
}
