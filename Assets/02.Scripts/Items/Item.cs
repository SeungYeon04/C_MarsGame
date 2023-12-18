using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipment, 
    Consumables, 
    Etc
}

[System.Serializable]
public class Item
{
    public ItemType itemType; //타입 가져옴 
    public string itemName;
    public Sprite itemImge; 

    public bool Use() //아이템 사용여부 
    {
        return false; 
    }
}

