using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class collo : MonoBehaviour
{
    private CinemachineFreeLook vcam;

    float Ycap;
    void Start()
    {
        
    }
    
    private void Awake() {
        vcam = GetComponent<CinemachineFreeLook>();
    }
    // Update is called once per frame
    void Update()
    {
        Ycap = Mathf.Clamp(vcam.m_YAxis.Value,0.1f,0.5f);
        vcam.m_YAxis.Value = Ycap;


    }
}
