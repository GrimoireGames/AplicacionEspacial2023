using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerItemGather : MonoBehaviour
{
    [System.Serializable]
    public class ItemInfo
    {
        public GameObject itemObject;
        public string itemDescription;
    }

    [SerializeField] private List<ItemInfo> pickedItems = new List<ItemInfo>();
    public UnityEvent onItemPickup;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            ItemInfo itemInfo = new ItemInfo();
            itemInfo.itemObject = other.gameObject;
            itemInfo.itemDescription = other.gameObject.GetComponent<Item>().description;
            pickedItems.Add(itemInfo);
            other.gameObject.SetActive(false);
            onItemPickup.Invoke();
            Debug.Log("Item picked up");
        }
    }

    public List<ItemInfo> GetPickedItems()
    {
        return pickedItems;
    }
}