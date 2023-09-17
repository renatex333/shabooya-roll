using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Target;
    public float speed = 0;
    public int numberOfObjects;
    private Vector3[] positions;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        positions = new[]{
            new Vector3( -45, 0.5f,  45),
            new Vector3(  45, 0.5f, -45)
        };
        
        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject enemy = Instantiate(Prefab, positions[i] * 3, Quaternion.identity);
            enemy.GetComponent<EnemyController>().Target = Target;
            enemy.GetComponent<EnemyController>().speed = 100;
        }
        
    }
}
