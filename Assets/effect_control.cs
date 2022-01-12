using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_control : MonoBehaviour
{
    private float vrijeme_propulzije = 20f;
    private float vrijeme = 0f;


    private void Start()
    {
        ParticleSystem sys = GetComponent<ParticleSystem>();
        
        var main = sys.main;
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
            ParticleSystem sys = GetComponent<ParticleSystem>();
            var emission = sys.emission;
            sys.Play();

            vrijeme += Time.deltaTime;

            if (vrijeme > vrijeme_propulzije)
            {
                emission.enabled = false;
            }
        }
    }
}
