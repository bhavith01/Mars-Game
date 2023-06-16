using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private int i;
    public float x,y,z;
    public bool isCollided;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            x=Door.transform.position.x;
            isCollided=true;
            for(i=0;i<10;i++)
            {
              y=Door.transform.position.y;
              z=Door.transform.transform.position.z;
            Door.transform.position=new Vector3(x,y,z);
            x-=0.2f;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
           
            isCollided=false;
            if(isCollided==false)
            {
             x=Door.transform.position.x;
            for(i=0;i<10;i++)
            {
              y=Door.transform.position.y;
              z=Door.transform.transform.position.z;
            Door.transform.position=new Vector3(x,y,z);
            x+=0.2f;
            }
            }
        }
    }
}
