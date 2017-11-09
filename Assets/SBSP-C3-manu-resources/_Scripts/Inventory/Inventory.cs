using System.Collections;
/**
 * View class, used to handle the User Interface
 **/

using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject background;
    public GameObject slotPanel;
    ItemDatabase database;
    AddRemove addRemove;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    public int slotAmount;

    public enum type { diamond = 0, iron = 1, gold = 2, fuel = 3 };

    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();

    private void Start()
    {

        addRemove = GetComponent<AddRemove>();


        addRemove.AddItem((int)type.diamond);
        addRemove.AddItem((int)type.diamond);
        addRemove.AddItem((int)type.diamond);
        addRemove.AddItem((int)type.iron);
        addRemove.AddItem((int)type.gold);
        addRemove.AddItem((int)type.fuel);
        addRemove.RemoveItem((int)type.diamond);
    }
}