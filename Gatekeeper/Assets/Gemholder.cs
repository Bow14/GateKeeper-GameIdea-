using System;
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
}

internal class Key
{
    public class KeyType
    {
        
    }
}
