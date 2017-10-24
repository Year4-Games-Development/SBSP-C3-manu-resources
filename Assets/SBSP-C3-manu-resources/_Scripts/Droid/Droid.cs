using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Droid controller that has the reference to DroidView and DroidModel objects;

public class Droid{


    private DroidModel _droidModel;
    private DroidView _droidView;

    public Droid()
    {

        _droidModel = new DroidModel();
        _droidView = new DroidView();

    }

    public DroidModel GetDroidModel()
    {

        return _droidModel;

    }

    public DroidView GetDroidView()
    {

        return _droidView;

    }
	
}
