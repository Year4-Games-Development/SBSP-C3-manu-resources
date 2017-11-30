using System.Collections.Generic;
using UnityEngine;

public class ManuPanelController : MonoBehaviour
{
    public GameObject maufacturePrefab;
    private List<Manufacture> _manufacture;
    private MainResourceController mainController;
    private ManuModel _manuModel;

    //private ManuModel _manufactureModel;
    //private ManuController manuController;

    public delegate void OnManufactureFinished();
    public event OnManufactureFinished onFinished;

    void awake()
    {
        _manufacture = new List<Manufacture>();
        _manufacture.Add(new Manufacture("Machineguns", "You can build machineguns", AllManufacture.Machinegun, 10));
        _manufacture.Add(new Manufacture("Rockets", "Make rockets", AllManufacture.Rockets, 10));
        _manufacture.Add(new Manufacture("Fuel", "Make fuel for engines", AllManufacture.Fuel, 2));
    }

    // Update is called once per frame
    void Start()
    {

    }

    public void SetMainController(MainResourceController controller)
    {
        mainController = controller;
    }

    public MainResourceController GetMainController()
    {
        return mainController;
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
                manuController.GetManuModel().SetManufacturePanelController(this);
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
                return false;
            }
        }//end of forloop 

        return false;
    }

    public void OnResearchFinishedEvent()
    {
        //needs to be rewrote 
        if (onFinished != null)
            onFinished();
    }

}