using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
How to use:

Implement the Iinteractable interface and implement the function "OnInteract"
Only objects tagged with "selectable" can get selected

*/
public class ExampleSelectable : MonoBehaviour, Iinteractable
{

    //When the player is Hovering over this object and Presses E this method is called from the SelectionResponse Script. 
    public void onInteract()
    {
        Debug.Log("Player Pressed E on me!");
    }
}
