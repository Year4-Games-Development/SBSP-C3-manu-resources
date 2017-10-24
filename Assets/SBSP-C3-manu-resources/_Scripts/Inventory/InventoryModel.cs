using UnityEngine;

public class InventoryModel : MonoBehaviour {

    private int slotAmount = 25;
    public int SlotAmount { get { return slotAmount; } set { slotAmount = value; } }

    private int maxStackable = 99;
    public int MaxStackable { get { return maxStackable; } set { maxStackable = value; } }

    private int availableSlot;
    public int AvailableSlot { get { return availableSlot; } set { availableSlot = value; } }

}
