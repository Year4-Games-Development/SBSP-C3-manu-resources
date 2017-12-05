using UnityEngine;

public class InventoryManager : MonoBehaviour {

    [SerializeField]
    private InventoryManagerModel _inventoryManagerModel;
    private ManuController _manuController;

    public InventoryManagerModel GetInventoryManagerModel()
    {
        return _inventoryManagerModel;
    }

    void Start()
    {

        CreateInventory();
        InventoryInitialisation();

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
    
    public bool RemoveItem(ItemType item)
    {
        int i;
        for( i = 0; i < _inventoryManagerModel.GetSlotCount(); i++)
        {
            if(_inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().GetSlotItemHolder().Peek().GetItemType() == item)
            {
                for(int j = 0; j < _manuController.GetManuModel().GetManufacture().GetCost() ; j++)
                {
                    _inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().RemoveItemFromSlot();
                }
            }
        }
        return false;
    }

    public void InventoryInitialisation()
    {
        int initIronAmount = 4;
        int InitGoldAmount = 6;
        int InitAmmoAmount = 3;
        int InitFuelAmount = 5;
        int InitDroidAmount = 2;

        for(int i =0; i<initIronAmount;i++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Iron));
        }
        
        for(int g =0; g<InitGoldAmount;g++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        }

        for(int f =0;f<InitFuelAmount;f++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Fuel));
        }

        for(int a =0; a<InitAmmoAmount;a++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));
        }

        for(int d = 0; d<InitDroidAmount;d++)
        {
            AddItem(DroidFactory.instance.CreateDroid(DroidType.RepairDroid));
            AddItem(DroidFactory.instance.CreateDroid(DroidType.SearchDroid));
        }    
    }
}
