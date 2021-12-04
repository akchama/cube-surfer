using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private GameObject character;

    private int height = 0;
    public GameObject[] collectables;
    public GameObject[] collectables2;
    public GameObject[] finalArray;
    public List<GameObject> stack;

    private void Start()
    {
        character = GameObject.Find("Character");
    }

    private void Update()
    {
        character.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag is "Collect" or "Collect1")
        {
            height++;
            other.gameObject.GetComponent<CollectableCubes>().SetCollected();
            other.gameObject.GetComponent<CollectableCubes>().SetIndex(height);
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.transform.parent = character.transform;
            stack.Add(other.gameObject);
            if (stack.Count > 2)
                if (stack[^1].CompareTag(stack[^2].tag) && stack[^1].CompareTag(stack[^3].tag))
                {
                    Destroy(stack[^1]);
                    Destroy(stack[^2]);
                    Destroy(stack[^3]);
                    height -= 3;
                }
        }
    }
}