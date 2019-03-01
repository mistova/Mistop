using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    private Vector3 uzaklik;
    public GameObject takip;

    // Use this for initialization
    void Start()
    {
        uzaklik = transform.position - takip.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {
        transform.position = uzaklik + takip.transform.position;
    }
}