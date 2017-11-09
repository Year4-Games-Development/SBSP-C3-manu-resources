/**
 * Controller class used to handle the logic and functionality of the inventory system
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRemove : MonoBehaviour
{

    Inventory inv;
    ItemDatabase database;



    private void Start()
    {
        database = GetComponent<ItemDatabase>();
        inv = GetComponent<Inventory>();

        inv.slotAmount = 25;
        inv.background = GameObject.Find("SlotBackgroundPanel");
        inv.slotPanel = inv.background.transform.Find("SlotPanel").gameObject;
        for (int i = 0; i < inv.slotAmount; i++)
        {
            inv.items.Add(new Item());
            inv.slots.Add(Instantiate(inv.inventorySlot));
            inv.slots[i].GetComponent<ItemSlot>().id = i;
            inv.slots[i].transform.SetParent(inv.slotPanel.transform);
        }
    }

    public void AddItem(int id)
    {
        Item itemToAdd = database.FetchItemByID(id);
        if (itemToAdd.Stackable && CheckItemInInventory(itemToAdd))
        {
            for (int i = 0; i < inv.items.Count; i++)
            {
                if (inv.items[i].ID == id)
                {
                    ItemData data = inv.slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    Debug.Log(id);
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
                    itemObj.GetComponent<ItemData>().item = itemToAdd;
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
        Item itemToRemove = database.FetchItemByID(id);
        if (itemToRemove.Stackable && CheckItemInInventory(itemToRemove))
        {

            for (int j = 0; j < inv.items.Count; j++)
            {
                if (inv.items[j].ID == id)
                {
                    ItemData data = inv.slots[j].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount--;
                    //   data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    if (data.amount == 0)
                    {
                        Destroy(inv.slots[j].transform.GetChild(0).gameObject);
                        inv.items[j] = new Item();
                        break;
                    }
                    if (data.amount == 1)
                    {
                        // slots[j].transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = "";
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
                    Destroy(inv.slots[i].transform.GetChild(0).gameObject); inv.items[i] = new Item();
                    break;
                }
            }

        }
    }

    public bool CheckItemInInventory(Item item)
    {
        for (int i = 0; i < inv.items.Count; i++)
            if (inv.items[i].Title == item.Title)
                return true;
        return false;
    }
}
