using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemFactory{

    public static ItemFactory instance;

    public Sprite ironImage;
    public Sprite goldImage;
    public Sprite fuelImage;

    public ItemFactory()
    {

        instance = this;

    }

    public Item CreateItem(ItemType type)
    {

        if(type == ItemType.Iron)
        {

            Item iron = new Item();
            iron.SetItemName("Iron");
            iron.SetItemType(ItemType.Iron);
            iron.AddItemImage(ironImage);
            iron.SetStackable(20);

            return iron;

        }

        if (type == ItemType.Gold)
        {
            Item gold = new Item();
            gold.SetItemName("Gold");
            gold.SetItemType(ItemType.Gold);
            gold.AddItemImage(goldImage);
            gold.SetStackable(2);

            return gold;

        }

        if (type == ItemType.Fuel)
        {

            Item fuel = new Item();
            fuel.SetItemName("Fuel");
            fuel.SetItemType(ItemType.Fuel);
            fuel.AddItemImage(fuelImage);
            fuel.SetStackable(5);

            return fuel;

        }

        return null;

    }
}
