using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListManager : MonoBehaviour
{
    //private ArrayList itemList;
    [SerializeField]
    private List<string> itemList;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize the ArrayList
        //itemList = new ArrayList();
        itemList = new List<string>();

        // Adding some initial items
        itemList.Add("Apple");
        itemList.Add("Banana");
        itemList.Add("Cherry");

        // Display current items
        AddItem("Durian");
        AddItem("Watermelon");
        DeleteItem("Banana");
        DisplayItems();

    }


    // Update is called once per frame
    void Update()
    {

    }
    public void DisplayItems()
    {
        Debug.Log("Current items in the list:");
        foreach (string item in itemList)
        {
            Debug.Log(item);
        }
    }
    public void AddItem(string item)
    {
        itemList.Add(item);
        Debug.Log($"Added: {item}");
    }
    public void DeleteItem(string item)
    {
        if (itemList.Contains(item))
        {
            itemList.Remove(item);
            Debug.Log($"Deleted: {item}");
        }
        else
        {
            Debug.Log($"Item not found: {item}");
        }



    }
}
