using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManuView : MonoBehaviour
{
    /// <summary>
    /// /science upgrades
    /// </summary>
    public Text manufactureText;
    public Text fuelBtn;
    public Text rocketBtn;
    public Text ammoBtn;

    private ManuController manuController;
    private ManuModel manuModel;

    void Awake()
    {
        manuController = GetComponent<ManuController>();     
    }

    // Use this for initialization
    void Start()
    {
        manuModel = manuController.GetManuModel();
        UpdateViews();
    }

    void Update()
    {
        UpdateViews();
    }

    private void UpdateViews()
    {
        ///manufacture button text 
        manufactureText.text = manuModel.GetManufactureText();
        fuelBtn.text = manuModel.GetFuelText();
        rocketBtn.text = manuModel.GetRocketText();
        ammoBtn.text = manuModel.GetAmmoText();
    }
}
