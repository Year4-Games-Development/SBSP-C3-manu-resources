using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item{

    protected string _itemName;
    protected Sprite _itemImage;
    protected ItemType _itemType;
    protected int _stackable;

    public Item()
    {

        _itemType = new ItemType();

    }


    public void AddItemImage(Sprite sprite)
    {

        _itemImage = sprite;

    }

    public Sprite GetItemImage()
    {

        return _itemImage;

    }

    public ItemType GetItemType()
    {

        return _itemType;

    }

    public void SetItemType(ItemType type)
    {

        _itemType = type;

    }

    public string GetItemName()
    {

        return _itemName;

    }

    public void SetItemName(string name)
    {

        _itemName = name;

    }

    public void SetStackable(int value)
    {

        _stackable = value;

    }

    public int GetStackable()
    {

        return _stackable;

    }

    public virtual bool UseItem(MainResourceController main, Item item)
    {

        return false;

    }

}

public enum ItemType
{
    Iron,
    Gold,
    Fuel,
    Ammo,
    Droid
    
}
