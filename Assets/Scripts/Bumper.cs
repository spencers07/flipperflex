using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    void OnCollisionEnter(Collision collision) {
        if (!collision.gameObject.CompareTag("Player")) return;

        Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();

        Vector3 dir = transform.position - collision.GetContact(0).point;

        Debug.Log(dir);

        rigidbody.AddForce(-dir * 75);
    }

}
