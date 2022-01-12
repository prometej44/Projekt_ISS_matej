using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sile : MonoBehaviour 
{
    private float vrijeme = 0f;
    private float vrijeme_propulzije = 20f;
    private int iznos_sile = 2500;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    bool kreni = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            kreni = true;
        }

        if (kreni)
        {
            vrijeme += Time.deltaTime;
            if (vrijeme > vrijeme_propulzije)
            {
                rb.useGravity = true;
                rb.drag = 0.1f;
                Physics.gravity = new Vector3(0f, -3f, 0f);
            }
            else rb.AddForce(transform.up * iznos_sile);
        }
    }
}
