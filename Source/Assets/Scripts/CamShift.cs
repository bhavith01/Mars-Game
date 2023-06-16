using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShift : MonoBehaviour
{
    // Start is called before the first frame update
     public Camera cam;
     public Rigidbody player,rover;
     private Vector3 play,of;
    
    
    void Start()
    {
        of=new Vector3(5,5,5);
   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
          play=rover.transform.position;
          cam.enabled=false;
          player.isKinematic = true;
          player.transform.position=new Vector3(-5,-3,3);
           
        }

        if(Input.GetKey(KeyCode.X))
        {
            cam.enabled=true;
            player.transform.position=play+of;
              player.isKinematic = false;
             
        } 
    }
}
