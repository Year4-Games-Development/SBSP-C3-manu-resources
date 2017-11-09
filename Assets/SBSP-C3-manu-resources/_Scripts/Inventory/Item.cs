/**
 * Model class used to handle and store variables
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int Power { get; set; }
    public int Defence { get; set; }
    public int Weight { get; set; }
    public string Description { get; set; }
    public bool Stackable { get; set; }
    public int Rarity { get; set; }
    public string Slug { get; set; }
    public Sprite Sprite { get; set; }

    public Item(int id, string title, int power, int defence, int weight, string description,
        bool stackable, int rarity, string slug)
    {
        this.ID = id;
        this.Title = title;
        this.Power = power;
        this.Defence = defence;
        this.Weight = weight;
        this.Description = description;
        this.Stackable = stackable;
        this.Rarity = rarity;
        this.Slug = slug;

        this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug);
    }

    public Item()
    {
        this.ID = -1;
    }
}