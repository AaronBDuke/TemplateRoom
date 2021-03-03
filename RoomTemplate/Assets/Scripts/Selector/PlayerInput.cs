using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static bool interact;
    public static bool chooseYes; 
    public static bool chooseNo;

    private void Update()
    {
        interact = Input.GetKeyDown(KeyCode.E);
        chooseYes = Input.GetKeyDown(KeyCode.Y);
        chooseNo = Input.GetKeyDown(KeyCode.N);
    }
}
