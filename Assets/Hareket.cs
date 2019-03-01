using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public Rigidbody force;
    public Vector3 a;
    // Use this for initialization
    void Start()
    {
        force = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        force.AddForce(Input.GetAxis("Horizontal") * 30, 0, Input.GetAxis("Vertical") * 30);
    }
    void LateUpdate()
    {
        if (transform.position.y < 0)
        {
            a.x = 0;
            a.y = 1;
            a.z = 0;
            transform.position = a;
        }
    }
}
