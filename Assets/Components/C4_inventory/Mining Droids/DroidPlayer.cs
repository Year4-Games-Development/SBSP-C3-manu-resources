using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @Class DroidPlayer sets droid status
 * @auther Kevin Lardner | B00078871
 * 
 */
public class DroidPlayer : MonoBehaviour {

    private DroidPlayer miningDroid;
    public bool location; //No location set yet - to be randomised at later stage.
    public bool rested;
    public bool energy;

	/*
     * initialization
     */
	void Awake () {
        miningDroid = GetComponent<DroidPlayer>();
    }
	
    /*
     * Updates Player Status
     */
	public void UpdateDisplay ()
    {
        bool location = miningDroid.GetLocation();
        bool energy = miningDroid.GetEnergyLevel();
        bool rested = miningDroid.GetRestStatus();
        string msg = "Droid has enough energy to mine: = " + energy + "| Droid has enough rest: = " + rested + "| Droid is currently on ship: = " + location;
        print(msg);
    }

    /**
     * @Method retrieves drone location
     * @return location
     * 
     */
    public bool GetLocation()
    {
        return location;
    }

    /**
     * @Method retrieves drone energy level
     * @return energy
     * 
     */
    public bool GetEnergyLevel()
    {
        return energy;
    }

    /**
     * @Method retrieves drone rest level
     * @return rest
     * 
     */
    public bool GetRestStatus()
    {
        return rested;
    }
}
