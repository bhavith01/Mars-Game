using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tyre : MonoBehaviour
{
    public float spinner = 0, turner = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("playerIn") == 1)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                spinner *= Time.deltaTime;
                transform.Rotate(spinner, 0, 0);
                spinner += 500;
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                spinner *= Time.deltaTime;
                transform.Rotate(-spinner, 0, 0);
                spinner += 500;

            }
        }
    }
}
