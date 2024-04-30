using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTestScript : MonoBehaviour
{

    [SerializeField] private GameObject PPE_Canvas;
    [SerializeField] private GameObject Play_Canvas;
    

    /*public void okButton()
    {
        Debug.Log("HAHAHAHAHAH");
        Play_Canvas.SetActive(true);
        PPE_Canvas.SetActive(false);
    }*/

    public void quitApp()
    {
        Debug.Log("EXIT APPLICATION");
        Application.Quit();
    }
}
