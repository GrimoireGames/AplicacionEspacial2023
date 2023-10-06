using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerItemGather : MonoBehaviour
{
    [SerializeField] private List<GameObject> pickedItems = new List<GameObject>();

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            pickedItems.Add(other.gameObject);
            other.gameObject.SetActive(false);
            Debug.Log("Item picked up");
        }
    }

    //mandar a llamar despues de un timer
    public List<GameObject> GetPickedItems()
    {
        return pickedItems;
    }
}