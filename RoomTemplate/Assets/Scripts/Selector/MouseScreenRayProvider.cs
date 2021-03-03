using System;
using UnityEngine;

public class MouseScreenRayProvider : MonoBehaviour, IRayProvider
{
    public Camera cam;
    
    public Ray CreateRay()
    {
        //return Camera.main.ScreenPointToRay(Input.mousePosition);
        var ray = new Ray(cam.transform.position, cam.transform.forward);
        return ray;


    }
}