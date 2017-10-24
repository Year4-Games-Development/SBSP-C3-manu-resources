using UnityEngine;

public class CollectibleItems : InventoryHelper
{
    //Add item to inventory
    public void ItemClicked()
    {
        //This game object
        GameObject go = gameObject;

        //Get item name
        string itemName = gameObject.name;

        //Calling the inventory add item method.
        inventoryManager.AddItem(itemName);

        //Destroy item after its been clicked.
        Destroy(go);
    }

}
