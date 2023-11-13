using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Vector3 resetPosition;

    void OnTriggerEnter(Collider collider) {
       if (!collider.CompareTag("Player")) return;

        ball.position = resetPosition;
    }
}
