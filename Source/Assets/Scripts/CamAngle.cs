using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAngle : MonoBehaviour
{
    public GameObject player;
    public Vector3 of;
    public int x,y,z;
   
    // Start is called before the first frame update
    void Start()
    {
          of = player.transform.eulerAngles- transform.eulerAngles ;
    }

    // Update is called once per frame
    void Update()
    {
       
         transform.eulerAngles=player.transform.eulerAngles;
    }
}
