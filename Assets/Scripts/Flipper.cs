using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class Flipper : MonoBehaviour
{
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

        JointSpring jointSpring = hinge.spring;
        jointSpring.spring = 200;
        jointSpring.damper = 3;
        hinge.spring = jointSpring;
        hinge.useSpring = true;
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
}
