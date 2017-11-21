using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuController : MonoBehaviour {

<<<<<<< HEAD
    private ManuModel manuModel;
    private Inventory inven;
    public GameObject manuBtn;

    string item;

    // Use this for initialization
    void Awake()
    {
        manuModel = new ManuModel();
        inven = new Inventory();
    }

    public ManuModel GetManuModel()
    {
        return manuModel;
    }

    public void FuelManu()
    {

      item = "Fuel2";
      //inven.AddItem(item);//add item to the inventory using inventory class 

    }
    public void RocketManu()
    {
        item = "Rocket";
        //inven.AddItem(item);//add item to the inventory using inventory class 
    }

    public void AmmoManu()
    {
        item = "Ammo";
        //inven.AddItem(item);//add item to the inventory using inventory class 
    }

 
=======
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
>>>>>>> upstream/master
}
