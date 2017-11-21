using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidManagerModel
{

    private MainResourceController _mainController;

    //current and max size of bays
    private int _baySize;
    private int _maxBaySize = 2;

    private List<DroidBay> _droidBayArray;

    public DroidManagerModel()
    {

        _baySize = 0;
        _droidBayArray = new List<DroidBay>();

    }

    public void SetMainController(MainResourceController controller)
    {

        _mainController = controller;

    }

    public MainResourceController GetMainController()
    {

        return _mainController;

    }

    public int GetCurrentSize()
    {

        return _baySize;

    }

    public void AddNewBay(DroidBay newBay)
    {

        _droidBayArray.Add(newBay);

    }

    public void SetBaySize(int value)
    {

        _baySize = value;

    }

    public int GetMaxBaySize()
    {

        return _maxBaySize;

    }

    public void SetMaxBaySize(int value)
    {

        _maxBaySize = value;

    }

    public DroidBay GetDroidBay(int value)
    {

        return _droidBayArray[value];

    }
	
}
