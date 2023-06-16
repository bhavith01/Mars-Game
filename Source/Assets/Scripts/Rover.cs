using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rover : MonoBehaviour
{
   // public SphereCollider sc;
    public GameObject rovercar,player;
    public Camera cam;
    public Rigidbody rover,rb;
    public bool hasentered;
    public int x1,x,y;
    public Vector3 getdowngap;
    public float speed = 10.0f;
    public float rotationSpeed = 1.0f;
           void Start()
    {
          
          getdowngap =new Vector3(3,2,0);
    }

   
    void Update()
    {
        
     if(hasentered==true)
     {   
     /*  if (Input.GetKey(KeyCode.A))
        {
            rover.AddForce(x1, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rover.AddForce(-x1, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rover.AddForce(0, 0, -x1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rover.AddForce(0, 0, x1);
        }*/
         float translation = Input.GetAxis("Vertical") * speed;
        //float rotation =Input.GetAxis("Mouse X") * rotationSpeed;
        float rotation =Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
       translation *= Time.deltaTime;
       rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
      //  transform.Translate(0, 0, translation);
      rovercar.transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        rovercar.transform.Rotate(0,rotation, 0);
     
       
     }    
if(Input.GetKey(KeyCode.P) && hasentered==true)
    {
       // Instantiate(player,new Vector3(0,1,4),Quaternion.identity);

      gameObject.transform.position = rovercar.transform.position + getdowngap;
      rb.isKinematic=false;
     // Instantiate(player, rovercar.transform.position + getdowngap,Quaternion.identity);
        cam.enabled=false;
        hasentered=false;
        rover.isKinematic=true;
    }
     
    }

public void OnTriggerStay(Collider other)
{
  
    if(other.gameObject.CompareTag("RoverArea") && Input.GetKey(KeyCode.I))
    {
     hasentered=true;
      rover.isKinematic = false;
      cam.enabled=true;
   
    gameObject.transform.position = new Vector3(-10,-10,-10);
    rb.isKinematic=true;
    
    
    }
    
}
}
