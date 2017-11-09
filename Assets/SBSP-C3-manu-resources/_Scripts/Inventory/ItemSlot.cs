using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;


public class ItemSlot : MonoBehaviour{
    public int id;
   // private Inventory inv;
    private AddRemove ar;

    void Start()
    {
        ar = GameObject.Find("InventoryObject").GetComponent<AddRemove>();
    }
}
