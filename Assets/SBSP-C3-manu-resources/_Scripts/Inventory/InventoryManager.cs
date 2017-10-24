using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : InventoryHelper
{
    private int slotAmount;
    private int availableSlot;
    //Set item quantity
    private int quantity;

    private GameObject slotsParent; //Inventory panel
    private GameObject slot; //Inventory slot
    private GameObject slotItem; //Item template 

    private bool emptySlotFound;
    private bool itemAdd;
    private bool itemRemoved;

    //Holds any items added to the inventory
    public List<ItemsInInventory> itemsInInventory = new List<ItemsInInventory>();

    [System.Serializable]
    public class ItemsInInventory
    {
        public string itemNme;
        public int itemAmount;
        public int slotId; //If an item is attached
        public GameObject item;
    }

    //Use this for initialization
    void Start () {
        slotAmount = inventoryModel.SlotAmount;
        availableSlot = inventoryModel.SlotAmount;

        slotsParent = inventoryView.slotsPanel.transform.gameObject;
        slot = inventoryView.slot.transform.gameObject;
        slotItem = inventoryView.slotItem.transform.gameObject;

        GenerateInventorySlots();
    }

    //Generating slots.
    void GenerateInventorySlots() {

        for (int i = 0; i < slotAmount; i++)
        {
            GameObject obj = Instantiate(slot);
            inventoryView.slotsList.Add(obj);
            obj.transform.SetParent(slotsParent.transform);
            obj.GetComponent<ItemSlot>().id = i;
        }
    }


    public bool AddItem(string itemName)
    {
        emptySlotFound = false;
        itemAdd = false; //Method returns true if item is added.

        if (itemAdd == false)
        {
            //If there is empty slot available.
            if (availableSlot > 0)
            {
                //Loop through the slots.
                for (int i = 0; i < inventoryView.slotsList.Count; i++)
                {
                    //Checking if the slot is empty.
                    if (emptySlotFound == false && inventoryView.slotsList[i].GetComponent<ItemSlot>().occupied == false)
                    {
                        emptySlotFound = true;

                        //Find the item from the item list
                        for (int j = 0; j < jsonItemsData.itemLists.ItemClass.Count; j++)
                        {
                            //If item is available
                            if (jsonItemsData.itemLists.ItemClass[j].name == itemName)
                            {
                                //If item NOT stackable
                                if (jsonItemsData.itemLists.ItemClass[j].stackable == false)
                                {

                                    CreateItem(i, j, itemName, quantity);

                                    //Get item quantity
                                    for (int x = 0; x < itemsInInventory.Count; x++)
                                    {
                                        if (itemsInInventory[x].itemNme == itemName)
                                        {
                                            quantity = itemsInInventory[x].itemAmount;

                                            //Update item quantity
                                            itemsInInventory[x].item.GetComponent<ItemData>().Quantity = quantity;
                                            itemsInInventory[x].item.GetComponent<ItemDataView>().UpdateQuantity(quantity);

                                            itemAdd = true;
                                        }
                                    }

                                    
                                }
                                else
                                {
                                    //Stackable items

                                    bool hasItem = false;

                                    for (int x = 0; x < itemsInInventory.Count; x++)
                                    {
                                        //Check stackable amount
                                        if (itemsInInventory[x].itemAmount < inventoryModel.MaxStackable)
                                        {
                                            if (itemsInInventory[x].itemNme == itemName)
                                            {
                                                hasItem = true;

                                                int temp = itemsInInventory[x].itemAmount;
                                                int newQuantity = temp + 1;
                                                itemsInInventory[x].itemAmount = newQuantity;
                                                quantity = itemsInInventory[x].itemAmount;

                                                //Update item quantity
                                                itemsInInventory[x].item.GetComponent<ItemData>().Quantity = quantity;
                                                itemsInInventory[x].item.GetComponent<ItemDataView>().UpdateQuantity(quantity);

                                                itemAdd = true;
                                            }

                                        }
                                    }

                                    if (hasItem == false)
                                    {
                                        CreateItem(i, j, itemName, quantity);

                                        //Get item quantity
                                        for (int x = 0; x < itemsInInventory.Count; x++)
                                        {
                                            if (itemsInInventory[x].itemNme == itemName)
                                            {
                                                quantity = itemsInInventory[x].itemAmount;
                                                itemsInInventory[x].item.GetComponent<ItemData>().Quantity = quantity;
                                                itemsInInventory[x].item.GetComponent<ItemDataView>().UpdateQuantity(quantity);

                                                itemAdd = true;
                                            }
                                        }

                                    }

                                }
                            }
                            else
                            {
                                //Debug.Log(">>>>>>>>> Item does not exit! <<<<<<<<");
                                itemAdd = false;
                            }

                        }

                    }
                }
            }//availableSlot
            else
            {
                //Debug.Log(">>>>>>>>> Inventory is full! <<<<<<<<");
                itemAdd = false;
            }
        }//bool end

        return itemAdd;
    }

    //Creating the item.
    public void CreateItem(int i, int j, string itemName, int itemQuantity)
    {
        //Instantiate the item
        GameObject obj = Instantiate(slotItem);

        //The slot id.
        int itemSlotId = i;

        //Store item added inventory.
        AddToItemsInInventory(itemSlotId, itemName, 1, obj);

        //Set the parent
        obj.transform.SetParent(inventoryView.slotsList[i].transform);

        //Set item icon
        obj.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Items/" + jsonItemsData.itemLists.ItemClass[j].spriteName);

        //Set occupied to true
        inventoryView.slotsList[i].GetComponent<ItemSlot>().occupied = true;

        //Add the item information
        obj.gameObject.GetComponent<ItemData>().Name = jsonItemsData.itemLists.ItemClass[j].name;
        obj.GetComponent<ItemData>().Value = jsonItemsData.itemLists.ItemClass[j].value;
        obj.GetComponent<ItemData>().Power = jsonItemsData.itemLists.ItemClass[j].power;
        obj.GetComponent<ItemData>().Defence = jsonItemsData.itemLists.ItemClass[j].defence;
        obj.GetComponent<ItemData>().Weight = jsonItemsData.itemLists.ItemClass[j].weight;
        obj.GetComponent<ItemData>().Description = jsonItemsData.itemLists.ItemClass[j].description;
        obj.GetComponent<ItemData>().Stackable = jsonItemsData.itemLists.ItemClass[j].stackable;
        obj.GetComponent<ItemData>().Rarity = jsonItemsData.itemLists.ItemClass[j].rarity;
        obj.GetComponent<ItemData>().SpriteName = jsonItemsData.itemLists.ItemClass[j].spriteName;

        itemAdd = true;
        availableSlot -= 1;
    }

    //Adding the item to the item in inventory list.
    void AddToItemsInInventory(int itemSlotId, string name, int amount, GameObject item)
    {
        ItemsInInventory addItemsInInventory = new ItemsInInventory();
        addItemsInInventory.slotId = itemSlotId;
        addItemsInInventory.itemNme = name;
        addItemsInInventory.itemAmount = amount;
        addItemsInInventory.item = item;

        itemsInInventory.Add(addItemsInInventory);
    }

    //Removing item from the innventory.
    public bool RemoveItem(int itemSlotId, string itemName)
    {
        itemRemoved = false;

        if (itemRemoved == false)
        {

            for (int x = 0; x < itemsInInventory.Count; x++)
            {
                if (itemsInInventory[x].slotId == itemSlotId)
                {
                    string tempName = itemsInInventory[x].itemNme;
                    int tempAmount = itemsInInventory[x].itemAmount;

                    GameObject tempGameObject = itemsInInventory[x].item;

                    if (tempAmount == 1)
                    {
                        //Get the item parent.
                        GameObject itemParent = tempGameObject.transform.parent.gameObject;

                        //Get item
                        GameObject go = itemParent.transform.GetChild(0).gameObject;

                        //Get the item parent scrept and set the occupied to false.
                        itemParent.GetComponent<ItemSlot>().occupied = false;

                        //Remove it from the items in inventory.
                        itemsInInventory.RemoveAt(x);

                        itemRemoved = true;

                        Destroy(go);
                    }
                    else if (tempAmount > 1)
                    {
                        int newQuantity = tempAmount - 1;
                        itemsInInventory[x].itemAmount = newQuantity;
                        quantity = itemsInInventory[x].itemAmount;

                        itemsInInventory[x].item.GetComponent<ItemData>().Quantity = quantity;
                        itemsInInventory[x].item.GetComponent<ItemDataView>().UpdateQuantity(quantity);

                        itemRemoved = true;
                    }
                    else
                    {
                        //Item not removed.
                        itemRemoved = false;
                    }

                }
            }
        }

        return itemRemoved;

    }

    //Checking if the inventory is full
    public bool IsFull()
    {
        bool checkIfInventoryIsFull = false;

        if (availableSlot == 0)
        {
            checkIfInventoryIsFull = true;
        }
        return checkIfInventoryIsFull;
    }


}
