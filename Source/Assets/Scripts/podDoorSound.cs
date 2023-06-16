using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podDoorSound : MonoBehaviour
{
    public AudioSource doorSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("door"))
            doorSound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("door"))
            doorSound.Play();
    }
}
