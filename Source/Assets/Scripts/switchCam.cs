using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCam : MonoBehaviour
{
    public Camera a, b;

    void Start()
    {
        a.gameObject.SetActive(false);
        b.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }

   public void switchc()
    {
           bool x = a.gameObject.activeSelf;
            a.gameObject.SetActive(b.gameObject.activeSelf);
            b.gameObject.SetActive(x);
    }
}

