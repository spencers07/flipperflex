using UnityEngine;
using UnityEngine.Events;

public class BallReset : MonoBehaviour
{
    [SerializeField] private UnityEvent OnReset;

    [SerializeField] private Transform ball;
    [SerializeField] private Vector3 resetPosition;

    void OnTriggerEnter(Collider collider) {
       if (!collider.CompareTag("Player")) return;

        ball.position = resetPosition;

        OnReset.Invoke();
    }
}
