using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharBall : MonoBehaviour
{
    public Text text;
    public Rigidbody rb;
    public int x;
    public bool iscollided;
    public GameObject screen,camera;
    public float x1, y1, z1,xcam,ycam,zam;
    public Collider collision;
    void Start()
    {
text.enabled = false;
    }

    void Update()
    {
      /*  if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(x, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-x, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, -x);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, x);
        }*/

    }

     public void OnTriggerStay(Collider collision)
     {
         if (collision.gameObject.CompareTag("Computer"))
         {
             iscollided = true;
            text.enabled = true;   

            if (Input.GetKey(KeyCode.O))
            {
                
                screen.transform.position = new Vector3(x1, y1, z1);
                camera.transform.position = new Vector3(xcam, ycam, zam);
                rb.isKinematic = true;


            }




            if (Input.GetKey(KeyCode.C))
            {
                rb.isKinematic = false;
            }

            if (Input.GetKey(KeyCode.F))
            {
                screen.transform.position = new Vector3(x1*30, y1*30, z1*30);
                rb.isKinematic = false;

            }
        }
     /*  else
        {
            iscollided = false;
            text.enabled = false;
        }*/
     }

     public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Computer"))
        {
            iscollided = false;
            text.enabled = false;
        }
    }

   /* public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("NoComputer"))
        {
            iscollided = false;
            text.enabled = false;
        }
    }*/
}
