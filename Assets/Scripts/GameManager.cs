using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject collectableFirst;
    public GameObject collectableSecond;

    private int goIndex = 0;

    private void Start()
    {
        CreateCollectable(collectableFirst);
        CreateCollectable(collectableFirst);
        CreateCollectable(collectableFirst);
        CreateCollectable(collectableFirst);
        CreateCollectable(collectableSecond);
        CreateCollectable(collectableSecond);
        CreateCollectable(collectableSecond);
        CreateCollectable(collectableFirst);
    }

    public void CreateCollectable(GameObject type)
    {
        Instantiate(type, new Vector3(-20 - goIndex * 5, .5f, 0f), Quaternion.identity);
        goIndex++;
    }
}