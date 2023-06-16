using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCreat : MonoBehaviour
{
    public GameObject Stone,Stone1;
    public bool isTriggered;
    private float x=0,y=0,z=0,x1,y1,z1;
    public int i,lim;
    // Start is called before the first frame update
    void Start()
    {
       for( i=0;i<lim;i++)
        {
            x=Random.Range(-100f,100f);
            z=Random.Range(-100f,100f);
            x1=Random.Range(0.1f,10f);
           // y1=Random.Range(0.1f,10f);
            z1=Random.Range(0.1f,15f);
            Stone1.gameObject.transform.localScale += new Vector3(x1, 50, z1);
     Stone1=Instantiate(Stone,new Vector3(x,0.03131494f,z),Quaternion.identity);
      
        }  
    }    void Update()
    {
        
    }

    
}
