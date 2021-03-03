using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.UI;


public class SelectionResponse : MonoBehaviour, ISelectionResponse
{
  
    public static Transform currentSelection;
    

    
    public void OnHover(Transform selection)
    {
        currentSelection = selection;
        selection.GetComponent<Outline>().OutlineWidth = 10;
        CheckForInput(currentSelection);

    }

    public void OnDeselect(Transform selection)
    {
       // currentSelection = null;
       selection.GetComponent<Outline>().OutlineWidth = 0;


    }

    void CheckForInput(Transform currentSelection)
    {
        //If i press E and current selection
        if (PlayerInput.interact && currentSelection.GetComponent<Iinteractable>() != null)
        {
           // Debug.Log("OnInteract");
            currentSelection.SendMessage("onInteract");

        }

    }
}

