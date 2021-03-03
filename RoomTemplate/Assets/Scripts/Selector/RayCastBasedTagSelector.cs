using UnityEngine;

public class RayCastBasedTagSelector : MonoBehaviour, ISelector
{
    [SerializeField] public string selectableTag = "selectable";
    public Transform _selection;
    public void Check(Ray ray)
    {
        this._selection = null; 
        
        if (Physics.Raycast(ray, out var hit, 1.5f))
        {
            Transform selection = hit.transform;
            if (hit.transform.CompareTag(this.selectableTag))
            {
                this._selection = selection;

            }
         
        }
    }

    public Transform GetSelection()
    {
        return this._selection;
    }
}