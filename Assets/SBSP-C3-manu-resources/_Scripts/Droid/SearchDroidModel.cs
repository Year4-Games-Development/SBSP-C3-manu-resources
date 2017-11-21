using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchDroidModel : DroidModel {

    protected List<Item> _droidStorage;
    protected int _droidStorageCapacity;

    public SearchDroidModel()
    {

        _maxHealth = 100;
        _maxEnergy = 200;
        _deployTime = 15;

        _currentHealth = _maxHealth;
        _currentEnergy = _maxEnergy;

        _droidType = DroidType.SearchDroid;

        _droidStorage = new List<Item>();
        _droidStorageCapacity = 10;

        _energyConsuption = 3;

    }

    public List<Item> GetDroidStorage()
    {

        return _droidStorage;

    }


    public void SetDroidStorage(List<Item> newStorage)
    {

        _droidStorage = newStorage;

    }

    public int GetDroidStorageCapacity()
    {

        return _droidStorageCapacity;

    }

}
