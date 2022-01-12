using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class mjerac_brzine : MonoBehaviour
{

    private float brzina;
    private float vrijeme;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CalculateSpeed());
        vrijeme += Time.deltaTime;

    }

    IEnumerator CalculateSpeed()

    {

        Vector3 LastPosition = transform.position;
        yield return new WaitForFixedUpdate();
        brzina = (LastPosition - transform.position).magnitude / Time.deltaTime; 

    }

}
