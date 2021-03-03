using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "selectable";
   
    private IRayProvider _rayProvider;
    private ISelector _selector;
    private ISelectionResponse _selectionResponse;
   
    private Transform _currentSelection;
    private Transform _selection;
   

    private void Awake()
    {
        _rayProvider = GetComponent<IRayProvider>();
        _selector = GetComponent<ISelector>();
        _selectionResponse = GetComponent<ISelectionResponse>();
    }

    void LateUpdate()
    {
        if (_currentSelection != null) _selectionResponse.OnDeselect(_currentSelection);
        
        _selector.Check(_rayProvider.CreateRay());
        _currentSelection = _selector.GetSelection();

        if (_currentSelection != null) _selectionResponse.OnHover(_currentSelection);
        
           
        
    }
}