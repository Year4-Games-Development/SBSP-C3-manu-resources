using UnityEngine;


    public class InventoryHelper : MonoBehaviour
    {

        private ItemDataView _itemDataView;
        public ItemDataView itemDataView
        {
            get
            {
                if (_itemDataView == null)
                    _itemDataView = FindObjectOfType<ItemDataView>();

                return _itemDataView;
            }
        }

        private InventoryModel _inventoryModel;
        public InventoryModel inventoryModel
        {
            get
            {
                if (_inventoryModel == null)
                    _inventoryModel = FindObjectOfType<InventoryModel>();

                return _inventoryModel;
            }
        }

        private InventoryView _inventoryView;
        public InventoryView inventoryView
        {
            get
            {
                if (_inventoryView == null)
                    _inventoryView = FindObjectOfType<InventoryView>();

                return _inventoryView;
            }
        }

        private InventoryManager _inventoryManager;
        public InventoryManager inventoryManager
        {
            get
            {
                if (_inventoryManager == null)
                    _inventoryManager = FindObjectOfType<InventoryManager>();

                return _inventoryManager;
            }
        }

        private JSonItemsData _JSonItemsData;
        public JSonItemsData jsonItemsData
        {
            get
            {
                if (_JSonItemsData == null)
                _JSonItemsData = FindObjectOfType<JSonItemsData>();

                return _JSonItemsData;
            }
        }



    }
