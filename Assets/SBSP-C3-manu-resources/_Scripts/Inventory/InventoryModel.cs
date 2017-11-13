/**
 * Model class used to handle and store variables
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryModel
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Stackable { get; set; }
    public string Slug { get; set; }
    public Sprite Sprite { get; set; }

    public InventoryModel(int id, string title, string description,
        bool stackable, string slug)
    {
        this.ID = id;
        this.Title = title;
        this.Description = description;
        this.Stackable = stackable;
        this.Slug = slug;

        this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug);
    }

    public InventoryModel()
    {
        this.ID = -1;
    }
}