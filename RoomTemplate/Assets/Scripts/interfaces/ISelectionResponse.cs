using UnityEngine;

internal interface ISelectionResponse
{
    void OnHover(Transform selection);
    void OnDeselect(Transform selection);
}