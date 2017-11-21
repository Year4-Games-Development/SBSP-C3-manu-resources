using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuPanelController : MonoBehaviour
{
    public GameObject maufacturePrefab;
    private List<Manufacture> _manufacture;
    private MainResourceController mainController;

    //private ManuModel _manufactureModel;
    //private ManuController manuController;

    public delegate void OnManufactureFinished();
    public event OnManufactureFinished onFinished;

    void awake()
    {
        _manufacture = new List<Manufacture>();
        _manufacture.Add(new Manufacture("More Bays", "You can build more bays", AllManufacture.More_Bays, 20));
        _manufacture.Add(new Manufacture("Machineguns", "You can build machineguns", AllManufacture.Machinegun, 15));
        _manufacture.Add(new Manufacture("Rockets", "Learn to make rockets", AllManufacture.Rockets, 60));
    }
	
	// Update is called once per frame
	void Start()
    {
        GenerateButtons();
    }

    public void SetMainController(MainResourceController controller)
    {
        mainController = controller;
    }

    public MainResourceController GetMainController()
    {
        return mainController;
    }

    private void GenerateButtons()
    {
        if (_manufacture.Count<1)
        {
            // print in text nothing to manufacture 
        }
        else
        {
            for (int i = 0; i < _manufacture.Count; i++)// && _researches[i].IsLearned()==true
            {
                GameObject newManuGameObject = Instantiate(maufacturePrefab);
                newManuGameObject.transform.SetParent(gameObject.transform);
                newManuGameObject.transform.localScale = new Vector3(1, 1, 1);

                //ManuController manuController = newManuGameObject.GetComponent<ManuController>();
               // manuController.GetManuModel().SetManufacture(_manufacture[i]);
               // manuController.GetManuModel().SetManufacturePanelController(this);
            }
        }
    }


    public void OnManufactureFinishedEvent()
    {

        //needs to be rewrote 
        if (onFinished != null)
            onFinished();
    }
}
