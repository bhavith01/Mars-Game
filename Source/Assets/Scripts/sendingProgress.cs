using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sendingProgress : MonoBehaviour
{
    public Canvas sendingScreen,mainScreen;
    public Image sendingProgressBar;
    public Canvas lowLinkSpeedPage;
    public Button backButton;
    bool switchedScreen = false;



    void Start()
    {
        lowLinkSpeedPage.gameObject.SetActive(false);
        sendingScreen.gameObject.SetActive(false);
        sendingProgressBar.fillAmount = 0;
    }

    void Update()
    {

        {
            if (sendingScreen.gameObject.activeSelf == true && sendingProgressBar.fillAmount != 1)
            {
                Debug.Log("Bruh");
                sendingProgressBar.fillAmount += 0.0035f;

            }
            else if (sendingProgressBar.fillAmount == 1)
            {
                sendingProgressBar.fillAmount = 0;
                mainScreen.gameObject.SetActive(true);
                sendingScreen.gameObject.SetActive(false);
            }
        }
    }

    public void goBackFromSending()
    {
        lowLinkSpeedPage.gameObject.SetActive(false);
        sendingProgressBar.fillAmount = 0;

        mainScreen.gameObject.SetActive(true);
        sendingScreen.gameObject.SetActive(false);
        switchedScreen = false;
    }

    public void sendReport()
    {
        if (PlayerPrefs.GetInt("linkSpeedNeedsCorrection") == 1)
        {
            mainScreen.gameObject.SetActive(false);
            lowLinkSpeedPage.gameObject.SetActive(true);
        }
        else
        {
            mainScreen.gameObject.SetActive(false);
            sendingScreen.gameObject.SetActive(true);
        }
    }
}
