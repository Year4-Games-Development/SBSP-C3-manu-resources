using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventoryManagerModel{

    private MainResourceController _mainController;

    [SerializeField]
    private GameObject _inventorySlotPrefab;
    public InventorySlot[] _inventorySlots;
    public static int _slotCount;

    public InventoryManagerModel()
    {
        _slotCount = 30;
        _inventorySlots = new InventorySlot[_slotCount];
    }

    public int GetSlotCount()
    {

        return _slotCount;
    }

    public void SetInventorySlot(InventorySlot slot, int index)
    {
        _inventorySlots[index] = slot;
        slot.GetInventorySlotModel().GetInventorySlotView().Initialize();
    }

    public InventorySlot GetInventorySlotAtIndex(int index)
    {

        return _inventorySlots[index];

    }

    public GameObject GetInventorySlotPrefab()
    {

        return _inventorySlotPrefab;

    }

    public void SetMainController(MainResourceController controller)
    {

        _mainController = controller;

    }

    public MainResourceController GetMainController()
    {

        return _mainController;

    }

}
