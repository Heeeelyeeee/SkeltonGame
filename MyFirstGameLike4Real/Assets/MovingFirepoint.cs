using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFirepoint : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("left")){
           transform.right *= -1;
       }
    }
}
