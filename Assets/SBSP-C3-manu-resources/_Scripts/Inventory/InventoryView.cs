using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour {

    public GameObject slotsPanel;
    public GameObject slot;
    public GameObject slotItem; //Item template.

    //Slots list.
    public List<GameObject> slotsList = new List<GameObject>();
}
