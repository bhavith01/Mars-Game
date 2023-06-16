using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revive : MonoBehaviour
{
    public GameObject player;
    public Rigidbody car;
    public Camera cam;
    public ParticleSystem smoke;
    private Vector3 of = new Vector3(1, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("playerIn") == 1 && Input.GetKeyDown(KeyCode.F)) 
        {
            player.transform.position = car.transform.position+  of;
            Debug.Log("j");
            player.gameObject.SetActive(true);
            cam.enabled = true;
            car.isKinematic = true;
            
            PlayerPrefs.SetInt("playerIn", 0);
            PlayerPrefs.Save();
            smoke.gameObject.SetActive(false);
            player.GetComponent<AudioSource>().enabled = true;
        }
    }
}
