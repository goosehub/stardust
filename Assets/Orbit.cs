using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public SphereCollider Planet;
    public SphereCollider Moon;
    public float TargetDistance;
    public float TargetSpeed;
    float TargetDistanceMargin = 10;
    float TargetSpeedMargin = 10;
    float TargetDistanceCorrectionForce = 10;
    float TargetSpeedCorrectionForce = 10;

    void Start()
    {
    }

    void Update()
    {
        return;
        Vector3 ForceDirection = Moon.transform.position - Planet.transform.position;
        float CurrentDistance = Vector3.Distance(Planet.transform.position, Moon.transform.position);
        if (CurrentDistance > TargetDistance + TargetDistanceMargin)
        {
        }
        if (CurrentDistance < TargetDistance - TargetDistanceMargin)
        {
        }
        float CurrentSpeed = 0;
        if (CurrentSpeed > TargetSpeed + TargetSpeedMargin)
        {
        }
        if (CurrentSpeed < TargetSpeed - TargetSpeedMargin)
        {
        }
    }
}
