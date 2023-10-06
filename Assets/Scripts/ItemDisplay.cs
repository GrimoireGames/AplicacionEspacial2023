using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField] private playerItemGather itemGather;
    [SerializeField] private TextMeshProUGUI itemText;

    private Coroutine displayCoroutine;

    private void Start()
    {
        itemGather.onItemPickup.AddListener(UpdateItemText);
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
            displayCoroutine = StartCoroutine(DisplayItemText(pickedItems[pickedItems.Count - 1].itemDescription));
        }
        else
        {
            itemText.text = "";
        }
    }

    private IEnumerator DisplayItemText(string itemDescription)
    {
        itemText.text = itemDescription;

        yield return new WaitForSeconds(5f);

        itemText.text = "";
    }
}