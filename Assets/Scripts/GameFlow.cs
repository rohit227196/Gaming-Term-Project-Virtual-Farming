using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public GameObject[] PPE_non_static;
    public GameObject[] toggleObjects;
    public static GameObject[] PPE;
    public static Toggle[] toggler;

    public static GameObject currentButtonObject;
    public static GameObject headText;
    public static GameObject descText;

    public static GameObject PPE_Canvas;
    public static GameObject Play_Canvas;

    void Start()
    {
        toggler = new Toggle[toggleObjects.Length];
        PPE = new GameObject[PPE_non_static.Length];
        for (int i = 0; i < PPE_non_static.Length; i++)
        {
            PPE[i] = PPE_non_static[i];
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
        headText.GetComponent<TextMeshProUGUI>().text = "";
        descText.GetComponent<TextMeshProUGUI>().text = "";
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        GameObject.Find("FarmerWithAnimations").GetComponent<FirstPersonController>().enabled = true;
        GameObject.Find("Game Manager").GetComponent<PauseAndPlayScript>().enabled = true;

        Play_Canvas.SetActive(true);
        PPE_Canvas.SetActive(false);
        checkObj1(currentButtonObject);
        currentButtonObject.SetActive(false);


        Play_Canvas.SetActive(true);
        PPE_Canvas.SetActive(false);

    }

}
