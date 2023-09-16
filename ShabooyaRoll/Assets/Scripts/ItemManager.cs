using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject Prefab;
    public int NumberOfObjects;
    // private Vector3[] _positions;


    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // _positions = new[]{
        //     new Vector3( -45, 0.5f,  45),
        //     new Vector3(  35, 0.5f,  45),
        //     new Vector3( -45, 0.5f, -45),
        //     new Vector3(  45, 0.5f, -45),
        //     new Vector3( -15, 0.5f,  45),
        //     new Vector3(  15, 0.5f,  45),
        //     new Vector3( -35, 0.5f,  -5),
        //     new Vector3(  45, 0.5f, -25),
        //     new Vector3(  45, 0.5f,   5),
        //     new Vector3( -25, 0.5f, -45),
        //     new Vector3(   5, 0.5f, -35),
        //     new Vector3( -45, 0.5f,  35),
        //     new Vector3(   5, 0.5f,  25),
        //     new Vector3( -15, 0.5f, -25),
        //     new Vector3(  25, 0.5f,  -5),
        //     new Vector3( -25, 0.5f,  45),
        //     new Vector3(  35, 0.5f,  25),
        // };
        // for (int i = 0; i < NumberOfObjects; i++)
        // {
        //     Instantiate(Prefab, _positions[i], Quaternion.identity);
        // }
        // Tamanho dos treco errado e posição errada
        Instantiate(Prefab, new Vector3( -45, 0.5f,  45), Quaternion.identity);
        
    }
}
