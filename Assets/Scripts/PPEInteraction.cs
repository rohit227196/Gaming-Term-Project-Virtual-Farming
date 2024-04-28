using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPEInteraction : Interactable
{
    [Header("Object Parameters")]
    public string objectName = "";
    public string objectDescription = "";

    public override void OnFocus()
    {
        throw new System.NotImplementedException();
    }

    public override void OnInteract()
    {
        throw new System.NotImplementedException();
    }

    public override void OnLoseFocus()
    {
        throw new System.NotImplementedException();
    }
}
