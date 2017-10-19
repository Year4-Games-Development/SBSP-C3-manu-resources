using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroidBay : MonoBehaviour
{
    public Button deployButton;
    public Button upgradeButton;
    public Button removeButton;

    private DroidBayModel _droidBayModel;
    private DroidBayView _droidBayView;

    void Awake()
    {
        _droidBayModel = new DroidBayModel();

        deployButton.onClick.AddListener(DeployDroid);
        upgradeButton.onClick.AddListener(UpgradeDroid);
        removeButton.onClick.AddListener(RemoveDroid);

        _droidBayView = new DroidBayView(deployButton, upgradeButton, removeButton);
    }

    public DroidBayModel GetDroidBayModel()
    {
        return _droidBayModel;
    }

    public DroidBayView GetDroidView()
    {
        return _droidBayView;
    }

    public void DeployDroid()
    {

        Debug.Log("Deploying from: " + _droidBayModel.GetBayIndex());

    }

    public void UpgradeDroid()
    {

        Debug.Log("Upgrading from: " + _droidBayModel.GetBayIndex());

    }

    public void RemoveDroid()
    {

        Debug.Log("Removing from: " + _droidBayModel.GetBayIndex());

    }
}
