using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosChanger : MonoBehaviour
{
    public GameObject player;
    private Vector3 of;
    
    // Start is called before the first frame update
    void Start()
    {
        of = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + of;
    }
}
