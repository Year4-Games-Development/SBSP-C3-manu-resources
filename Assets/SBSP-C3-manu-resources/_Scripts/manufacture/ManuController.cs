using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManuController : MonoBehaviour {

    private ManuModel manuModel;

    public Button fuelBtn;
    public Button rocketBtn;
    public Button ammoBtn;
    string item;

    // Use this for initialization
    void Awake()
    {
        manuModel = new ManuModel();
    }

    public ManuModel GetManuModel()
    {
        return manuModel;
    }

    public void fuelManu()
    {
        item = "Fuel";
      //  InventoryManager.AddItem(item);
    }
    public void rocketManu()
    {
      
    }

    public void ammoManu()
    {
     
    }
}
