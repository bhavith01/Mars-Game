using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContRover : MonoBehaviour
{
    public bool playerIn;
    public float speed = 10.0f;
    public float rotationSpeed = 1.0f;
    // public RoverMove rm; 
    public Rigidbody player, car;
    public Camera cam;
    public GameObject wheels, smoke;

    public GameObject rover;
    // Start is called before the first frame update
    void Start()
    {
        // rm=GetComponent<RoverMove>();
        // rover.GetComponent<RoverMove>().enabled=false;
        //rover.GetComponent<WindmillTurn>().enabled=false;
     //   car.GetComponent<CarControll>.enabled = false;
        car.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIn)
        {
            wheels.gameObject.SetActive(true);
            smoke.gameObject.SetActive(true);
        }
        else
        {
            wheels.gameObject.SetActive(false);
            smoke.gameObject.SetActive(false);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.CompareTag("Rover")) && (Input.GetKey(KeyCode.E)))
        {
            playerIn = true;
            // rm.enabled=true;
            //  rover.GetComponent<RoverMove>().enabled=true;

            // play=rover.transform.position;
            cam.enabled = false;
            player.isKinematic = true;
            car.isKinematic = false;
            player.transform.position = new Vector3(-5, -3, 3);
            // rover.GetComponent<WindmillTurn>().enabled=true;
        }
    }
}