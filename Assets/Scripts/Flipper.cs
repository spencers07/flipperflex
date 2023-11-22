using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(HingeJoint))]
public class Flipper : MonoBehaviour
{
    [SerializeField] private UnityEvent OnHit;

    private HingeJoint hinge;

    [SerializeField] private int mouseButton = 0;
    [SerializeField] private float restingPosition = 0;
    [SerializeField] private float targetPosition = 0;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        
        JointLimits jointLimits = hinge.limits;
        jointLimits.min = restingPosition;
        jointLimits.max = targetPosition;
        hinge.limits = jointLimits;
        hinge.useLimits = true;
    }

    void Update()
    {
        JointSpring jointSpring = hinge.spring;

        jointSpring.targetPosition = restingPosition;
    
        if (Input.GetMouseButton(mouseButton)) {
            jointSpring.targetPosition = targetPosition;
        }

        hinge.spring = jointSpring;
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        OnHit.Invoke();
    }
}
