using System.Collections;
using System.Collections.Generic;
using LitJson;
using System.IO;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    private List<InventoryModel> database = new List<InventoryModel>();
    private JsonData itemData;


    void Start()
    {

        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/SBSP-C3-manu-resources/StreamingAssets/Items.json"));

        ConstructItemDatabase();
    }

    public InventoryModel FetchItemByID(int id)
    {
        for (int i = 0; i < database.Count; i++)
            if (database[i].ID == id)
                return database[i];

        return null;
    }


    void ConstructItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            database.Add(new InventoryModel((int)itemData[i]["id"], itemData[i]["title"].ToString(),
                itemData[i]["description"].ToString(), (bool)itemData[i]["stackable"],
                itemData[i]["slug"].ToString()
                ));
        }
    }
}