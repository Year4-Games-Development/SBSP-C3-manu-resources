using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManuController : MonoBehaviour, IResearchEvent
{
    public Text itemName;
    public Text description;
    public Button button;
    public Text cost;

    private ManuModel _manuModel;
    private ManuView _manuView;
    private InventoryManager _inventoryManager;

    void Awake()
    {
        _manuModel = new ManuModel(itemName, description, button, cost);
        _manuModel.GetManuView().GetManufactureButton().onClick.AddListener(Manufactureing); 
    }

    void Start()
    {
        SuscribeToResearchEvent(_manuModel.GetMainController().GetResearchController());
    }

    public ManuModel GetManuModel()
    {
        return _manuModel;
    }

    public void Manufactureing()
    {

        if (_manuModel.GetManufacture().GetName() == "Fuel")
        {
            _inventoryManager.AddItem(ItemFactory.instance.CreateItem(ItemType.Fuel));
            _inventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }
        
        if (_manuModel.GetManufacture().GetName() == "Ammo")
        {
            _inventoryManager.AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));
            _inventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }

        if (_manuModel.GetManufacture().GetName() == "Search Droid")
        {
            _inventoryManager.AddItem(DroidFactory.instance.CreateDroid(DroidType.SearchDroid));
            _inventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }

        if (_manuModel.GetManufacture().GetName() == "Repair Droid")
        {
            _inventoryManager.AddItem(DroidFactory.instance.CreateDroid(DroidType.RepairDroid));
            _inventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }
    }

    public void OnResearchLearned()
    {
        Debug.Log("OnResearchLearned called");
        if (_manuModel.GetMainController().GetManuController().IsResearchLearned(AllManufacture.Ammo))
        {
            Debug.Log("Manufacture ammo prefab ");
            _manuModel.GetManuPanelController().GenerateProducts();
        }
        if (_manuModel.GetMainController().GetManuController().IsResearchLearned(AllManufacture.Fuel))
        {
           Debug.Log("Manufacture Fuel prefab");
            _manuModel.GetManuPanelController().GenerateProducts();
        }   
    }

    public void SuscribeToResearchEvent(ResearchPanelController controller)
    {
        controller.onFinished += OnResearchLearned;
    }
}
