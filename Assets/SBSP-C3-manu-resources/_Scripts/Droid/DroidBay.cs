using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroidBay
{
    private DroidBayModel _droidBayModel;
    private DroidBayView _droidBayView;

    public DroidBay()
    {

        _droidBayModel = new DroidBayModel();
        _droidBayView = new DroidBayView();

    }

    public DroidBayModel GetDroidModel()
    {

        return _droidBayModel;

    }

    public DroidBayView GetDroidView()
    {

        return _droidBayView;

    }
}
