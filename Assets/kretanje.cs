using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretanje : MonoBehaviour
{
    float angle = 0.1F;
    bool kreni = false;
    void Update()
    {
        float horisontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 rotate = new Vector3(horisontal, vertical, 0f);

        if (Input.GetKeyDown(KeyCode.F))
        {
            kreni = true;
        }
        if (kreni)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.right, -angle);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.right, angle);
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Rotate(Vector3.forward, -angle);
            if (Input.GetKey(KeyCode.DownArrow))
                transform.Rotate(Vector3.forward, angle);
        }
    }
}

