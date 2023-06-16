using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camchanger : MonoBehaviour
{
    public GameObject player;
    private Vector3 of;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        of = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.isKinematic == false)
        {
            transform.position = player.transform.position + of;
            transform.eulerAngles = player.transform.eulerAngles;
        }
    }
}
