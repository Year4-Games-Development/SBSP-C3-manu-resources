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
        for(int i = 0; i < _inventoryManagerModel.GetSlotCount(); i++)
        {
            if(_inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().GetSlotItemHolder().Peek().GetItemType() == item)
            {
                if (!_inventoryManagerModel.GetInventorySlotAtIndex(i).GetInventorySlotModel().GetSlotItemHolder().IsEmpty())
                {
                    _inventoryManagerModel.GetInventorySlotAtIndex(i).PopAndClean();
                    return true;
                }
            }
        }
        return false;
    }

    public void InventoryInitialisation()
    {
        int initIronAmount = 4;
        int initGoldAmount = 6;
        int initAmmoAmount = 3;
        int initFuelAmount = 5;
        int initDroidAmount = 2;
        int initDarkMatterAmonut = 5;

        for(int i =0; i<initIronAmount;i++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Iron));
        }
        
        for(int g =0; g<initGoldAmount;g++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Gold));
        }

        for(int f =0;f<initFuelAmount;f++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Fuel));
        }

        for(int a =0; a<initAmmoAmount;a++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));
        }

        for(int rd = 0; rd<initDroidAmount;rd++)
        {
            AddItem(DroidFactory.instance.CreateDroid(DroidType.RepairDroid));
        }

        for (int sd = 0; sd < initDroidAmount; sd++)
        {
            AddItem(DroidFactory.instance.CreateDroid(DroidType.SearchDroid));
        }

        for (int dm = 0; dm < initDarkMatterAmonut; dm++)
        {
            AddItem(ItemFactory.instance.CreateItem(ItemType.DarkMatter)); ;
        }
    }

}
