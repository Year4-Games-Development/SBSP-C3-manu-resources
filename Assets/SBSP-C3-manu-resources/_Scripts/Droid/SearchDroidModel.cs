using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchDroidModel : DroidModel {

    public SearchDroidModel()
    {

        _maxHealth = 100;
        _maxEnergy = 200;
        _deployTime = 15;

        _currentHealth = _maxHealth;
        _currentEnergy = _maxEnergy;

        _droidType = DroidType.SearchDroid;

    }

}
