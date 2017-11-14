using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidManagerModel{

    //current and max size of bays
    private int _baySize;
    private int _maxBaySize = 2;

    private DroidBay[] _droidBayArray;

    public DroidManagerModel()
    {

        _baySize = 0;
        _droidBayArray = new DroidBay[_maxBaySize];

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
