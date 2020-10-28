using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camrea : MonoBehaviour
{
    public GameObject lose;
    public GameObject Wave1Complete;
    public GameObject AllCouting;
    public GameObject Player;

    private void fixedUpdate()
    {
      int Health = Player.GetComponent<CharacterControll>().health;

        if(Health == 0)
        {
            Instantiate(lose, transform.position, Quaternion.identity);
        }

    }

}
