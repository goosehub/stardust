using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public SphereCollider Planet;
    public SphereCollider Moon;
    public float Radius;
    public float Speed;
    public float Angle;

    void Update()
    {
        float x = Planet.transform.position.x + Mathf.Cos(Angle) * Radius;
        float y = Planet.transform.position.y;
        float z = Planet.transform.position.z + Mathf.Sin(Angle) * Radius;

        Moon.transform.position = new Vector3(x, y, z);

        Angle += Speed * Time.fixedDeltaTime;
    }
}
