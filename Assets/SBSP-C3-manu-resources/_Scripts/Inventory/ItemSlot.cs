using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;


public class ItemSlot : MonoBehaviour{
    public int id;
    private InventoryController inventoryController;

    void Start()
    {
        inventoryController = GameObject.Find("InventoryObject").GetComponent<InventoryController>();
    }
}
