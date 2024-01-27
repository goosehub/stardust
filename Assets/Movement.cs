using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody Player;
    float RotationSpeed = 100;
    float ThrustSpeed = 20000;

    void Start()
    {
    }

    void FixedUpdate()
    {
        Thrust();
        Rotation();
    }

    void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Player.AddForce(Player.transform.forward * ThrustSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            Player.AddForce(Player.transform.forward * ThrustSpeed * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Player.AddForce(Player.transform.forward * -ThrustSpeed * Time.deltaTime);
        }
    }

    void Rotation()
    {
        if (Input.GetKey("w"))
        {
            Vector3 angle = new Vector3(RotationSpeed, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * -Time.fixedDeltaTime);
            Player.MoveRotation(Player.rotation * deltaRotation);
        }
        if (Input.GetKey("s"))
        {
            Vector3 angle = new Vector3(-RotationSpeed, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * -Time.fixedDeltaTime);
            Player.MoveRotation(Player.rotation * deltaRotation);
        }
        if (Input.GetKey("a"))
        {
            Vector3 angle = new Vector3(0, -RotationSpeed, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            Player.MoveRotation(Player.rotation * deltaRotation);
        }
        if (Input.GetKey("d"))
        {
            Vector3 angle = new Vector3(0, RotationSpeed, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            Player.MoveRotation(Player.rotation * deltaRotation);
        }
        if (Input.GetKey("q"))
        {
            Vector3 angle = new Vector3(0, 0, RotationSpeed);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            Player.MoveRotation(Player.rotation * deltaRotation);
        }
        if (Input.GetKey("e"))
        {
            Vector3 angle = new Vector3(0, 0, -RotationSpeed);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            Player.MoveRotation(Player.rotation * deltaRotation);
        }
    }
}
