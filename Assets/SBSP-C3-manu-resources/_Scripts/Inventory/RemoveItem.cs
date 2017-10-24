using UnityEngine;

public class RemoveItem : InventoryHelper {

    public void UseItem()
    {
        //Getting child count.
        int count = gameObject.transform.childCount;

        if (count == 1)
        {
            // Getting slot id
            int itemSlotId = gameObject.GetComponent<ItemSlot>().id;

            //Getting game object child
            GameObject go = gameObject.transform.GetChild(0).gameObject;

            //Getting item name
            string itemName = go.GetComponent<ItemData>().Name;

            //Remove the item.
            inventoryManager.RemoveItem(itemSlotId, itemName);
        }
    }
}
