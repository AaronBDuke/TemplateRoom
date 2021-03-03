using UnityEngine;
using TMPro;
internal class HighlightSelectionResponse : MonoBehaviour, ISelectionResponse
{
    [SerializeField] public Material highlightMaterial;
    [SerializeField] public Material defaultMaterial;
    
    public void OnHover(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();

        if (selectionRenderer != null)
        {
            selectionRenderer.material = highlightMaterial;
        }
      
    }
    public void OnDeselect(Transform selection)
    {
        var selectionRenderer = selection.GetComponent<Renderer>();
        if (selectionRenderer != null)
        {
            selectionRenderer.material = defaultMaterial;
        }
        
     
    }

}