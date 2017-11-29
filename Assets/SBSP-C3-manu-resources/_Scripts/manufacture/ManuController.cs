using UnityEngine;
using UnityEngine.UI;

public class ManuController : MonoBehaviour, IResearchEvent
{
    public Text name;
    public Text description;
    public Button button;
    public Text cost;

    private ManuModel _manuModel;
    private ManuView _manuView;
    private InventoryManager _inventoryManager;
    private string[] arrayOfProducts;

    void Awake()
    {
        _manuModel = new ManuModel(name, description, button, cost);
        _manuModel.GetManuView().GetManufactureButton().onClick.AddListener(Manufactureing);
    }

    public ManuModel GetManuModel()
    {
        return _manuModel;
    }

    public void Manufactureing()
    {
        _manuModel.GetManufacture().SetLearned(true);

        if(_manuModel.GetManufacture().GetName() == "Fuel")
        {
            _inventoryManager.AddItem(ItemFactory.instance.CreateItem(ItemType.Fuel));
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }

        if(_manuModel.GetManufacture().GetName() == "Ammo")
        {
            _inventoryManager.AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());

        }
        
      
        /* undecided
        StartCoroutine(_manuModel.GetTimer().StartTimerCouroutine(_manuModel.GetManufacture().GeTimeTOManufacture(), this));
        */
    }


    /*//not sure if timing is going to be used on manufacture 
    public void OnStartTimer()
    {
        _manuModel.GetManuView().DisableResearchButton();
        _manuModel.GetManuView().GetTimeButton().text = "Time left: " + _ManuModel.GetTimer().GetRemainingSecondsInt();
    }

    public void OnIncrementTimer()
    {
        _researchModel.GetResearchView().GetTimeButton().text = "Time left: " + _researchModel.GetTimer().GetRemainingSecondsInt();
    }

    public void OnFinishTimer()
    {
        _
    }
    */

    public void OnResearchLearned()
    {
        if(_manuModel.GetMainController().GetResearchController().IsResearchLearned(AllResearches.Rockets))
        {
            Debug.Log("Manufacture Rockets prefab ");
            _manuModel.GetManuPanelController().GenerateProducts();
        }
        if(_manuModel.GetMainController().GetResearchController().IsResearchLearned(AllResearches.Fuel))
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
