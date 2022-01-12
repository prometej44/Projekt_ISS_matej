using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_zoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private bool kreni = false;
    private float vrijeme = 0;
    private int i;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            kreni = true;
        }
        if (kreni)
        {
            vrijeme += Time.deltaTime;
            if (vrijeme < 2)
            {
                i = 50;
            }
            else if (vrijeme < 5 && vrijeme > 2)
            {
                i = 30;
            }
            else if (vrijeme > 5 && vrijeme < 8)
            {
                i = 15;
            } 
            else i = 2;
            CinemachineFreeLook vcam = GetComponentInChildren<CinemachineFreeLook>();
            vcam.m_CommonLens = true;
            vcam.m_Lens.FieldOfView = i;
        }
        
    }
}
