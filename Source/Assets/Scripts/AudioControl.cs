using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
           aud.enabled=true; 
        }
        else{
            aud.enabled=false;
        }
    }
}
