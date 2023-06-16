using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScreen : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam.transform.eulerAngles = new Vector3(0, Random.Range(0, 359),0);
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.eulerAngles += new Vector3(0, 0.1f, 0);
    }
}
