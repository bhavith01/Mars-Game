using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDoorReverse : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public bool DoorEnterthing;
   
    public int i;
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
        
           anim.SetFloat("Reverse",1);
            DoorEnterthing=true;
           anim.SetBool("DoorE",true);
        
        
       
        }
    }

     public void OnTriggerExit(Collider other)
     {
          if(other.gameObject.CompareTag("Player"))
        {
            DoorEnterthing=false;
          //  anim.enabled=false;
           // DoorR.transform.position=dr;
         //   DoorL.transform.position=dl;
            
       
          //anim.SetBool("DoorE",true);
         anim.SetFloat("Reverse",-1);
        anim.Play("DoorRight",-1,float.NegativeInfinity);
       anim.Play("DoorLeft",-1,float.NegativeInfinity);
     // anim.SetFloat("Reverse",1);

    // anim.SetBool("DoorE",false);
        }
     }
     
}
