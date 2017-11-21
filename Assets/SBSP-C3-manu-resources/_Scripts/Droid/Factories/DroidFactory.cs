using UnityEngine;

[System.Serializable]
public class DroidFactory{

    public static DroidFactory instance;

    public Sprite gatherDroidImage;
    public Sprite repairDroidImage;

    public DroidFactory()
    {

        instance = this;

    }

    public Droid CreateDroid(DroidType type)
    {

        if (type == DroidType.SearchDroid)
        {

            Droid droid = new SearchDroid();
            droid.SetItemType(ItemType.Droid);
            droid.SetItemName("Search Droid");
            droid.GetDroidModel().GetDroidView().SetDroidSprite(gatherDroidImage);
            droid.AddItemImage(gatherDroidImage);
            droid.SetStackable(1);

            return droid;

        }

        if (type == DroidType.RepairDroid)
        {

            Droid droid = new RepairDroid();
            droid.SetItemType(ItemType.Droid);
            droid.SetItemName("Repair droid");
            droid.GetDroidModel().GetDroidView().SetDroidSprite(repairDroidImage);
            droid.AddItemImage(repairDroidImage);
            droid.SetStackable(1);

            return droid;

        }

        return null;

    }

}
