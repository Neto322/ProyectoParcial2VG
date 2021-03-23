using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum Axel
{
    Front,
    Rear,
}

[Serializable]
public struct Wheel
{
    public GameObject model;
    public WheelCollider collider;

    public Axel axel;
}

public class RoverController : MonoBehaviour
{
    [SerializeField]
    float maxAcceleration = 20.0f;

    [SerializeField]
    float turnSensitivity = 1.0f;

    [SerializeField]
    float maxSteerAngle = 45.0f;

    [SerializeField]
    List<Wheel> wheels;

    float inputX,inputY;

    private Rigidbody rb;

    InputRover inputActions;

    private void Awake() {
       
        inputActions = new InputRover();
    }

    private void OnEnable() {
        inputActions.Enable();    
    }

    private void OnDisable() {
        inputActions.Disable();
    }

    void Start()
    {
        
    }


    void Update()
    {
        Inputs();
        Move();
        Turn();
        WheelAnimation();
    }

    private void LateUpdate() {

    }

    private void Turn()
    {
        foreach(var wheel in wheels)
        {
            if(wheel.axel == Axel.Front)
            {
                var steerAngle = inputX * turnSensitivity * maxSteerAngle;
                wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle,steerAngle,0.5f);
            }
        }
    }

    private void  Inputs()
    {
        inputX = inputActions.Move.Movement.ReadValue<Vector2>().x;
        inputY = inputActions.Move.Movement.ReadValue<Vector2>().y;
    }
    private void Move()
    {
        foreach(var wheel in wheels)
            {
                wheel.collider.motorTorque = inputY * maxAcceleration * 500 * Time.deltaTime;
            }


    }

    private void WheelAnimation()
    {
        foreach(var wheel in wheels)
        {
            Quaternion rot;
            Vector3 pos;
            wheel.collider.GetWorldPose(out pos, out rot);
            wheel.model.transform.position = pos;
            wheel.model.transform.rotation = rot;
        }
      
    }
}
