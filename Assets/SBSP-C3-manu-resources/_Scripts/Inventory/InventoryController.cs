/**
 * Controller class used to handle the logic and functionality of the inventory system
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{

    Inventory inv;
    ItemDatabase database;
    public int maxSize = 64;

    private void Awake()
    {
        database = GetComponent<ItemDatabase>();
        inv = GetComponent<Inventory>();
   
        inv.slotAmount = 25;
        inv.background = GameObject.Find("SlotBackgroundPanel");
        inv.slotPanel = inv.background.transform.Find("SlotPanel").gameObject;
        for (int i = 0; i < inv.slotAmount; i++)
        {
            inv.items.Add(new InventoryModel());
            inv.slots.Add(Instantiate(inv.inventorySlot));
            inv.slots[i].GetComponent<ItemSlot>().id = i;
            inv.slots[i].transform.SetParent(inv.slotPanel.transform);
        }
    }

    public void AddItem(int id)
    {
        InventoryModel itemToAdd = database.FetchItemByID(id);
        if (itemToAdd.Stackable && CheckItemInInventory(itemToAdd))
        {
            for (int i = 0; i < inv.items.Count; i++)
            {
                if (inv.items[i].ID == id)
                {
                    ItemData data = inv.slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    break;
                }
            }
        }

        else
        {
            for (int i = 0; i < inv.items.Count; i++)
            {
                if (inv.items[i].ID == -1)
                {
                    inv.items[i] = itemToAdd;
                    GameObject itemObj = Instantiate(inv.inventoryItem);
                    itemObj.GetComponent<ItemData>().inventoryModel = itemToAdd;
                    itemObj.GetComponent<ItemData>().amount = 1;
                    itemObj.GetComponent<ItemData>().slot = i;
                    itemObj.transform.SetParent(inv.slots[i].transform);
                    itemObj.transform.position = Vector2.zero;
                    itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                    itemObj.name = itemToAdd.Title;
                    break;
                }
            }
        }
    }

    public void RemoveItem(int id)
    {
        InventoryModel itemToRemove = database.FetchItemByID(id);
        if (itemToRemove.Stackable && CheckItemInInventory(itemToRemove))
        {

            for (int j = 0; j < inv.items.Count; j++)
            {
                if (inv.items[j].ID == id)
                {
                    ItemData data = inv.slots[j].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount--;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    if (data.amount == 0)
                    {
                        Destroy(inv.slots[j].transform.GetChild(0).gameObject);
                        inv.items[j] = new InventoryModel();
                        break;
                    }
                    if (data.amount == 1)
                    {
                        inv.slots[j].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
                        break;
                    }
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < inv.items.Count; i++)
            {
                if (inv.items[i].Title == null && inv.items[i].ID == id)
                {
                    Destroy(inv.slots[i].transform.GetChild(0).gameObject); inv.items[i] = new InventoryModel();
                    break;
                }
            }

        }
    }

    public void IsFull(int id)
    {
        InventoryModel itemIsFull = database.FetchItemByID(id);
        if (itemIsFull.Stackable && CheckItemInInventory(itemIsFull))
        {
            for (int y = 0; y < inv.items.Count; y++)
            {
                if (inv.items[y].ID == id)
                {
                    ItemData data = inv.slots[y].transform.GetChild(0).GetComponent<ItemData>();
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();

                    if (data.amount > maxSize)
                    {
                        inv.slots[y].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "64";
                        data.amount = 64;
                        Debug.Log(data.amount);
                        break;
                    }
                }
            }
        }
    }

    public bool CheckItemInInventory(InventoryModel inventoryModel)
    {
        for (int i = 0; i < inv.items.Count; i++)
            if (inv.items[i].Title == inventoryModel.Title)
                return true;
        return false;
    }
}