using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody player;
    public SphereCollider planet;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Ready");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Thrust();
        Rotation();
        Friction();
        Gravity();
    }

    void Thrust()
    {
        if (Input.GetKey("space"))
        {
            player.AddForce(player.transform.forward * 1000 * Time.deltaTime);
        }
        if (Input.GetKey("z"))
        {
            player.AddForce(player.transform.forward * -1000 * Time.deltaTime);
        }
    }

    void Rotation()
    {
        if (Input.GetKey("w"))
        {
            Vector3 angle = new Vector3(100, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * -Time.fixedDeltaTime);
            player.MoveRotation(player.rotation * deltaRotation);
        }
        if (Input.GetKey("s"))
        {
            Vector3 angle = new Vector3(-100, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * -Time.fixedDeltaTime);
            player.MoveRotation(player.rotation * deltaRotation);
        }
        if (Input.GetKey("a"))
        {
            Vector3 angle = new Vector3(0, -100, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            player.MoveRotation(player.rotation * deltaRotation);
        }
        if (Input.GetKey("d"))
        {
            Vector3 angle = new Vector3(0, 100, 0);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            player.MoveRotation(player.rotation * deltaRotation);
        }
        if (Input.GetKey("q"))
        {
            Vector3 angle = new Vector3(0, 0, 100);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            player.MoveRotation(player.rotation * deltaRotation);
        }
        if (Input.GetKey("e"))
        {
            Vector3 angle = new Vector3(0, 0, -100);
            Quaternion deltaRotation = Quaternion.Euler(angle * Time.fixedDeltaTime);
            player.MoveRotation(player.rotation * deltaRotation);
        }
    }

    void Friction()
    {
    }

    void Gravity()
    {
        float pullForce = -1000;
        Vector3 forceDirection = transform.position - planet.transform.position;
        player.AddForce(forceDirection.normalized * pullForce * Time.fixedDeltaTime);
    }
}
