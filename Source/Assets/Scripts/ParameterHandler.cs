using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ParameterHandler : MonoBehaviour
{
    public float temp,linkSpeed,windSpeed;
    public TextMeshProUGUI tempHolder, windHolder, linkSpeedHolder;
    float timePassed;

    void Start()
    {
        PlayerPrefs.SetInt("playerIn", 0);
        PlayerPrefs.SetFloat("temp", Random.Range(-80, -30));
        PlayerPrefs.SetFloat("windSpeed", Random.Range(4, 8));
        PlayerPrefs.SetFloat("linkSpeed", Random.Range(1, 7));
        PlayerPrefs.SetInt("linkSpeedNeedsCorrection", 1);
        PlayerPrefs.SetInt("linkSpeedCorrecter", Random.Range(5, 30));


        PlayerPrefs.Save();

        tempHolder.text = "Temprature : " + PlayerPrefs.GetFloat("temp").ToString() + " C";
        windHolder.text = "Wind Speed : " + PlayerPrefs.GetFloat("windSpeed").ToString() + " m/s";
        linkSpeedHolder.text = "Link Speed : " + PlayerPrefs.GetFloat("linkSpeed").ToString() + " Mbps";
    }

    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 600)
        {
            refreshData();
            timePassed = 0;
        }

    }

    void refreshData()
    {
        PlayerPrefs.SetFloat("temp", Random.Range(-80, -30));
        PlayerPrefs.SetFloat("windSpeed", Random.Range(4, 8));
        PlayerPrefs.SetFloat("linkSpeed", Random.Range(1, 7));
        PlayerPrefs.SetInt("linkSpeedNeedsCorrection", 1);
        PlayerPrefs.SetInt("linkSpeedCorrecter",Random.Range(5,30));
        Debug.Log("Called");
        Debug.Log(PlayerPrefs.GetInt("linkSpeedNeedsCorrection"));
        PlayerPrefs.Save();

        tempHolder.text = "Temprature : " + PlayerPrefs.GetFloat("temp").ToString() +" C";
        windHolder.text = "Wind Speed : " + PlayerPrefs.GetFloat("windSpeed").ToString()+ " m/s";
        linkSpeedHolder.text = "Link Speed : " + PlayerPrefs.GetFloat("linkSpeed").ToString()+ " Mbps";
    }
}
