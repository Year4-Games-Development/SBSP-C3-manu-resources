using UnityEngine;

[System.Serializable]
public class ItemFactory
{

    public static ItemFactory instance;

    public Sprite ironImage;
    public Sprite goldImage;
    public Sprite fuelImage;
    public Sprite ammoImage;
    public Sprite darkMatterImage;
    public Sprite diamondImage;

    public ItemFactory()
    {
        instance = this;
    }

    public Item CreateItem(ItemType type)
    {

        if (type == ItemType.Iron)
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

        if (type == ItemType.Ammo)
        {
            Item ammo = new Item();
            ammo.SetItemName("Ammo");
            ammo.SetItemType(ItemType.Ammo);
            ammo.AddItemImage(ammoImage);
            ammo.SetStackable(50);
            return ammo;
        }

        if (type == ItemType.Diamond)
        {
            Item diamond = new Item();
            diamond.SetItemName("Diamond");
            diamond.SetItemType(ItemType.Diamond);
            diamond.AddItemImage(diamondImage);
            diamond.SetStackable(64);

            return diamond;
        }

        if (type == ItemType.DarkMatter)
        {
            Item darkMatter = new Item();
            darkMatter.SetItemName("Dark Matter");
            darkMatter.SetItemType(ItemType.DarkMatter);
            darkMatter.AddItemImage(darkMatterImage);
            darkMatter.SetStackable(100);

            return darkMatter;
        }
        return null;

    }
}
