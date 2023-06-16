using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class vidController : MonoBehaviour
{
    private float time;
    public Canvas presentDay,vidScreen;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 7)
        {
            vidScreen.gameObject.SetActive(false);
            presentDay.gameObject.SetActive(true);
           // SceneManager.LoadScene("Anish");
        }
        if (time > 10)
        {
            SceneManager.LoadScene("Anish");
        }
    }
}
