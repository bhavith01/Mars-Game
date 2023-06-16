using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public Canvas pauseScreen,monoScreen,vidScreen;
    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pauseScreen.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void startGame()
    {
        SceneManager.LoadScene("Anish");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void resume()
    {
        pauseScreen.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void retrunToStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void afterMonolouge()
    {
        monoScreen.gameObject.SetActive(false);
        vidScreen.gameObject.SetActive(true);
    }
}
