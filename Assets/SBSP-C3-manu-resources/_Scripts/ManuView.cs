using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManuView : MonoBehaviour
{
    /// <summary>
    /// /science upgrades
    /// </summary>
    public Text munufactureText;
    public Text fuel;
    public Text rockets;
    public Text ammo;

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
        ///science setters 
        munufactureText.text = manuModel.GetManufactureText();
        fuel.text = manuModel.GetFuel();
        rockets.text = manuModel.GetRockets();
        ammo.text = manuModel.GetAmmo();

    }
}
