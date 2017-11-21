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
    InventoryController inventoryController;
    public GameObject inventorySlot;
    public GameObject inventoryItem;
    public int slotAmount;

    public enum type { diamond = 0, iron = 1, gold = 2, fuel = 3 };

    public List<InventoryModel> items = new List<InventoryModel>();
    public List<GameObject> slots = new List<GameObject>();

    private void Start()
    {

        inventoryController = GetComponent<InventoryController>();

        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.diamond);
        inventoryController.AddItem((int)type.gold);
        inventoryController.AddItem((int)type.fuel);

       inventoryController.IsFull((int)type.diamond);
    }
}