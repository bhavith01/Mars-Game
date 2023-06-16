using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolarController : MonoBehaviour
{
    public Slider solarControl;
    public GameObject solarPanel;
    // Start is called before the first frame update
    void Start()
    {
        solarControl.maxValue = 150;
        solarControl.minValue = 30;
    }

    // Update is called once per frame
    void Update()
    {
        solarPanel.transform.eulerAngles = new Vector3(-solarControl.value,90, 90);
    }
}
