using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okret : MonoBehaviour
{

    public Transform target;
    
    void Start()
    {
        Vector3 dir = target.position - transform.position;
        Vector3 copy = new Vector3(0.0f, 0.0f, 0.0f);
        copy.x = dir.z;
        copy.y = 0f;
        copy.z = -dir.x;
        Quaternion rotation = Quaternion.LookRotation(copy);
        transform.rotation = rotation;
    }   
}
