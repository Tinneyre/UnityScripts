using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    ItemDataBase database;
    GameObject inventoryPanel;
    GameObject slotPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;

    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();

    void Start()
    {
        database = GetComponent<ItemDataBase>();

        slotAmount = 36;
        inventoryPanel = GameObject.Find("InventoryManager");
        slotPanel = inventoryPanel.transform.Find("Slot Panel").gameObject;
        for (int i = 0; i < slotAmount; i++)
        {
            items.Add(new Item());
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);
        }

        AddItem(0);
        AddItem(1);
        AddItem(1);
        AddItem(1);
        AddItem(1);

        Debug.Log(items[0].Title);
        Debug.Log(items[1].Description);
    

    }

    public void AddItem(int id)
    {
        Item itemToAdd = database.FetchItemByID(id);
        if (itemToAdd.Stackable && CheckIfItemIsInInventory(itemToAdd))
        {

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == id)
                {
                    ItemInfo data = slots[i].transform.GetChild(0).GetComponent<ItemInfo>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    break;
                }
            }
        }
        else {

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == -1)
                {
                    items[i] = itemToAdd;
                    GameObject itemObj = Instantiate(inventoryItem);
                    itemObj.GetComponent<ItemInfo>().item = itemToAdd;
                    itemObj.transform.SetParent(slots[i].transform);
                    itemObj.transform.position = Vector2.zero;
                    itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                    itemObj.name = itemToAdd.Title;

                    break;
                }
            }
        }
            
    }

    bool CheckIfItemIsInInventory(Item item)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].ID == item.ID)
                return true;
        }
            return false;
        
    }
    
    }

	

