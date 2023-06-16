using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AntennaController : MonoBehaviour
{
    public Slider antennaControlBar;
    float timePassed;
    public GameObject antenna;
    

    public Image greenLight;
    public Image redLight;

    void Start()
    {
        antennaControlBar.maxValue = 359;
        antennaControlBar.minValue = 1;
        PlayerPrefs.SetInt("linkSpeedCorrecter", 20);
        PlayerPrefs.SetFloat("linkSpeed",1);
        PlayerPrefs.SetInt("linkSpeedNeedsCorrection", 0);
        greenLight.gameObject.SetActive(false);
        redLight.gameObject.SetActive(true);
    }

    void Update()
    {
        antenna.transform.eulerAngles += new Vector3(0, antennaControlBar.value - antenna.transform.eulerAngles.y , 0);
       /* Debug.Log("needs" + PlayerPrefs.GetInt("LinkSpeedsNeedsCorrection"));
        Debug.Log("val" + antennaControlBar.value);
        Debug.Log("correc "+PlayerPrefs.GetInt("LinkSpeedCorrector"));
       */
        if (PlayerPrefs.GetInt("linkSpeedCorrecter") <= (int)antennaControlBar.value + 10 && PlayerPrefs.GetInt("linkSpeedCorrecter") >= (int)antennaControlBar.value-10)
        {
            redLight.gameObject.SetActive(false);
            greenLight.gameObject.SetActive(true);
            PlayerPrefs.SetInt("linkSpeedNeedsCorrection", 0);
        }
        else
        {

            redLight.gameObject.SetActive(true);
            greenLight.gameObject.SetActive(false);
            PlayerPrefs.SetInt("linkSpeedNeedsCorrection", 1);
        }
        timePassed += Time.deltaTime;
        if (timePassed > 600)
        {
            timePassed = 0;
        }

    }

    public void setAntenna()
    {
        for (float i = 0; i < 100; i++)
        {
            antenna.transform.eulerAngles = new Vector3(i, 0, 0);
            i *= Time.deltaTime;
        }
    }
}