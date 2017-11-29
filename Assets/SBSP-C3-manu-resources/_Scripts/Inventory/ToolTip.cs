using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
public class ToolTip : MonoBehaviour {
    private InventoryModel inventoryModel;
    private string data;
    private GameObject toolTip;

    void Start()
    {
        toolTip = GameObject.Find("ToolTip");
        toolTip.SetActive(false);
    }

    void Update()
    {
        
       if(toolTip.activeSelf)
        {
            toolTip.transform.position = Input.mousePosition;
        }
        
    }

    public void Activate(InventoryModel inventoryModel)
    {
        this.inventoryModel = inventoryModel;
        ConstructDataString();
        toolTip.SetActive(true);
    }

    public void Deactivate()
    {
        toolTip.SetActive(false);
    }

    public void ConstructDataString()
    {
        data = "<color=#FFFFFF><b>" + inventoryModel.Title + "</b></color>\n\n" + inventoryModel.Description ;
        toolTip.transform.GetChild(0).GetComponent<Text>().text=data;

    }
}*/