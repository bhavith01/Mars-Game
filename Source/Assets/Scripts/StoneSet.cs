using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("PodArea")||other.gameObject.CompareTag("Rover")||other.gameObject.CompareTag("Stone"))
        {
            Destroy(gameObject);
        }
    }
}
