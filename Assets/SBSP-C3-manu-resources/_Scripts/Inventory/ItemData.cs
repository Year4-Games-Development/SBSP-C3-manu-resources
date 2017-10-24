using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    private string name;
    private int value;
    private int quantity;
    private int power;
    private int defence;
    private int weight;
    private string description;
    private bool stackable;
    private int rarity;
    private string spriteName;

    public string Name { get { return this.name; } set { name = value; } }
    public int Value { get { return this.value; } set {  this.value = value; } }
    public int Quantity { get { return quantity; } set { quantity = value; } }
    public int Power { get { return power; } set { power = value; } }
    public int Defence { get { return defence; } set { defence = value; } }
    public int Weight { get { return weight; } set { weight = value; } }
    public string Description { get { return description; } set { description = value; } }
    public bool Stackable { get { return stackable; } set { stackable = value; } }
    public int Rarity { get { return rarity; } set { rarity = value; } }
    public string SpriteName { get { return spriteName; } set { spriteName = value; } }


}
