using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public static GameObject[] PPE;
    public static GameObject[] toggleObjects;
    public static Toggle[] toggler;

    public static GameObject currentButtonObject;
    public static GameObject PPE_Canvas;
    public static GameObject Play_Canvas;
    public static GameObject headText;
    public static GameObject descText;



    void Start()
    {
        for (int i = 0; i < PPE.Length; i++)
        {
            toggler[i] = toggleObjects[i].GetComponent<Toggle>();
        }
    }

    void Update()
    {

    }

    public static void checkObj1(GameObject checkObject)
    {        
        for(int i = 0; i < PPE.Length; i++)
        {
            if (PPE[i] == checkObject)
            {
                toggler[i].isOn = true;
                break;
            }
        }
    }



    public void equipButton()
    {

        checkObj1(currentButtonObject);

        PPE_Canvas.GetComponent<Animator>().enabled = true;
        PPE_Canvas.GetComponent<Animator>().SetTrigger("Close");
        PPE_Canvas.GetComponent<Animator>().enabled = false;
        headText.GetComponent<TextMeshProUGUI>().text = "";
        descText.GetComponent<TextMeshProUGUI>().text = "";
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
       
        GameObject.Find("FarmerWithAnimations").GetComponent<FirstPersonController>().enabled = true;
        GameObject.Find("Game Manager").GetComponent<PauseAndPlayScript>().enabled = true;
        
        Play_Canvas.SetActive(true);
        PPE_Canvas.SetActive(false);

        currentButtonObject.SetActive(false);
    }

    public void cancelButton()
    {
        if (PPE_Canvas.activeSelf)
        {
            PPE_Canvas.GetComponent<Animator>().enabled = true;
            PPE_Canvas.GetComponent<Animator>().SetTrigger("Close");
            PPE_Canvas.GetComponent<Animator>().enabled = false;
            headText.GetComponent<TextMeshProUGUI>().text = "";
            descText.GetComponent<TextMeshProUGUI>().text = "";
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            GameObject.Find("FarmerWithAnimations").GetComponent<FirstPersonController>().enabled = true;
            GameObject.Find("Game Manager").GetComponent<PauseAndPlayScript>().enabled = true;

            Play_Canvas.SetActive(true);
            PPE_Canvas.SetActive(false);
        }
    }
}
