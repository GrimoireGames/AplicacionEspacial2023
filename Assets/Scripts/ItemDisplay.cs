using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField] private playerItemGather itemGather;
    [SerializeField] private TextMeshProUGUI itemText;

    private void Start()
    {
        UpdateItemText();
        itemGather.onItemPickup.AddListener(UpdateItemText);
    }

    private void OnDestroy()
    {
        itemGather.onItemPickup.RemoveListener(UpdateItemText);
    }

    private void UpdateItemText()
    {
        List<playerItemGather.ItemInfo> pickedItems = itemGather.GetPickedItems();
        string itemDescriptionText = "";

        foreach (playerItemGather.ItemInfo itemInfo in pickedItems)
        {
            itemDescriptionText += itemInfo.itemDescription + "\n";
        }

        itemText.text = itemDescriptionText;
    }
}