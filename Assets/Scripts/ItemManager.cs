using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager instance;

    [SerializeField] private List<Item> items = new List<Item>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static ItemManager GetInstance()
    {
        return instance;
    }

    public void AddItem(string name, string description)
    {
        Item item = gameObject.AddComponent<Item>();
        item.itemName = name;
        item.description = description;
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public List<Item> GetItems()
    {
        return items;
    }
}