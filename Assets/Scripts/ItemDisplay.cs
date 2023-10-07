using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField] private playerItemGather itemGather;
    [SerializeField] private TextMeshProUGUI itemText;
    [SerializeField] private TextMeshProUGUI itemName; // new field for item name
    [SerializeField] private Image itemImage;
    [SerializeField] GameObject itemDisplay;    // new field for item display

    private Coroutine displayCoroutine;

    private void Start()
    {
        itemGather.onItemPickup.AddListener(UpdateItemText);
        itemDisplay.SetActive(false);    // enable the item display
    }

    private void OnDestroy()
    {
        itemGather.onItemPickup.RemoveListener(UpdateItemText);
    }

    private void UpdateItemText()
    {
        if (displayCoroutine != null)
        {
            StopCoroutine(displayCoroutine);
        }

        List<playerItemGather.ItemInfo> pickedItems = itemGather.GetPickedItems();

        if (pickedItems.Count > 0)
        {
            itemDisplay.SetActive(true); // enable the item display
            displayCoroutine = StartCoroutine(DisplayItemText(pickedItems[pickedItems.Count - 1]));
        }
        else
        {
            itemText.text = "";
            itemName.text = ""; // clear the item name
            itemImage.enabled = false;
        }
    }

    private IEnumerator DisplayItemText(playerItemGather.ItemInfo itemInfo)
    {
        itemText.text = itemInfo.itemDescription;
        itemName.text = itemInfo.itemName; // set the item name
        itemImage.sprite = itemInfo.itemObject.GetComponent<SpriteRenderer>().sprite;
        itemImage.enabled = true;

        yield return new WaitForSeconds(5f);

        itemText.text = "";
        itemName.text = ""; // clear the item name
        itemImage.enabled = false;
    }
}