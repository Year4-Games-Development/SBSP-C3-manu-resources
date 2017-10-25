using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour {
    private Item item;
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

    public void Activate(Item item)
    {
        this.item = item;
        ConstructDataString();
        toolTip.SetActive(true);
    }

    public void Deactivate()
    {
        toolTip.SetActive(false);
    }

    public void ConstructDataString()
    {
        data = "<color=#FD0606><b>" + item.Title + "</b></color>\n\n" + item.Description ;
        toolTip.transform.GetChild(0).GetComponent<Text>().text=data;
    }
}
