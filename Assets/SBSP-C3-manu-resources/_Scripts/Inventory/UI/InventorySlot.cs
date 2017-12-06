using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour{

    [SerializeField]
    private InventorySlotModel _inventorySlotModel;
    private InventoryManager _inventoryManager;

    public void SetInventoryManager(InventoryManager manager)
    {
    
        _inventoryManager = manager;

    }

    public InventoryManager GetInventoryManager()
    {

        return _inventoryManager;

    }

    public InventorySlotModel GetInventorySlotModel()
    {

        return _inventorySlotModel;

    }

    public void UseItem()
    {
        if (_inventorySlotModel.GetSlotItemHolder() != null)
        {
            if (_inventorySlotModel.GetSlotItemHolder().Peek() != null && !_inventorySlotModel.GetSlotItemHolder().IsEmpty())
            {

                if (_inventorySlotModel.GetSlotItemHolder().Peek().UseItem(_inventoryManager.GetInventoryManagerModel().GetMainController(), _inventorySlotModel.GetSlotItemHolder().Peek()))
                    PopAndClean();

            }
        }

    }

    public void PopAndClean()
    {

        _inventorySlotModel.GetSlotItemHolder().Pop();
        UpdateHolder();



    }

    public void UpdateHolder()
    {

        if (_inventorySlotModel.GetSlotItemHolder().IsEmpty())
        {
            _inventorySlotModel.SetSlotItemHolder(null);
            _inventorySlotModel.GetInventorySlotView().DisableAllUI();

        }

    }
}
