using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuButtones : MonoBehaviour
{
    public AudioSource audioSource;
    public Toggle toggle;

    public void quitApplication()
    {
        Application.Quit();
    }

    public void sceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void toggleSound(GameObject label)
    {
        bool isOn = toggle.isOn;
        audioSource.enabled = isOn;
        label.GetComponent<TextMeshPro>().text = isOn ? "Music On" : "Music Off";
   
    }


}
