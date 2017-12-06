using System.Collections.Generic;
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
    public GameObject maufacturePrefab;
    private List<Manufacture> _manufacture;
    private InventoryManager _inventoryManager;

    void Awake()
    {
        _manuModel = new ManuModel(name, description, button, cost);
        _manuModel.GetManuView().GetManufactureButton().onClick.AddListener(Manufactureing);

        _manufacture = new List<Manufacture>
        {
            new Manufacture("Machineguns", "You can build machineguns", AllManufacture.Machinegun, 10),
            new Manufacture("Ammo", "Make ammo for gun", AllManufacture.Ammo, 10),
            new Manufacture("Fuel", "Make fuel for engines", AllManufacture.Fuel, 2),
            new Manufacture("Search Droid", "Droid used for mining ", AllManufacture.SeaechDroid, 2),
            new Manufacture("Repair Droid", "Droid used for repairing the ship", AllManufacture.RepairDroid, 2)
        };
    }

    void Start()
    {
        SuscribeToResearchEvent(_manuModel.GetMainController().GetResearchController());
        _manuModel = new ManuModel(name, description, button, cost);
        _manuModel.GetManuView().GetManufactureButton().onClick.AddListener(Manufactureing);
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

        /*
        if (_manuModel.GetManufacture().GetName() == "Droid")
        {
            _inventoryManager.AddItem(ItemFactory.instance.CreateItem(ItemType.Droid));
            _inventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }
        */

        /************STUFF FOR TIMING ON MANUFACTURE 
        StartCoroutine(_manuModel.GetTimer().StartTimerCouroutine(_manuModel.GetManufacture().GeTimeTOManufacture(), this));
        */
    }

    private void GenerateProducts()
    {
        for (int i = 0; i < _manufacture.Count; i++)
        {
            if (_manufacture[i].IsLearned() == true)
            {
                GameObject newManuGameObject = Instantiate(maufacturePrefab);
                newManuGameObject.transform.SetParent(gameObject.transform);
                newManuGameObject.transform.localScale = new Vector3(1, 1, 1);
                ManuController manuController = newManuGameObject.GetComponent<ManuController>();
                manuController.GetManuModel().SetManufacture(_manufacture[i]);
                manuController.GetManuModel().SetManufactureController(this);
            }
        }
    }

    public bool IsResearchLearned(AllResearches research)
    {
        for (int i = 0; i < _manufacture.Count; i++)
        {
            if (_manufacture[i].GetResearch() == research)
            {
                if (_manufacture[i].IsLearned())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }//end of for loop
        return false;
    }

    public void OnResearchLearned()
    {
        Debug.Log("OnResearchLearned called");
        if (_manuModel.GetMainController().GetResearchController().IsResearchLearned(AllResearches.Ammo))
        {
            Debug.Log("Manufacture Rockets prefab ");
            GenerateProducts();
        }
        if (_manuModel.GetMainController().GetResearchController().IsResearchLearned(AllResearches.Fuel))
        {
           Debug.Log("Manufacture Fuel prefab");
           GenerateProducts();
        }   
    }

    public void SuscribeToResearchEvent(ResearchPanelController controller)
    {
        controller.onFinished += OnResearchLearned;
    }

    /************************************CODE TO IMPLIMENT TIMEING NOT SURE IF IT IS BEING USED YET ****
    //not sure if timing is going to be used on manufacture 
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
       
    }
    */
}
