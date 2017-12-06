using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuPanelController : MonoBehaviour
{
    public GameObject maufacturePrefab;
    private List<Manufacture> _manufacture;
    private MainResourceController _mainController;

    public delegate void OnResearchFinished();
    public event OnResearchFinished onFinished;

    void Awake()
    {
        _manufacture = new List<Manufacture>();
        _manufacture.Add(new Manufacture("Machineguns", "You can build machineguns", AllManufacture.Machinegun, 1));
        _manufacture.Add(new Manufacture("Ammo", "Make ammo for gun", AllManufacture.Ammo, 1));
        _manufacture.Add(new Manufacture("Fuel", "Make fuel for engines", AllManufacture.Fuel, 2));
        _manufacture.Add(new Manufacture("Search Droid", "Droid used for mining ", AllManufacture.SeaechDroid, 2));
        _manufacture.Add(new Manufacture("Repair Droid", "Droid used for repairing the ship", AllManufacture.RepairDroid, 2));
    }

	// Use this for initialization
	void Start ()
    {
        GenerateProducts();
    }

    public void SetMainController(MainResourceController controller)
    {
        _mainController = controller;
    }

    public MainResourceController GetMainController()
    {
        return _mainController;
    }

    public void GenerateProducts()
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
                manuController.GetManuModel().SetManuPanelController(this);
            }
        }
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

    public void OnResearchFinishedEvent()
    {
        if (onFinished != null)
            onFinished();
    }

}
