using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ContRover1 : MonoBehaviour
{
    public bool playerIn;

    public float speed = 10.0f;
    public float rotationSpeed = 1.0f;
    // public RoverMove rm; 
    public Rigidbody player, car;
    public Camera cam;
    public GameObject Car123, Smoke, W1, W2, W3, W4, rover;
    public Vector3 of = new Vector3(3,5,0);
    public ParticleSystem smoke;




    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        smoke.enableEmission = false;
        W1.GetComponent<WindmillTurn>().enabled = false;
        W2.GetComponent<Wheel1>().enabled = false;
        W3.GetComponent<WindmillTurn>().enabled = false;
        W4.GetComponent<Wheel1>().enabled = false;
        Smoke.active = false;
        // rm=GetComponent<RoverMove>();
        //   rover.GetComponent<RoverMove>().enabled=false;
        car.isKinematic = true;
        Smoke.gameObject.SetActive(false);
        // Car123.GetComponent<CarController>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIn == true && Input.GetKeyDown(KeyCode.F))
        {
           // player.gameObject.SetActive(true);

            //ebug.Log("bruuuuuuuuuuuuuh");
            smoke.enableEmission = false;

            // play=rover.transform.position;
            cam.enabled = true;
           //player.isKinematic = false;
            car.isKinematic = true;
            // player.transform.position=new Vector3(-5,-3,3);
          
            player.gameObject.transform.position = car.transform.position;
            playerIn = false;

            player.GetComponent<AudioSource>().enabled = true;
            W1.GetComponent<WindmillTurn>().enabled = false;
            W2.GetComponent<Wheel1>().enabled = false;
            W3.GetComponent<WindmillTurn>().enabled = false;
            W4.GetComponent<Wheel1>().enabled = false;
            Smoke.gameObject.SetActive(false);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.CompareTag("Rover")) && (Input.GetKey(KeyCode.E)))
        {
            //Destroy(player.);
            player.gameObject.SetActive(false);
            player.GetComponent<AudioSource>().enabled = false;
            smoke.enableEmission = true;
            cam.enabled = false;
            car.GetComponent<AudioListener>().enabled = true;
           // player.isKinematic = true;
           // car.isKinematic = false;
            //player.transform.position = new Vector3(-5, -3, 3);
          
            playerIn = true;
            PlayerPrefs.SetInt("playerIn", 1);
            PlayerPrefs.Save();
            W1.GetComponent<WindmillTurn>().enabled = true;
            W2.GetComponent<Wheel1>().enabled = true;
            W3.GetComponent<WindmillTurn>().enabled = true;
            W4.GetComponent<Wheel1>().enabled = true;
            Smoke.gameObject.SetActive(true);
        }
    }
}
