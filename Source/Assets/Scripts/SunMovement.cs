using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{
    public GameObject sun;
    public float radius;
    private float x , y;

    // Start is called before the first frame update
    void Start()
    {
        x = -radius;
        sun.transform.position = new Vector3(0, radius, 0);
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        if (x > radius)
            x = - radius;
        y = Mathf.Sqrt(radius * radius - x * x);
        sun.transform.position = new Vector3(x, y, 0);
    }
}
