using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroidBay : MonoBehaviour, ITimeable
{

    public Button deployButton;
    public Button upgradeButton;
    public Button removeButton;
    public Button rechargeButton;
    public Button repairButton;
    public Text statusText;
    public Text droidTypeText;
    public Text deployTimeText;
    public Text droidHealthText;
    public Text droidEnergyText;
    public Image droidImage;

    [SerializeField]
    private DroidBayModel _droidBayModel;

    void Awake()
    {

        _droidBayModel = new DroidBayModel(deployButton, upgradeButton, removeButton,rechargeButton,repairButton, statusText,droidTypeText,deployTimeText, droidImage, droidHealthText, droidEnergyText);

        _droidBayModel.GetDroidBayView().GetDeployButton().onClick.AddListener(DeployDroid);
        _droidBayModel.GetDroidBayView().GetUpgradeButton().onClick.AddListener(UpgradeDroid);
        _droidBayModel.GetDroidBayView().GetRemoveButton().onClick.AddListener(RemoveDroid);
        _droidBayModel.GetDroidBayView().GetRepairButton().onClick.AddListener(RepairDroid);
        _droidBayModel.GetDroidBayView().GetRechargeButton().onClick.AddListener(RechargeDroid);

    }

    public DroidBayModel GetDroidBayModel()
    {
        return _droidBayModel;
    }

    public void DeployDroid()
    {
        if (_droidBayModel.GetDroid() != null)
        {
            if (_droidBayModel.GetDroid().GetDroidModel().GetDroidCurrentEnergy() < _droidBayModel.GetDroid().GetDroidModel().GetEnergyConsumption() * _droidBayModel.GetDroid().GetDroidModel().GetDroidDeployTime())
                return;

            StartCoroutine(_droidBayModel.GetTimer().StartTimerCouroutine(_droidBayModel.GetDroid().GetDroidModel().GetDroidDeployTime(), this));

        }
    }

    public void UpgradeDroid()
    {
        if (_droidBayModel.GetDroid() == null)
        {

            //Droid newDroid = DroidFactory.instance.CreateDroid(DroidType.SearchDroid);
            //.GetDroidModel().SetCurrentDroidBay(this);

            //AddDroidToBay(newDroid);

        }

    }

    public void RemoveDroid()
    {

        Debug.Log("Removing");

        if (GetDroidBayModel().GetDroid().GetDroidModel().GetDroidState() == DroidState.Ready)
        {
            GetDroidBayModel().GetDroidManager().GetDroidManagerModel().GetMainController().GetInventoryManager().AddItem(GetDroidBayModel().GetDroid());
            GetDroidBayModel().SetDroid(null);

            GetDroidBayModel().GetDroidBayView().CleanBay();
        }

    }

    public void RepairDroid()
    {

        Debug.Log("Repairing");

    }

    public void RechargeDroid()
    {

        Debug.Log("Recharging");

    }

    public void OnStartTimer()
    {
        _droidBayModel.OnStartTimer();
        GetDroidBayModel().GetDroid().GetDroidModel().SetDroidState(DroidState.Deployed);
    }

    public void OnIncrementTimer()
    {
        _droidBayModel.OnIncrementTimer();
        _droidBayModel.GetDroid().PerformDroidAction();
    }

    public void OnFinishTimer()
    {
        _droidBayModel.OnFinishTimer();
        StopCoroutine(_droidBayModel.GetTimer().GetCurrentCouroutine());
        _droidBayModel.GetDroid().FinishDroidAction();
        GetDroidBayModel().GetDroid().GetDroidModel().SetDroidState(DroidState.Ready);
    }

    public bool AddDroidToBay(Droid droid)
    {

        if (!_droidBayModel.SetDroid(droid))
            return false;

        return true;

    }

    public void OnResearchLearned()
    {
        Debug.Log("Research learned, called from: " + this);
        //if correct research learned
    }

}
