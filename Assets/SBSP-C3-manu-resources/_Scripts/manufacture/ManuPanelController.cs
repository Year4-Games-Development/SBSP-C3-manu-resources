using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuPanelController : MonoBehaviour, IResearchEvent
{
    public GameObject maufacturePrefab;
    private List<Manufacture> _manufacture;
    private MainResourceController _mainController;
    bool ammoIsResearched=false, MachinegunIsReearched=false,rocketsIsReserched=false, repairdroidIsResearched=false,searchDroidIsResearched=false,FuelIsResearched=false;

    void Awake()
    {
        _manufacture = new List<Manufacture>();
        _manufacture.Add(new Manufacture("Machineguns", "You can build machineguns", AllManufacture.Machinegun, 1));
        _manufacture.Add(new Manufacture("Ammo", "Make ammo for gun", AllManufacture.Ammo, 1));
        _manufacture.Add(new Manufacture("Fuel", "Make fuel for engines", AllManufacture.Fuel, 2));
        _manufacture.Add(new Manufacture("Rockets", "used for weopens", AllManufacture.Rockets, 2));
        _manufacture.Add(new Manufacture("Search Droid", "Droid used for mining ", AllManufacture.SeaechDroid, 2));
        _manufacture.Add(new Manufacture("Repair Droid", "Droid used for repairing the ship", AllManufacture.RepairDroid, 2));
    }

    void Start()
    {
        SuscribeToResearchEvent(_mainController.GetResearchController());
    }   

    public void SetMainController(MainResourceController controller)
    {
        _mainController = controller;
    }

    public MainResourceController GetMainController()
    {
        return _mainController;
    }

    public bool IsResearchLearned(AllManufacture Manufacture)
    {
        for (int i = 0; i < _manufacture.Count; i++)
        {
            if (_manufacture[i].GetManufacture() == Manufacture)
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
        if (_mainController.GetResearchController().IsResearchLearned(AllResearches.Ammo) && ammoIsResearched != true)
        {
            Debug.Log("making ammo ");
            GameObject newManuGameObject = Instantiate(maufacturePrefab);
            newManuGameObject.transform.SetParent(gameObject.transform);
            newManuGameObject.transform.localScale = new Vector3(1, 1, 1);
            ManuController manuController = newManuGameObject.GetComponent<ManuController>();
            manuController.GetManuModel().GetManuView().SetName(_manufacture[1].GetName());
            manuController.GetManuModel().GetManuView().SetDescription(_manufacture[1].GetDescription());
            manuController.GetManuModel().GetManuView().SetCost(_manufacture[1].GetCost() + "");
            manuController.GetManuModel().SetManufacture(_manufacture[1]);
            manuController.GetManuModel().SetManuPanelController(this);
            manuController.GetManuModel().GetManuView().GetManufactureButton().onClick.AddListener(manuController.Manufactureing);
            manuController.InventoryManager = _mainController.GetInventoryManager();
            ammoIsResearched = true;
        }
        if (_mainController.GetResearchController().IsResearchLearned(AllResearches.Machinegun) && MachinegunIsReearched != true)
        {
            Debug.Log("making machineguns");
            GameObject newManuGameObject = Instantiate(maufacturePrefab);
            newManuGameObject.transform.SetParent(gameObject.transform);
            newManuGameObject.transform.localScale = new Vector3(1, 1, 1);
            ManuController manuController = newManuGameObject.GetComponent<ManuController>();

            manuController.GetManuModel().GetManuView().SetName(_manufacture[0].GetName());
            manuController.GetManuModel().GetManuView().SetDescription(_manufacture[0].GetDescription());
            manuController.GetManuModel().GetManuView().SetCost(_manufacture[0].GetCost() + "");
            manuController.GetManuModel().SetManufacture(_manufacture[0]);

            manuController.GetManuModel().SetManuPanelController(this);
            manuController.GetManuModel().GetManuView().GetManufactureButton().onClick.AddListener(manuController.Manufactureing);
            manuController.InventoryManager = _mainController.GetInventoryManager();
            MachinegunIsReearched = true;
        }

        if (_mainController.GetResearchController().IsResearchLearned(AllResearches.Rockets) && rocketsIsReserched != true)
        {
            Debug.Log("making rockets");
            GameObject newManuGameObject = Instantiate(maufacturePrefab);
            newManuGameObject.transform.SetParent(gameObject.transform);
            newManuGameObject.transform.localScale = new Vector3(1, 1, 1);
            ManuController manuController = newManuGameObject.GetComponent<ManuController>();

            manuController.GetManuModel().GetManuView().SetName(_manufacture[3].GetName());
            manuController.GetManuModel().GetManuView().SetDescription(_manufacture[3].GetDescription());
            manuController.GetManuModel().GetManuView().SetCost(_manufacture[3].GetCost() + "");
            manuController.GetManuModel().SetManufacture(_manufacture[3]);

            manuController.GetManuModel().SetManuPanelController(this);
            manuController.GetManuModel().GetManuView().GetManufactureButton().onClick.AddListener(manuController.Manufactureing);
            manuController.InventoryManager = _mainController.GetInventoryManager();
            rocketsIsReserched = true;
        }

        if (_mainController.GetResearchController().IsResearchLearned(AllResearches.RepairDroid) && repairdroidIsResearched != true)
        {
            Debug.Log("making repair Droid");
            GameObject newManuGameObject = Instantiate(maufacturePrefab);
            newManuGameObject.transform.SetParent(gameObject.transform);
            newManuGameObject.transform.localScale = new Vector3(1, 1, 1);
            ManuController manuController = newManuGameObject.GetComponent<ManuController>();

            manuController.GetManuModel().GetManuView().SetName(_manufacture[5].GetName());
            manuController.GetManuModel().GetManuView().SetDescription(_manufacture[5].GetDescription());
            manuController.GetManuModel().GetManuView().SetCost(_manufacture[5].GetCost() + "");
            manuController.GetManuModel().SetManufacture(_manufacture[5]);

            manuController.GetManuModel().SetManuPanelController(this);
            manuController.GetManuModel().GetManuView().GetManufactureButton().onClick.AddListener(manuController.Manufactureing);
            manuController.InventoryManager = _mainController.GetInventoryManager();
            repairdroidIsResearched = true;
        }

        if (_mainController.GetResearchController().IsResearchLearned(AllResearches.SearchDroid) && searchDroidIsResearched != true)
        {
            Debug.Log("making searcg droid");
            GameObject newManuGameObject = Instantiate(maufacturePrefab);
            newManuGameObject.transform.SetParent(gameObject.transform);
            newManuGameObject.transform.localScale = new Vector3(1, 1, 1);
            ManuController manuController = newManuGameObject.GetComponent<ManuController>();

            manuController.GetManuModel().GetManuView().SetName(_manufacture[4].GetName());
            manuController.GetManuModel().GetManuView().SetDescription(_manufacture[4].GetDescription());
            manuController.GetManuModel().GetManuView().SetCost(_manufacture[4].GetCost() + "");
            manuController.GetManuModel().SetManufacture(_manufacture[4]);

            manuController.GetManuModel().SetManuPanelController(this);
            manuController.GetManuModel().GetManuView().GetManufactureButton().onClick.AddListener(manuController.Manufactureing);
            manuController.InventoryManager = _mainController.GetInventoryManager();
            searchDroidIsResearched = true;
        }

        if (_mainController.GetResearchController().IsResearchLearned(AllResearches.Fuel) && FuelIsResearched != true)
        {
            Debug.Log("making Fuel");
            GameObject newManuGameObject = Instantiate(maufacturePrefab);
            newManuGameObject.transform.SetParent(gameObject.transform);
            newManuGameObject.transform.localScale = new Vector3(1, 1, 1);
            ManuController manuController = newManuGameObject.GetComponent<ManuController>();

            manuController.GetManuModel().GetManuView().SetName(_manufacture[2].GetName());
            manuController.GetManuModel().GetManuView().SetDescription(_manufacture[2].GetDescription());
            manuController.GetManuModel().GetManuView().SetCost(_manufacture[2].GetCost() + "");
            manuController.GetManuModel().SetManufacture(_manufacture[2]);

            manuController.GetManuModel().SetManuPanelController(this);
            manuController.GetManuModel().GetManuView().GetManufactureButton().onClick.AddListener(manuController.Manufactureing);
            manuController.InventoryManager = _mainController.GetInventoryManager();
            FuelIsResearched = true;
        }
    }

    public void SuscribeToResearchEvent(ResearchPanelController controller)
    {
        controller.onFinished += OnResearchLearned;
    }
}
