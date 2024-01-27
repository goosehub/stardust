using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public SphereCollider Planet;
    public float PlanetRotation;

    void Start()
    {
        
    }

    void Update()
    {
        Planet.transform.Rotate(0, PlanetRotation * Time.deltaTime, 0);
    }
}
