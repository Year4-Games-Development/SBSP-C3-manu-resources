using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InventorySlotView{

    [SerializeField]
    private Text _itemName;
    [SerializeField]
    private Text _itemCount;
    [SerializeField]
    private Image _itemImage;
    [SerializeField]
    private Button _slotButton;

    public void SetItemName(string name)
    {
        _itemName.gameObject.SetActive(true);
        _itemName.text = name;

    }

    public void SetItemCount(int count,int maxCount)
    {
        _itemCount.gameObject.SetActive(true);
        _itemCount.text = "" + count + "/" + maxCount;

    }

    public void SetItemImage(Sprite sprite)
    {
        _itemImage.gameObject.SetActive(true);
        _itemImage.sprite = sprite;
    }

    public void Initialize()
    {

        DisableAllUI();

    }

    public Button GetSlotButton()
    {

        return _slotButton;

    }

    public void DisableAllUI()
    {
        _itemImage.gameObject.SetActive(false);
        _itemName.gameObject.SetActive(false);
        _itemCount.gameObject.SetActive(false);
    }
}
