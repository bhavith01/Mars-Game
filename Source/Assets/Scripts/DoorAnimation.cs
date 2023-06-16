using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    public bool isentered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isentered=true;
            anim.SetBool("PlaySpin",true);
        }
    } 

    public void OnTriggerExit(Collider other)
    {
        isentered=false;
   
           // anim.SetBool("PlaySpin",false);
           anim.SetFloat("Direction",-1);
           anim.Play("Door",-1,float.NegativeInfinity);
    }
}
