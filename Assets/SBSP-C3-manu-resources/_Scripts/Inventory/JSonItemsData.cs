using UnityEngine;

public class JSonItemsData : MonoBehaviour {

    public ItemLists itemLists = new ItemLists();


    void Awake()
    {
        TextAsset loadJSon = Resources.Load("ItemClass") as TextAsset;

        if (loadJSon != null)
        {
            itemLists = JsonUtility.FromJson<ItemLists>(loadJSon.text);
        }
    }

}
