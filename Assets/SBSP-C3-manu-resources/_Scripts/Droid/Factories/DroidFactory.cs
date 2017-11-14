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
            droid.GetDroidModel().GetDroidView().SetDroidSprite(gatherDroidImage);

            return droid;

        }

        if (type == DroidType.RepairDroid)
        {

            Droid droid = new RepairDroid();
            droid.GetDroidModel().GetDroidView().SetDroidSprite(repairDroidImage);

            return droid;

        }

        return null;

    }

}
