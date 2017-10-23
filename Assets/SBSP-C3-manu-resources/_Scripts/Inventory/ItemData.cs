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
    private string slug;
    private string spriteName;

    public string Name { get { return this.name; } set { value = this.name; } }
    public int Value { get { return this.value; } set { value = this.value; } }
    public int Quantity { get { return quantity; } set { value = quantity; } }
    public int Power { get { return power; } set { value = power; } }
    public int Defence { get { return defence; } set { value = defence; } }
    public int Weight { get { return weight; } set { value = weight; } }
    public string Description { get { return description; } set { value = description; } }
    public bool Stackable { get { return stackable; } set { value = stackable; } }
    public int Rarity { get { return rarity; } set { value = rarity; } }
    public string Slug { get { return slug; } set { value = slug; } }
    public string SpriteName { get { return spriteName; } set { value = spriteName; } }


}
