using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ItemData : MonoBehaviour,  IPointerEnterHandler, IPointerExitHandler
{
    public Item item;
    public int amount;
    public int slot;

    private Inventory inv;
    private ToolTip toolTip;
    private Vector2 offset;

    void Start()
    {
        inv = GameObject.Find("InventoryObject").GetComponent<Inventory>();
        toolTip = inv.GetComponent<ToolTip>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        toolTip.Activate(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        toolTip.Deactivate();
    }
}
