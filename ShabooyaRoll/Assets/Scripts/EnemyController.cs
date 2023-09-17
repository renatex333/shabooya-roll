using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{

    public GameObject Target;
    public float speed = 0;
    

    private Rigidbody rb;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = (Target.transform.position - transform.position).normalized * 50;
        rb.AddForce(movement * speed);
    }
}
