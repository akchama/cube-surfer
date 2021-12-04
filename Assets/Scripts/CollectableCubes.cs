using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCubes : MonoBehaviour
{
    private bool _collected;
    private int _index;

    private void Start()
    {
        _collected = false;
    }

    private void Update()
    {
        if (_collected == true)
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -_index, 0);
                Debug.Log("index: " + _index);
            }
    }

    public bool GetIsCollected()
    {
        return _collected;
    }

    public void SetCollected()
    {
        _collected = true;
    }

    public void SetIndex(int index)
    {
        _index = index;
    }

    public int GetIndex()
    {
        return _index;
    }
}