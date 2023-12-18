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
    public ItemType itemType; //Ÿ�� ������ 
    public string itemName;
    public Sprite itemImge; 

    public bool Use() //������ ��뿩�� 
    {
        return false; 
    }
}

