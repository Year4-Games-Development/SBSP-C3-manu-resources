using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @Class DroidPlayer sets droid status
 * @auther Kevin Lardner | B00078871
 * 
 */
public class DroidPlayer : MonoBehaviour {
    /**
     * Location = droid status - flying, recharging, mining
     * Energy = droid is recharged TRUE or FALSE
     */
    private DroidPlayer miningDroid;
    public bool location;
    public bool energy;

	/*
     * initialization
     */
	void Awake () {
        miningDroid = GetComponent<DroidPlayer>();
    }
	
    /*
     * Updates Droid Status
     */
	public void UpdateDisplay ()
    {
        bool location = miningDroid.GetLocation();
        bool energy = miningDroid.GetEnergyStatus();

        string msg = "Droid is recharged: = " + energy + " | Droid is currently: = " + location;
        print(msg);
    }

    /**
     * @Method retrieves drone location
     * @return location
     */
    public bool GetLocation()
    {
        return location;
    }

    /**
     * @Method retrieves drone energy level
     * @return energy
     */
    public bool GetEnergyStatus()
    {
        return energy;
    }
}
