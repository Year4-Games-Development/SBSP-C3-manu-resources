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

    public Droid CreateDroid(int type)
    {

        Droid droid = new Droid();
        droid.GetDroidModel().GetDroidView().SetDroidSprite(repairDroidImage);

        return droid;

    }

}
