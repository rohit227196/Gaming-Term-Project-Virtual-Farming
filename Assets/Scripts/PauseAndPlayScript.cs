using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndPlayScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject playMenu;
    public static bool isPaused = false;

    void Awake()
    {
        pauseMenu.SetActive(false); 
        playMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(isPaused);
            playMenu.SetActive(!isPaused);

            Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = isPaused;
            Time.timeScale = isPaused ? 0.0f : 1.0f;

            GameObject.Find("FarmerWithAnimations").GetComponent<FirstPersonController>().enabled = !isPaused;

            isPaused = !isPaused;
        }
    }
}
