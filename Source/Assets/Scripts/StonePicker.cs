using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StonePicker : MonoBehaviour
{
    public Light light1;

    [SerializeField] Animator anim;
    public GameObject Stone, Stone1;
    public Rigidbody player;
    public Text stoneText;
    public bool holoOn, isTriggered, rotOn;
    public GameObject[] stones = new GameObject[5];
    public int stoneCount = 0, stonepos = 0, stonepos1 = 0, x, y, j, x1, y1, z1;
    public float rot;
    public GameObject holoPlace;
    // Start is called before the first frame update
    void Start()
    {
        stonepos1 = 0;
        holoOn = false;
        light1.enabled = false;
        stoneText.enabled = false;
        stoneText.text = stoneCount.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if (holoOn == true)
        {
            Debug.Log("Holo");
            Debug.Log(stonepos1);
            if (Input.GetKeyDown(KeyCode.RightArrow) && stonepos1 < 5)
            {
                if (stonepos1 > -1)
                {
                    stones[stonepos1].transform.position = new Vector3(1, -100, 1);
                }

                stonepos1++;
                Debug.Log(stonepos1);
                stones[stonepos1].transform.position = holoPlace.transform.position;
            }
            else if (stonepos1 == 5)
            {
                stonepos1 = 4;
            }



            if (rotOn == true)
            {
                stones[stonepos1].transform.eulerAngles = new Vector3(0, rot, 0);
                rot += 0.5f;
            }
            else
            {
                Debug.Log(stones.Length);
                stones[stonepos1].transform.eulerAngles = new Vector3(0, 0, 0);
            }





            if (Input.GetKeyDown(KeyCode.LeftArrow) && stonepos1 > -1)
            {
                if (stonepos1 < 4)
                {
                    stones[stonepos1].transform.position = new Vector3(1, -100, 1);
                }

                stonepos1--;

                stones[stonepos1].transform.position = holoPlace.transform.position;
            }
        }




    }
    public void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Stone") && Input.GetKey(KeyCode.P) && stonepos < 5)
        {
            Debug.Log(stonepos);
           // isTriggered = true;
            Stone1 = other.gameObject;

            // Destroy(other.gameObject);
            Stone1.transform.position = new Vector3(1, -100, 1);
           // stoneText.enabled = true;
            //stoneCount++  ;
            //stoneText.text = stoneCount.ToString();
            stones[stonepos1] = Stone1;
            stones[stonepos1].transform.localScale += new Vector3(x1, y1, z1);
            stonepos1++;

        }

        if (other.gameObject.CompareTag("Hologram") && Input.GetKey(KeyCode.H))
        {
            if (!holoOn)
            {
                holoOn = true;
                light1.enabled = true;

                stones[stonepos1].transform.position = holoPlace.transform.position;
                rotOn = true;
            }
         /*   else
            {
                stones[stonepos1].transform.position = new Vector3(1, -100, 1);
                holoOn = false;
                light1.enabled = false;
                rotOn = false;
            }*/

        }








    }

}
