using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairDroidModel : DroidModel
{

    public RepairDroidModel()
    {

        _maxHealth = 150;
        _maxEnergy = 100;
        _deployTime = 25;

        _currentHealth = _maxHealth;
        _currentEnergy = _maxEnergy;

        _droidType = DroidType.RepairDroid;
    }

}
