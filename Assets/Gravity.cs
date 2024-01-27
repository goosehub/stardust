using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody Player;
    public SphereCollider Body;
    public float BodyMass;
    float PullForce = -1000;
    float DistanceDivider = 1;

    void Start()
    {

    }

    void Update()
    {
        PullPlayer();
    }

    void PullPlayer()
    {
        Vector3 ForceDirection = Player.transform.position - Body.transform.position;
        float Distance = Vector3.Distance(Player.transform.position, Body.transform.position);
        // Gravity distance is between surface and center of planet
        float GravityDistance = Distance - (Body.transform.localScale.y / 3);
        float DistanceForce = (GravityDistance * GravityDistance) / GravityDistance;
        float GravityForce = PullForce * (BodyMass / DistanceForce);
        Player.AddForce(ForceDirection.normalized * GravityForce * Time.fixedDeltaTime);
    }
}
