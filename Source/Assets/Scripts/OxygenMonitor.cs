using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OxygenMonitor : MonoBehaviour
{
    private double oxygenLevel = 100;
    public Text oxyLevelText;
    //public Rigidbody x;
    public Image bar;
    public Canvas lowOxygenWarning;
    public float heightIncrease;
    public Animator bloodFade;
   // private timePassed;
    


    void Start()
    {
        lowOxygenWarning.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (oxygenLevel > 0)
        {
            if (oxygenLevel <= 20)
            {

                lowOxygenWarning.gameObject.SetActive(true);
                //bloodFade.Play("BloodFade");
                // bloodFade.Play("warning");
            }
            else
                lowOxygenWarning.gameObject.SetActive(false);
            oxygenLevel -= 0.01;
            //oxyLevelText.text = (oxygenLevel).ToString();
            bar.fillAmount = (float)oxygenLevel / 100;
        }
        else
            SceneManager.LoadScene("End");

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Recharge") && oxygenLevel < 100)
            oxygenLevel += .5f;
    }

    private void lowOxy()
    {
    }
}


