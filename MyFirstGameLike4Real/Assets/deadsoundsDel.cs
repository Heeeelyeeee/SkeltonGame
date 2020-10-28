using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadsoundsDel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DDestroy", 2);
    }
    private void DDestroy()
    {
        Destroy(gameObject);
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
