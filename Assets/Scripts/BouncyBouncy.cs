using UnityEngine;
using System.Collections;

public class BouncyBouncy
{
    public float bounciness;
    void OnCollisionEnter(Collision other)
    {
        //We use the relative velocity to determine the direction of the collision.
        Vector3 direction = other.relativeVelocity;
        //We use the magnitude of the relative velocity to determine the force of the collision.
        float force = other.relativeVelocity.magnitude;
        //We use the direction and force to determine the direction and force of the bounce.
        other.rigidbody.AddForce(direction * force * bounciness);
    }
}