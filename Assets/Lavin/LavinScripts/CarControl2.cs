using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarControl2 : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;

    [SerializeField] private GameObject StartPosition;

    public float acceleration = 1000f;
    public float breakingForce = 1000f;
    public float maxTurnAngle = 15f;
    public Rigidbody RigidBodyCar;

    public float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;



    private void FixedUpdate()
    {

        currentAcceleration = acceleration * Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else
            currentBreakForce = 0f;

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;

        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(backLeft, backLeftTransform);
        UpdateWheel(backRight, backRightTransform);

    }

    // public void StopCar() {
        
    // }

    void UpdateWheel(WheelCollider col, Transform trans)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        trans.position = position;
        trans.rotation = rotation;
    }
  

      void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            transform.position = StartPosition.transform.position;
            transform.rotation = StartPosition.transform.rotation;
            // GetComponent<CarControl2>().StopCar();
            RigidBodyCar.velocity = new Vector3(0,0,0);
            currentAcceleration = 0f;
        }
    }

      void OnTriggerEnter(Collider col){
       Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Water"){
            transform.position = StartPosition.transform.position;
            transform.rotation = StartPosition.transform.rotation;
            RigidBodyCar.velocity = new Vector3(0,0,0);
            currentAcceleration = 0f;

        }

        if (col.gameObject.tag == "finishLine")
        {
            SceneManager.LoadScene("SlutScene");
        }

    }
    // void onCollisionEnter(Collision col)
    // {
    //     if (col.gameObject.tag == "finishGame")
    //     {
    //         SceneManager.LoadScene("RoadTest");
    //     }
    // }
}