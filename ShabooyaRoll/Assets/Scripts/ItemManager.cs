using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;
using Debug=UnityEngine.Debug;

public class ItemManager : MonoBehaviour
{
    public GameObject Prefab;
    public int numberOfObjects;
    private Vector3[] positions;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        positions = new[]{
            new Vector3( -45, 0.5f,  45),
            new Vector3(  35, 0.5f,  45),
            new Vector3( -45, 0.5f, -45),
            new Vector3(  45, 0.5f, -45),
            new Vector3( -15, 0.5f,  45),
            new Vector3(  15, 0.5f,  45),
            new Vector3( -35, 0.5f,  -5),
            new Vector3(  45, 0.5f, -25),
            new Vector3(  45, 0.5f,   5),
            new Vector3( -25, 0.5f, -45),
            new Vector3(   5, 0.5f, -35),
            new Vector3( -45, 0.5f,  35),
            new Vector3(   5, 0.5f,  25),
            new Vector3( -15, 0.5f, -25),
            new Vector3(  25, 0.5f,  -5),
            new Vector3( -25, 0.5f,  45),
            new Vector3(  35, 0.5f,  25),
        };

        HashSet<int> indexes = new HashSet<int>();
        int minValue = 0;
        int maxValue = positions.Length;

        while (indexes.Count < numberOfObjects)
        {
            indexes.Add(Random.Range(minValue, maxValue));
        }
        
        foreach(int i in indexes)
        {
            Instantiate(Prefab, positions[i] * 3, Quaternion.identity);
        }
        
    }
}
