using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipPPE : MonoBehaviour
{
    [Header("Text For Changing")]
    [SerializeField] private string textForHead;
    [SerializeField] private string textForDesc;

    [Header("Text Objects")]
    [SerializeField] private GameObject headText;
    [SerializeField] private GameObject descText;

    [SerializeField] private GameObject PPE_Canvas;
    [SerializeField] private GameObject Play_Canvas;

    [SerializeField] private Button Equip;
    [SerializeField] private Button Cancel;

    void Awake()
    {

    }


    private void OnMouseDown()
    {
        GameFlow.headText = headText;
        GameFlow.descText = descText; 
        GameFlow.PPE_Canvas = PPE_Canvas;
        GameFlow.Play_Canvas = Play_Canvas;
        GameFlow.currentButtonObject = gameObject;

        headText.GetComponent<TextMeshProUGUI>().text = textForHead;
        descText.GetComponent<TextMeshProUGUI>().text = textForDesc;
        Play_Canvas.SetActive(false);
        PPE_Canvas.SetActive(true);

        GameObject.Find("FarmerWithAnimations").GetComponent<FirstPersonController>().enabled = false;
        GameObject.Find("Game Manager").GetComponent<PauseAndPlayScript>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;  
    }

}
