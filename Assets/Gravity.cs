using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody Player;
    public SphereCollider Body;
    public float BodyMass;
    float PullForce = -500;
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
        // GravityDistance is a point between surface and center of planet
        float GravityDistance = Distance - (Body.transform.localScale.y / 4);
        float DistanceForce = (GravityDistance * GravityDistance) / GravityDistance;
        float GravityForce = PullForce * (BodyMass / DistanceForce);
        Player.AddForce(ForceDirection.normalized * GravityForce * Time.fixedDeltaTime);
    }
}
