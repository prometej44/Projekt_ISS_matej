using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zvuk_lansiranja : MonoBehaviour
{


    bool kreni = false;
    bool odradeno = false;


    void Update()
    {
        if (!odradeno)
        {
            AudioSource audioData = GetComponent<AudioSource>();
            if (Input.GetKeyDown(KeyCode.F))
            {
                kreni = true;
            }

            if (kreni)
            {
                audioData.Play(0);
                audioData.time = 0.5f;
                kreni = false;
                odradeno = true;
            }
        }
        
    }
}
