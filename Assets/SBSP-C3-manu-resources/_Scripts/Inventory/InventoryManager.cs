using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    [SerializeField]
    private InventoryManagerModel _inventoryManagerModel;

    public InventoryManagerModel GetInventoryManagerModel()
    {

        return _inventoryManagerModel;

    }

    void Start()
    {

        CreateInventory();

        AddItem(ItemFactory.instance.CreateItem(ItemType.Iron));

        AddItem(ItemFactory.instance.CreateItem(ItemType.Iron));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Iron));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Iron));

        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));

        AddItem(ItemFactory.instance.CreateItem(ItemType.Diamond));

        AddItem(ItemFactory.instance.CreateItem(ItemType.DarkMatter));

        AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));

        AddItem(ItemFactory.instance.CreateItem(ItemType.Fuel));
        //AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));
        AddItem(ItemFactory.instance.CreateItem(ItemType.Fuel));

        AddItem(DroidFactory.instance.CreateDroid(DroidType.RepairDroid));
        AddItem(DroidFactory.instance.CreateDroid(DroidType.SearchDroid));

        AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));

    }

    private void CreateInventory()
    {
        for (int i = 0; i < _inventoryManagerModel.GetSlotCount(); i++)
        {

            GameObject slotObject = Instantiate(_inventoryManagerModel.GetInventorySlotPrefab());
            slotObject.transform.SetParent(this.transform);
            slotObject.transform.localScale = new Vector3(1, 1, 1);

            InventorySlot slot = slotObject.GetComponent<InventorySlot>();
            _inventoryManagerModel.SetInventorySlot(slot,i);
            slot.SetInventoryManager(this);
            slot.GetInventorySlotModel().GetInventorySlotView().GetSlotButton().onClick.AddListener(slot.UseItem);

        }
    }

    public bool AddItem(Item item)
    {

        for (int i = 0; i < _inventoryManagerModel.GetSlotCount(); i++)
        {

            if (!_inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().IsEmpty())
            {
                if (!_inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().GetSlotItemHolder().IsFull() &&
                    _inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().GetSlotItemHolder().Peek().GetItemType() == item.GetItemType())
                {

                    _inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().AddItemToSlot(item);

                    return true;

                }
            }

            if (_inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().IsEmpty())
            {
                _inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().AddItemToSlot(item);
                return true;
            }
        }
       return false;
    }
}
