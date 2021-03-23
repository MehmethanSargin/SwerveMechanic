using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody body;
    [SerializeField]
    float speed;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    void Update()
    {
        body.velocity = Vector3.forward * speed;
    }
}
