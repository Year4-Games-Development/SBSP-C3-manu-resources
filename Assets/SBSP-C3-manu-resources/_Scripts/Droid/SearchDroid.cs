using System.Collections.Generic;
using UnityEngine;

public class SearchDroid : Droid{

    public SearchDroid()
    {

        SetDroidModel(new SearchDroidModel());

    }

    public override void PerformDroidAction()
    {
        CreateItem();
    }

    public void CreateItem()
    {
        int chance = Mathf.RoundToInt(Random.Range(0f, 5f)); // 20% chance

        GetDroidModel().SetDroidCurrentEnergy(GetDroidModel().GetDroidCurrentEnergy() - GetDroidModel().GetEnergyConsumption());

        if (chance == 1)
        {

            SearchDroidModel model = GetDroidModel() as SearchDroidModel;

            if(model.GetDroidStorageCapacity() > model.GetDroidStorage().Count)
            {

                int item = Mathf.RoundToInt(Random.Range(0f, 1f));
                model.GetDroidStorage().Add(ItemFactory.instance.CreateItem((ItemType)item));
            }

        }

        //update bay GUI, delegate should be better here
        GetDroidModel().GetCurrentDroidBay().GetDroidBayModel().GetDroidBayView().GetDroidEnergyText().text = GetDroidModel().GetDroidCurrentEnergy() + "/" + GetDroidModel().GetDroidMaxEnergy();

    }

    public override void FinishDroidAction()
    {
        SearchDroidModel model = GetDroidModel() as SearchDroidModel;
        
        for(int i = 0; i < model.GetDroidStorage().Count; i++)
        {

            Debug.Log("Adding to inventory new Item");
            model.GetCurrentDroidBay().GetDroidBayModel().GetDroidManager().GetDroidManagerModel().GetMainController().GetInventoryManager().AddItem(model.GetDroidStorage()[i]);

        }

        model.SetDroidStorage(new List<Item>());
    }
}
