using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlight : MonoBehaviour
{
    public float thrust;
    public float thrustMult;
    public float yawMult;
    public float pitchMult;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float pitch = Input.GetAxis("Vertical");
        float yaw = Input.GetAxis("Horizontal");

        _rb.AddRelativeForce(0f, thrust * thrustMult * Time.deltaTime, 0f);
        _rb.AddRelativeTorque(pitch * pitchMult * Time.deltaTime, -yaw * yawMult * 2 * Time.deltaTime, yaw * yawMult * Time.deltaTime);
    }
}
