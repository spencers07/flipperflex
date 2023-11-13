using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    private GameObject ball;

    void Update()
    {
        if (!ball) return;

       if (Input.GetKeyDown(KeyCode.Space)) {
            Rigidbody rigidbody = ball.GetComponent<Rigidbody>();

            rigidbody.AddForce(Vector3.up * 250);
       }
    }

    void OnCollisionEnter(Collision collision) {
        if (!collision.gameObject.CompareTag("Player")) return;
        ball = collision.gameObject;
    }

    void OnCollisionExit(Collision collision) {
        if (!collision.gameObject.CompareTag("Player")) return;
        ball = null; 
    }
}
