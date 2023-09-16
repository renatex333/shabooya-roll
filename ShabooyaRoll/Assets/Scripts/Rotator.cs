using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(30, 30, 30) * Time.deltaTime);
        // transform.Translate(new Vector3(0, (float)Math.Sin(Time.time)/2, 0) * Time.deltaTime);
    }
}
