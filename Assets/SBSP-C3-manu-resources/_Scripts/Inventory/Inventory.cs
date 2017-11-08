using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Inventory : MonoBehaviour {
    //GameObject inventoryPanel;
   // GameObject inven;
    //GameObject slotMask;
    GameObject background;
    GameObject slotPanel;
    ItemDatabase database;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    int slotAmount;

    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();

    private void Start()
    {
        database = GetComponent<ItemDatabase>();

        slotAmount = 25;
        //inventoryPanel = GameObject.Find("InventoryPanel");
        //inven = GameObject.Find("Inventory");
        //slotMask = GameObject.Find("SlotPanel_Mask_ScrollRect");
        background = GameObject.Find("SlotBackgroundPanel");
        slotPanel = background.transform.Find("SlotPanel").gameObject;
        for (int i = 0; i < slotAmount; i++)
        {
            items.Add(new Item());
            slots.Add(Instantiate(inventorySlot));
            slots[i].GetComponent<ItemSlot>().id = i;
            slots[i].transform.SetParent(slotPanel.transform);
        }

        AddItem("Diamond");
        AddItem("Diamond");
        AddItem("Diamond");
        AddItem("Iron");
        AddItem("Gold");
        AddItem("Fuel2");
        RemoveItem("Diamond");
    }

    public void AddItem(string title)
    {
        Item itemToAdd = database.FetchItemByTitle(title);
        if (itemToAdd.Stackable && CheckItemInInventory(itemToAdd))
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Title == title)
                {
                    ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    Debug.Log(title);
                    break;
                }
            }
        }
        else 
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == -1)
                {
                    items[i] = itemToAdd;
                    GameObject itemObj = Instantiate(inventoryItem);
                    itemObj.GetComponent<ItemData>().item = itemToAdd;
                    itemObj.GetComponent<ItemData>().amount = 1;
                    itemObj.GetComponent<ItemData>().slot = i;
                    itemObj.transform.SetParent(slots[i].transform);
                    itemObj.transform.position = Vector2.zero;
                    itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                    itemObj.name = itemToAdd.Title;
                    break;
                }
            }
        }
    }

    public void RemoveItem(string title)
    {
        Item itemToRemove = database.FetchItemByTitle(title);
        if(itemToRemove.Stackable && CheckItemInInventory(itemToRemove))
        {
          
            for(int j=0; j < items.Count; j++)
            {
                if (items[j].Title == title)
                {
                    ItemData data = slots[j].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount--;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    if (data.amount == 0)
                    {
                        Destroy(slots[j].transform.GetChild(0).gameObject);
                        items[j] = new Item();
                        break;
                    }
                    if(data.amount == 1)
                    {
                        slots[j].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
                        break;
                    }
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Title == null && items[i].Title == title)
                {
                    Destroy(slots[i].transform.GetChild(0).gameObject); items[i] = new Item();
                    break;
                }
            }

        }
    }

        public bool CheckItemInInventory(Item item)
        {
           for(int i=0; i<items.Count; i++)
                if (items[i].Title == item.Title)
                    return true;  
                    return false;
        }
}
