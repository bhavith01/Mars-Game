using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillTurn : MonoBehaviour
{
    public float spinner=0,turner=0;
    public GameObject FrontWheel,BackWheel;
    public int i,n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("playerIn") == 1)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                spinner *= Time.deltaTime;
                transform.Rotate(spinner, 0, 0);
                spinner += 500;
            }
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                for (i = 0; i < n; i++)
                {
                    spinner *= Time.deltaTime;
                    transform.Rotate(spinner, 0, 0);
                    spinner += 10;
                }
            }

            if (Input.GetKeyUp(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                for (i = 0; i < n; i++)
                {
                    spinner *= Time.deltaTime;
                    transform.Rotate(-spinner, 0, 0);
                    spinner += 10;
                }
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                spinner *= Time.deltaTime;
                transform.Rotate(-spinner, 0, 0);
                spinner += 500;

            }


            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                FrontWheel.transform.localEulerAngles = new Vector3(0, -50, 0);
            }


            if (Input.GetKeyUp(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                FrontWheel.transform.eulerAngles = BackWheel.transform.eulerAngles;
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                FrontWheel.transform.localEulerAngles = new Vector3(0, 50, 0);
            }


            if (Input.GetKeyUp(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                FrontWheel.transform.eulerAngles = BackWheel.transform.eulerAngles;
            }

        }
    }
}
