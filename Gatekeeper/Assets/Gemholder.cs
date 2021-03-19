﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemholder : MonoBehaviour
    //tutorial on how to use doors with keys aka my gems
    //https://www.youtube.com/watch?v=MIt0PJHMN5Y&t=0s credit goes to Code monkey with this tutorial
{
    private List<Key.KeyType> keyList;

    private void Awake()
    {
        keyList = new List<Key.KeyType>();
    }

    public void AddKey(Key.KeyType keyType)
    {
        keyList.Add(keyType);
    }

    public void RemoveKey(Key.KeyType keyType)
    {
        keyList.Remove(keyType);
    }

    public bool ContainKey(Key.KeyType keyType)
    {
        return keyList.Contains(keyType); //Allows the function to return to value
    }
}


public class Key
{
    public class KeyType
    {
        
    }
}
