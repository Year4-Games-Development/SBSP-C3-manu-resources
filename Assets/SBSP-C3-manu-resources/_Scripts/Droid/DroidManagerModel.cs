using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidManagerModel{

    private MainResourceController _mainController;

    //current and max size of bays
    private int _baySize;
    private int _maxBaySize = 2;

    private DroidBay[] _droidBayArray;

    public DroidManagerModel()
    {

        _baySize = 0;
        _droidBayArray = new DroidBay[_maxBaySize];

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

        _droidBayArray[_baySize] = newBay;

    }

    public void SetBaySize(int value)
    {

        _baySize = value;

    }

    public int GetMaxBaySize()
    {

        return _maxBaySize;

    }
	
}
