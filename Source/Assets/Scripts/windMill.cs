using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windMill : MonoBehaviour
{
    public float spinner = 0, turner = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            spinner *= Time.deltaTime;
            transform.Rotate(spinner, 0, 0);
            spinner += 100;
       
    }
}
