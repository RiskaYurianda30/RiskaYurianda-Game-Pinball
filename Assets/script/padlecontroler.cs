using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padlecontroler : MonoBehaviour
{
    public KeyCode input;

    private float targetPressed;
    private float targetRelase;
    private HingeJoint hinge;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelase = hinge.limits.min;
    }
    private void Update()
    {
        ReadInput();
    }
    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }  
        else
        {
            jointSpring.targetPosition = targetRelase;
        }
        hinge.spring = jointSpring;
    }
}
