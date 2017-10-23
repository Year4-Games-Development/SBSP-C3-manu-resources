using UnityEngine;

public class InventoryModel : MonoBehaviour {

    private int slotAmount = 25;
    public int SlotAmount { get { return slotAmount; } set { value = slotAmount; } }

    private int availableSlot;
    public int AvailableSlot { get { return availableSlot; } set { value = availableSlot; } }

}
