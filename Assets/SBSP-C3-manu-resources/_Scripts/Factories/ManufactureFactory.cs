
using UnityEngine;

[System.Serializable]
public class ManufactureFactory
{
    public static ManufactureFactory instance;

    public Sprite ammoImage;
    public Sprite fuelImage;

    public ManufactureFactory()
    {
        instance = this;
    }

    public Item CreateItem(ItemType type)
    {
        if (type == ItemType.Fuel)
        {

            Item fuel = new Item();
            fuel.SetItemName("Fuel");
            fuel.SetItemType(ItemType.Fuel);
            fuel.AddItemImage(fuelImage);
            fuel.SetStackable(5);

            return fuel;
        }
        
       if (type == ItemType.Ammo)
        {

            Item ammo = new Item();
            ammo.SetItemName("Fuel");
            ammo.SetItemType(ItemType.Fuel);
            ammo.AddItemImage(fuelImage);
            ammo.SetStackable(5);

            return ammo;

        }
        return null;

    }
}
