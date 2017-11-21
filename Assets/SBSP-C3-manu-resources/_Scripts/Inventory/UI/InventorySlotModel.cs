using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlotModel{

    [SerializeField]
    private InventorySlotView _inventorySlotView;

    private ItemHolder _itemHolder;

    public InventorySlotView GetInventorySlotView()
    {

        return _inventorySlotView;

    }

    public ItemHolder GetSlotItemHolder()
    {

        return _itemHolder;

    }

    public void SetSlotItemHolder(ItemHolder holder)
    {

        _itemHolder = holder;

    }

    public void AddItemToSlot(Item item)
    {

        if (_itemHolder == null)
        {
            _itemHolder = new ItemHolder(item.GetStackable());
        }

        _itemHolder.Push(item);

        _inventorySlotView.SetItemName(_itemHolder.Peek().GetItemName());
        _inventorySlotView.SetItemImage(_itemHolder.Peek().GetItemImage());
        _inventorySlotView.SetItemCount(_itemHolder.GetSize(), _itemHolder.Peek().GetStackable());
        
    }

    public bool IsEmpty()
    {

        if (_itemHolder == null)
            return true;

        return _itemHolder.IsEmpty(); 

    }

    public bool IsFull()
    {

        if (_itemHolder == null)
            return true;

        return _itemHolder.IsFull();

    }

}
